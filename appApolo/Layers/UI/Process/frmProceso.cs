using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    public partial class frmProceso : Form
    {
        public frmProceso()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMenu ofrmPrincipalMenu = new frmPrincipalMenu();
            ofrmPrincipalMenu.Show();
            this.Close();
        }

        private void atenciónDelPacienteclienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoAtencionPaciente ofrmProcesoAtencionClientePaciente = new frmProcesoAtencionPaciente();
            ofrmProcesoAtencionClientePaciente.MdiParent = this;
            ofrmProcesoAtencionClientePaciente.Show();
        }

        private void estudioExámenLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoEstudioExamenLaboratorio ofrmProcesoEstudioExamenLaboratorio = new frmProcesoEstudioExamenLaboratorio();
            ofrmProcesoEstudioExamenLaboratorio.MdiParent = this;
            ofrmProcesoEstudioExamenLaboratorio.Show();
        }

        private void entregaExámenLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoEntregaExamenLaboratorio ofrmProcesoEntregaExamenLaboratorio = new frmProcesoEntregaExamenLaboratorio();
            ofrmProcesoEntregaExamenLaboratorio.MdiParent = this;
            ofrmProcesoEntregaExamenLaboratorio.Show();
        }

        private void facturaElectrónicaHaciendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoFacturaElectronicaHacienda ofrmProcesoFacturaElectronicaHacienda = new frmProcesoFacturaElectronicaHacienda();
            ofrmProcesoFacturaElectronicaHacienda.MdiParent = this;
            ofrmProcesoFacturaElectronicaHacienda.Show();
        }
    }
}
