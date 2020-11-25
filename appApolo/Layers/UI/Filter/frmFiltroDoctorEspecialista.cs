using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.BLL;

namespace UTN.Winforms.Apolo.Layers.UI.Filtros
{
    public partial class frmFiltroDoctorEspecialista : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public DoctorEspecialista _DoctorEspecialista { get; private set; } = null;

        public frmFiltroDoctorEspecialista()
        {
            InitializeComponent();
        }

        private void toolStripBtnNuevaConsulta_Click(object sender, EventArgs e)
        {
            this.txtFiltro.Clear();
            this.dgvDatos.DataSource = null;
            txtFiltro.Focus();
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
            {
                IBLLDoctorEspecialista _BLLDoctorEspecialista = new BLLDoctorEspecialista();
                string filtro = string.Empty;
                try
                {
                    filtro = this.txtFiltro.Text;
                    filtro = filtro.Replace(' ', '%');
                    filtro = "%" + filtro + "%";
                    this.dgvDatos.AutoGenerateColumns = false;

                    // Configuracion del DataGridView para que se vea bien la imagen.
                    dgvDatos.RowTemplate.Height = 100;
                    dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    this.dgvDatos.DataSource = _BLLDoctorEspecialista.ReadDoctorEspecialistaByFilter(filtro);
                }
                catch (Exception er)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    // Mensaje de Error
                    MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //this.dgvDatos.SelectionMode =   DataGridViewSelectionMode.FullRowSelect;
                if (dgvDatos.RowCount > 0 && dgvDatos.SelectedRows.Count > 0)
                {
                    if (dgvDatos.CurrentCell.Selected)
                    {
                        _DoctorEspecialista = dgvDatos.SelectedRows[0].DataBoundItem as DoctorEspecialista;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                // Mensaje de Error
                MessageBox.Show("Se ha producido el siguiente error " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}