using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Layers.UI.Maintenance;

namespace UTN.Winforms.Apolo.UI
{
    public partial class frmMantenimiento : Form
    {
        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void gGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMenu ofrmPrincipalMenu = new frmPrincipalMenu();
            ofrmPrincipalMenu.Show();
            this.Close();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoPaciente ofrmMantenimientoPaciente = new frmMantenimientoPaciente();
            ofrmMantenimientoPaciente.MdiParent = this;
            ofrmMantenimientoPaciente.Show();
        }

        private void examenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoExamen ofrmMantenimientoExamen = new frmMantenimientoExamen();
            ofrmMantenimientoExamen.MdiParent = this;
            ofrmMantenimientoExamen.Show();
        }

        private void tipoExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoExamen ofrmTipoExamen = new frmTipoExamen();
            ofrmTipoExamen.MdiParent = this;
            ofrmTipoExamen.Show();
        }

        private void doctoresEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoDoctorOEspecialista ofrmDoctorOEspecialista = new frmMantenimientoDoctorOEspecialista();
            ofrmDoctorOEspecialista.MdiParent = this;
            ofrmDoctorOEspecialista.Show();
        }
    }
}