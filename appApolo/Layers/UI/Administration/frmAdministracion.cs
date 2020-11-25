using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.BLL;
using UTN.Winforms.Apolo.Layers.UI.Filtros;

namespace UTN.Winforms.Apolo.Layers.UI.Administration
{
    public partial class frmAdministracion : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {
            CargaDatosComboBox();
            CargarDatosDataGridView();
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMenu ofrmPrincipalMenu = new frmPrincipalMenu();
            ofrmPrincipalMenu.Show();
            this.Close();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMantenimiento.Crear);
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

        private void toolStripBtnActualizar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = null;
            IBLLUsuario _IBLLUsuario = new BLLUsuario();
            LimpiarCasillas();
            try
            {
                if (this.dgvUsuarios.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Actualizar);

                    oUsuario = this.dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;

                    //this.pbxFotografia.Image = new Bitmap(new MemoryStream(oUsuario.Fotografia)); //TODO
                    this.pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbxFotografia.Tag = oUsuario.Fotografia;

                    msktxtIdentificación.Text = oUsuario.IdUsuario;
                    txtNombre.Text = oUsuario.Nombre;
                    txtApellidos.Text = oUsuario.Apellidos;
                    cmbTipoPerfil.SelectedIndex = oUsuario.TipoPerfil;
                    txtNombreUsuario.Text = oUsuario.NombreUsuario;
                    txtContrasenna.Text = oUsuario.Contrasenna;
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void toolStripBtnBorrar_Click(object sender, EventArgs e)
        {
            IBLLUsuario _IBLLUsuario = new BLLUsuario();

            try
            {
                if (this.dgvUsuarios.SelectedRows.Count > 0 && this.dgvUsuarios.SelectedRows != null)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Usuario oUsuario = this.dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oUsuario.IdUsuario}{ oUsuario.NombreUsuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLUsuario.DeleteUsuario(oUsuario.IdUsuario);
                        this.CargarDatosDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLUsuario _IBLLUsuario = new BLLUsuario();
            erpError.Clear();
            try
            {
                Usuario oUsuario = new Usuario();

                #region validaCampos
                if (this.pbxFotografia.Tag == null)
                {
                    MessageBox.Show(pbxFotografia, "Fotografía es requerida");
                    pbxFotografia.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(msktxtIdentificación.Text))
                {
                    if (rdBtnDoctorEspecialista.Checked)
                        erpError.SetError(msktxtIdentificación, "Código Especialista es requerido");
                    else
                        erpError.SetError(msktxtIdentificación, "Identificación es requerido");
                    msktxtIdentificación.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erpError.SetError(txtNombre, "Nombre es requerido");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    erpError.SetError(txtApellidos, "Apellidos es requerido");
                    txtApellidos.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombreUsuario.Text))
                {
                    erpError.SetError(txtNombreUsuario, "Nombre Usuario es requerido");
                    txtNombreUsuario.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtContrasenna.Text))
                {
                    erpError.SetError(txtContrasenna, "Contraseña es requerida");
                    txtContrasenna.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtConfirmarContrasenna.Text))
                {
                    erpError.SetError(txtConfirmarContrasenna, "Confirmar contraseña es requerida");
                    txtConfirmarContrasenna.Focus();
                    return;
                }
                if (!txtContrasenna.Text.Equals(txtConfirmarContrasenna.Text))
                {
                    erpError.SetError(txtConfirmarContrasenna, "Contraseña y confirmar contraseña no coinciden");
                    erpError.SetError(txtContrasenna, "Contraseña y confirmar contraseña no coinciden");
                    txtConfirmarContrasenna.Focus();
                    return;
                }
                #endregion

                //oUsuario.Fotografia = (byte[])this.pbxFotografia.Tag;
                oUsuario.Fotografia = null;
                oUsuario.IdUsuario = msktxtIdentificación.Text;
                oUsuario.Nombre = txtNombre.Text;
                oUsuario.Apellidos = txtApellidos.Text;
                oUsuario.NombreUsuario = txtNombreUsuario.Text;
                oUsuario.TipoPerfil = _IBLLUsuario.SeleccionaTipoPerfil((TipoPerfil)cmbTipoPerfil.SelectedItem);
                oUsuario.Contrasenna = txtContrasenna.Text;

                if (_IBLLUsuario.SaveUsuario(oUsuario))
                    this.CargarDatosDataGridView();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void btnBuscarDocEspecialista_Click(object sender, EventArgs e)
        {
            frmFiltroDoctorEspecialista ofrmFiltroDoctorEspecialista = new frmFiltroDoctorEspecialista();
            DoctorEspecialista _DoctorEspecialista = new DoctorEspecialista();

            try
            {
                ofrmFiltroDoctorEspecialista.ShowDialog();

                if (ofrmFiltroDoctorEspecialista.DialogResult == DialogResult.OK)
                {
                    _DoctorEspecialista = ofrmFiltroDoctorEspecialista._DoctorEspecialista;
                    this.msktxtIdentificación.Text = _DoctorEspecialista.CodigoEspecialista;
                    this.txtNombre.Text = _DoctorEspecialista.Nombre;
                    this.txtApellidos.Text = _DoctorEspecialista.Apellidos;
                    this.pbxFotografia.Image = new Bitmap(new MemoryStream(_DoctorEspecialista.Fotografia));
                    this.pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbxFotografia.Tag = _DoctorEspecialista.Fotografia;
                    this.txtNombreUsuario.Focus();

                    txtNombreUsuario.Enabled = true;
                    cmbTipoPerfil.Enabled = true;
                    txtContrasenna.Enabled = true;
                    txtConfirmarContrasenna.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    pbxFotografia.Enabled = false;
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

        private void rdBtnDoctorEspecialista_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarCasillas();

            lblIdentificacion.Text = "Código Especialista";
            lblIdentificacion.Enabled = true;

            msktxtIdentificación.Enabled = false;
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
            this.pbxFotografia.Enabled = true;
            lblIdentificacion.Text = "Identificación";
            lblIdentificacion.Enabled = true;
            btnBuscarDocEspecialista.Enabled = false;
            msktxtIdentificación.Enabled = true;
            txtNombreUsuario.Enabled = true;
            txtApellidos.Enabled = true;
            txtNombre.Enabled = true;
            txtContrasenna.Enabled = true;
            txtConfirmarContrasenna.Enabled = true;
            cmbTipoPerfil.Enabled = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            LimpiarCasillas();
        }

        private void LimpiarCasillas()
        {
            this.pbxFotografia.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_add_photo_alternate_black_48dp;
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            msktxtIdentificación.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtNombreUsuario.Clear();
            txtContrasenna.Clear();
            this.cmbTipoPerfil.SelectedIndex = 0;
            txtConfirmarContrasenna.Clear();
        }

        private void CargaDatosComboBox()
        {
            // Cargar el combo
            cmbTipoPerfil.Items.Clear();
            this.cmbTipoPerfil.Items.Add(TipoPerfil.Administrador);
            this.cmbTipoPerfil.Items.Add(TipoPerfil.Procesos);
            this.cmbTipoPerfil.Items.Add(TipoPerfil.Reportes);

            // Colocar el primero como default
            this.cmbTipoPerfil.SelectedIndex = 0;
        }

        private void CargarDatosDataGridView()
        {
            IBLLUsuario _IBLLUsuario = new BLLUsuario();

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Cargar el DataGridView
            this.dgvUsuarios.DataSource = _IBLLUsuario.ReadAllUsuario();
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            switch (estado)
            {
                case EstadoMantenimiento.Crear:
                    rdBtnDoctorEspecialista.Enabled = true;
                    rdBtnOtro.Enabled = true;
                    LimpiarCasillas();
                    cmbTipoPerfil.SelectedIndex = 0;
                    break;
                case EstadoMantenimiento.Actualizar:
                    cmbTipoPerfil.Enabled = true;
                    msktxtIdentificación.Enabled = false;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtNombreUsuario.Enabled = true;
                    txtContrasenna.Enabled = true;
                    txtConfirmarContrasenna.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.pbxFotografia.Enabled = false;
                    rdBtnDoctorEspecialista.Enabled = false;
                    rdBtnOtro.Enabled = false;
                    btnBuscarDocEspecialista.Enabled = false;
                    cmbTipoPerfil.Enabled = false;
                    msktxtIdentificación.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtNombreUsuario.Enabled = false;
                    txtContrasenna.Enabled = false;
                    txtConfirmarContrasenna.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    CargaDatosComboBox();
                    LimpiarCasillas();
                    erpError.Clear();
                    break;
            }
        }

        private void pbxFotografia_Click(object sender, EventArgs e)
        {
            opnFlDlogFotografia.Title = "Buscar fotografía";
            opnFlDlogFotografia.SupportMultiDottedExtensions = true;
            opnFlDlogFotografia.DefaultExt = "*.jpg";
            opnFlDlogFotografia.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
            opnFlDlogFotografia.FileName = "";

            if (opnFlDlogFotografia.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    pbxFotografia.ImageLocation = opnFlDlogFotografia.FileName;
                    pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opnFlDlogFotografia.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbxFotografia.Tag = (byte[])cadenaBytes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede leer el archivo. Original error: " + ex.Message);
                }
            }
        }
    }
}
