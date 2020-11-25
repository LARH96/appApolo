using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Layers.UI;
using UTN.Winforms.Apolo.Layers.UI.Administration;
using UTN.Winforms.Apolo.Layers.UI.Process;
using UTN.Winforms.Apolo.Layers.UI.Reports;
using UTN.Winforms.Apolo.Properties;
using UTN.Winforms.Apolo.UI;

namespace UTN.Winforms.Apolo
{
    public partial class frmPrincipalMenu : Form
    {
        public frmPrincipalMenu()
        {
            InitializeComponent();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimiento ofrmMantenimiento = new frmMantenimiento();
            ofrmMantenimiento.Show();
            this.Close();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            frmProceso ofrmProceso = new frmProceso();
            ofrmProceso.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReporte ofrmReporte = new frmReporte();
            ofrmReporte.Show();
            this.Close();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            frmAdministracion ofrmAdministracion = new frmAdministracion();
            ofrmAdministracion.Show();
            this.Close();
        }

        private void frmPrincipalMenu_Load(object sender, EventArgs e)
        {
            AsignaPermisosPerfil();
        }

        public void AsignaPermisosPerfil()
        {
            

            if (Settings.Default.TipoPerfil == "Procesos")
            {
                btnProcesos.Enabled = true;   
            }else if(Settings.Default.TipoPerfil == "Reportes")
            {
                btnReportes.Enabled = true;
            }
            else if (Settings.Default.TipoPerfil == "Administrador")
            {
                btnMantenimiento.Enabled = true;
                btnProcesos.Enabled = true;
                btnReportes.Enabled = true;
                btnAdministracion.Enabled = true;
            }
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe ofrmAcercaDe = new frmAcercaDe();
            ofrmAcercaDe.Show();
        }
    }
}
