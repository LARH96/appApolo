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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMenu ofrmPrincipalMenu = new frmPrincipalMenu();
            ofrmPrincipalMenu.Show();
            this.Close();
        }

        private void solicitudesDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteSolicitudesDiarias ofrmReporteSolicitudesDiarias = new frmReporteSolicitudesDiarias();
            ofrmReporteSolicitudesDiarias.MdiParent = this;
            ofrmReporteSolicitudesDiarias.Show();
        }

        private void históricoDeSolicitudesDePacientesClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteHistoricoSolicitudPacienteCliente ofrmReporteHistoricoSolicitudPacienteCliente = new frmReporteHistoricoSolicitudPacienteCliente();
            ofrmReporteHistoricoSolicitudPacienteCliente.MdiParent = this;
            ofrmReporteHistoricoSolicitudPacienteCliente.Show();
        }

        private void dinerosRecibidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDinerosRecibidos ofrmReporteDinerosRecibidos = new frmReporteDinerosRecibidos();
            ofrmReporteDinerosRecibidos.MdiParent = this;
            ofrmReporteDinerosRecibidos.Show();
        }

        private void listadoExámenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteListadoExamenes ofrmReporteListadoExamenes = new frmReporteListadoExamenes();
            ofrmReporteListadoExamenes.MdiParent = this;
            ofrmReporteListadoExamenes.Show();
        }
    }
}
