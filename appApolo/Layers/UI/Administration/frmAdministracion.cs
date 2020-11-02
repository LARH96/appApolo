using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Layers.UI.Filtros;

namespace UTN.Winforms.Apolo.Layers.UI.Administration
{
    public partial class frmAdministracion : Form
    {
        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMenu ofrmPrincipalMenu = new frmPrincipalMenu();
            ofrmPrincipalMenu.Show();
            this.Close();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rdBtnDoctorEspecialista_CheckedChanged(object sender, EventArgs e)
        {
            pbxFotografia.Visible = false;
            txtFotografia.Visible = true;

            lblId.Text = "Código Especialista";
            lblId.Enabled = true;

            txtId.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtApellidos.Enabled = false;
            txtNombre.Enabled = false;
            txtContrasenna.Enabled = false;
            txtConfirmarContrasenna.Enabled = false;
            cmbTipoPerfil.Enabled = false;

            btnBuscarDocEspecialista.Enabled = true;
        }

        private void rdBtnOtro_CheckedChanged(object sender, EventArgs e)
        {
            pbxFotografia.Visible = true;
            txtFotografia.Visible = false;

            lblId.Text = "Identificación";
            lblId.Enabled = true;
            btnBuscarDocEspecialista.Enabled = false;

            txtId.Enabled = true;
            txtNombreUsuario.Enabled = true;
            txtApellidos.Enabled = true;
            txtNombre.Enabled = true;
            txtContrasenna.Enabled = true;
            txtConfirmarContrasenna.Enabled = true;
            cmbTipoPerfil.Enabled = true;
        }

        private void btnBuscarDocEspecialista_Click(object sender, EventArgs e)
        {
            frmFiltroDoctorEspecialista ofrmFiltroDoctorEspecialista = new frmFiltroDoctorEspecialista();

            //si elijo un doctor se desbloquea campos contraseña
            txtContrasenna.Enabled = true;
            txtConfirmarContrasenna.Enabled = true;
        }
    }
}
