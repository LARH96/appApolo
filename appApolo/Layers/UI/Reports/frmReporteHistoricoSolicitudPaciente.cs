using log4net;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Layers.UI.Filter;

namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    public partial class frmReporteHistoricoSolicitudPaciente : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public frmReporteHistoricoSolicitudPaciente()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmReporteHistoricoSolicitudPaciente_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmFiltroPaciente ofrmFiltroPaciente = new frmFiltroPaciente();
            Paciente oPaciente = new Paciente();

            try
            {
                erpError.Clear();
                ofrmFiltroPaciente.ShowDialog();

                if (ofrmFiltroPaciente.DialogResult == DialogResult.OK)
                {
                    oPaciente = ofrmFiltroPaciente._Paciente;
                    this.txtIdPaciente.Text = oPaciente.IdPaciente;
                }
            }
            catch (SqlException sqlError)
            {
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: \n" + Utilitarios.GetCustomErrorByNumber(sqlError), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPaciente.Text))
            {
                erpError.SetError(txtIdPaciente, "Identificación Paciente es requerida");
                txtIdPaciente.Focus();
                return;
            }

            // TODO: This line of code loads data into the 'DSReportes.SolicitudesPacientes' table. You can move, or remove it, as needed.
            this.SolicitudesPacientesTableAdapter.Fill(this.DSReportes.SolicitudesPacientes,
                                                       dtpFechaInicial.Value.ToShortDateString(),
                                                       dtpFechaFinal.Value.ToShortDateString(),
                                                       txtIdPaciente.Text);

            ReportParameter param1 = new ReportParameter("pFechaInicial", this.dtpFechaInicial.Value.ToShortDateString());
            this.rptVisor.LocalReport.SetParameters(param1);

            ReportParameter param2 = new ReportParameter("pFechaFinal", this.dtpFechaInicial.Value.ToShortDateString());
            this.rptVisor.LocalReport.SetParameters(param2);

            this.rptVisor.RefreshReport();
        }
    }
}
