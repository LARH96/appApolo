using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    public partial class frmReporteSolicitudesDiarias : Form
    {
        public frmReporteSolicitudesDiarias()
        {
            InitializeComponent();
        }

        private void frmReporteSolicitudesDiarias_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSReportes.SolicitudesDiarias' table. You can move, or remove it, as needed.
            this.SolicitudesDiariasTableAdapter.Fill(this.DSReportes.SolicitudesDiarias,
                                                     dtpFechaInicial.Value.ToShortDateString(),
                                                     dtpFechaFinal.Value.ToShortDateString());

            ReportParameter param1 = new ReportParameter("pFechaInicial", this.dtpFechaInicial.Value.ToShortDateString());
            this.rptVisor.LocalReport.SetParameters(param1);

            ReportParameter param2 = new ReportParameter("pFechaFinal", this.dtpFechaFinal.Value.ToShortDateString());
            this.rptVisor.LocalReport.SetParameters(param2);

            this.rptVisor.RefreshReport();
        }
    }
}
