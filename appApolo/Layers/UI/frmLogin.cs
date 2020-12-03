using log4net;
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
using System.Windows.Input;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.BLL;
using UTN.Winforms.Apolo.Properties;

namespace UTN.Winforms.Apolo.UI
{
    public partial class frmLogin : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private int contador = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LogonUsuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += " - " + Application.ProductName + " - " + "Versión:  " + Application.ProductVersion;

                _MyLogControlEventos.InfoFormat("Inicio Login");
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

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                LogonUsuario();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContrasena.Focus();
            }
        }

        private void LogonUsuario()
        {
            IBLLUsuario _IBLLUsuario = new BLLUsuario();
            Usuario oUsuario = new Usuario();
            epError.Clear();

            try
            {
                //verifica campos
                if (string.IsNullOrEmpty(this.txtUsuario.Text))
                {
                    epError.SetError(txtUsuario, "Usuario requerido");
                    this.txtUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtContrasena.Text))
                {
                    epError.SetError(txtContrasena, "Contraseñá requerida");
                    this.txtContrasena.Focus();
                    return;
                }

                //Activar para brincarse directo a Menú
                //frmPrincipalMenu ofrmPrincipalMenu1 = new frmPrincipalMenu();
                //ofrmPrincipalMenu1.Show();

                oUsuario.NombreUsuario = txtUsuario.Text;
                oUsuario.Contrasenna = txtContrasena.Text;

                if (_IBLLUsuario.VerificaLoginUsuario(oUsuario))
                {
                    _MyLogControlEventos.InfoFormat("Entró a la aplicación");
                    this.DialogResult = DialogResult.OK;
                    frmPrincipalMenu ofrmPrincipalMenu = new frmPrincipalMenu();
                    ofrmPrincipalMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    txtContrasena.Clear();
                    contador++;
                }

                // Si el contador es 3 cierre la aplicación
                if (contador == 3)
                {
                    // se devuelve Cancel
                    MessageBox.Show("Se equivocó en 3 ocasiones, el Sistema se Cerrará por seguridad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    Application.Exit();
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
    }
}
