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

namespace UTN.Winforms.Apolo.UI
{
    public partial class frmMantenimientoDoctorOEspecialista : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoDoctorOEspecialista()
        {
            InitializeComponent();
        }

        private void frmMantenimientoDoctorOEspecialista_Load(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMantenimiento.Ninguno);
                CargarDatosDataGridView();
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

        private void toolStripBtnCrear_Click(object sender, EventArgs e)
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
            DoctorEspecialista oDoctorEspecialista = null;
            IBLLDoctorEspecialista _IBLLDoctorEspecialista = new BLLDoctorEspecialista();
            LimpiarCasillas();
            try
            {
                if (this.dgvDoctorEspecialista.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Actualizar);

                    oDoctorEspecialista = this.dgvDoctorEspecialista.SelectedRows[0].DataBoundItem as DoctorEspecialista;

                    this.pbxFotografia.Image = new Bitmap(new MemoryStream(oDoctorEspecialista.Fotografia));
                    this.pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbxFotografia.Tag = oDoctorEspecialista.Fotografia;

                    mkdtxtIdentificación.Text = oDoctorEspecialista.CodigoEspecialista;
                    txtNombre.Text = oDoctorEspecialista.Nombre;
                    txtApellidos.Text = oDoctorEspecialista.Apellidos;
                    if (oDoctorEspecialista.EjercicioFisico == "Sí")
                        chBxEjercicioFisico.Checked = true;
                    else
                        chBxEjercicioFisico.Checked = false;

                    if (oDoctorEspecialista.AlcoholTabaco == "Sí")
                        chBxAlcoholTabaco.Checked = true;
                    else
                        chBxAlcoholTabaco.Checked = false;

                    if (oDoctorEspecialista.Medicamentos == "Sí")
                        chBoxMedicamentos.Checked = true;
                    else
                        chBoxMedicamentos.Checked = false;

                    txtAltura.Text = oDoctorEspecialista.Altura.ToString();
                    txtPeso.Text = oDoctorEspecialista.Peso.ToString();
                    dtpkrFechaNacimiento.Value = oDoctorEspecialista.FechaNacimiento;

                    if (oDoctorEspecialista.Genero == "f")
                        rdBtnFemenino.Checked = true;
                    else if (oDoctorEspecialista.Genero == "m")
                        rdBtnMasculino.Checked = true;
                    else
                        rdBtnOtro.Checked = true;

                    txtCorreoElectronico.Text = oDoctorEspecialista.Email;
                    mkdtxtTelefono.Text = oDoctorEspecialista.Telefono;
                    txtDireccion.Text = oDoctorEspecialista.Direccion;
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
            IBLLDoctorEspecialista _IBLLDoctorEspecialista = new BLLDoctorEspecialista();

            try
            {
                if (this.dgvDoctorEspecialista.SelectedRows.Count > 0)
                {
                    //this.CambiarEstado(EstadoMantenimiento.Borrar)
                    DoctorEspecialista oDoctorEspecialista = this.dgvDoctorEspecialista.SelectedRows[0].DataBoundItem as DoctorEspecialista;

                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oDoctorEspecialista.CodigoEspecialista} {oDoctorEspecialista.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLDoctorEspecialista.DeleteDoctorEspecialista(oDoctorEspecialista.CodigoEspecialista);
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

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            switch (estado)
            {
                case EstadoMantenimiento.Crear:
                    LimpiarCasillas();
                    this.pbxFotografia.Enabled = true;
                    mkdtxtIdentificación.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    chBoxMedicamentos.Enabled = true;
                    chBxEjercicioFisico.Enabled = true;
                    chBxAlcoholTabaco.Enabled = true;
                    txtAltura.Enabled = true;
                    txtPeso.Enabled = true;
                    dtpkrFechaNacimiento.Enabled = true;
                    rdBtnFemenino.Enabled = true;
                    rdBtnMasculino.Enabled = true;
                    rdBtnOtro.Enabled = true;
                    txtCorreoElectronico.Enabled = true;
                    mkdtxtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Actualizar:
                    this.pbxFotografia.Enabled = true;
                    mkdtxtIdentificación.Enabled = false;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    chBoxMedicamentos.Enabled = true;
                    chBxEjercicioFisico.Enabled = true;
                    chBxAlcoholTabaco.Enabled = true;
                    txtAltura.Enabled = true;
                    txtPeso.Enabled = true;
                    dtpkrFechaNacimiento.Enabled = true;
                    rdBtnFemenino.Enabled = true;
                    rdBtnMasculino.Enabled = true;
                    rdBtnOtro.Enabled = true;
                    txtCorreoElectronico.Enabled = true;
                    mkdtxtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    this.pbxFotografia.Enabled = false;
                    mkdtxtIdentificación.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    chBoxMedicamentos.Enabled = false;
                    chBxEjercicioFisico.Enabled = false;
                    chBxAlcoholTabaco.Enabled = false;
                    txtAltura.Enabled = false;
                    txtPeso.Enabled = false;
                    dtpkrFechaNacimiento.Enabled = false;
                    rdBtnFemenino.Enabled = false;
                    rdBtnMasculino.Enabled = false;
                    rdBtnOtro.Enabled = false;
                    txtCorreoElectronico.Enabled = false;
                    mkdtxtTelefono.Enabled = false;
                    txtDireccion.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    LimpiarCasillas();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLDoctorEspecialista _IBLLDoctorEspecialista = new BLLDoctorEspecialista();

            try
            {
                DoctorEspecialista oDoctorEspecialista = new DoctorEspecialista();

                #region validaCampos
                if (this.pbxFotografia.Tag == null)
                {
                    MessageBox.Show(pbxFotografia, "Fotografía es requerida");
                    pbxFotografia.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(mkdtxtIdentificación.Text))
                {
                    MessageBox.Show(mkdtxtIdentificación, "Identificación es requerida");
                    mkdtxtIdentificación.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show(txtNombre, "Nombre es requerido");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    MessageBox.Show(txtApellidos, "Apellido es requerido");
                    txtApellidos.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAltura.Text))
                {
                    MessageBox.Show(txtAltura, "Altura es requerida");
                    txtAltura.Focus();
                    return;
                }
                double validaDouble = 0d;
                if (!double.TryParse(txtAltura.Text, out validaDouble))
                {
                    MessageBox.Show(txtApellidos, "Altura debe ser numérico");
                    txtAltura.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPeso.Text))
                {
                    MessageBox.Show(txtPeso, "Peso es requerido");
                    txtPeso.Focus();
                    return;
                }
                double validaDoublePeso = 0d;
                if (!double.TryParse(txtPeso.Text, out validaDoublePeso))
                {
                    MessageBox.Show(txtPeso, "Peso debe ser numérico");
                    txtPeso.Focus();
                    return;
                }
                if (rdBtnFemenino.Checked == false && rdBtnMasculino.Checked
                    == false && rdBtnOtro.Checked == false)
                {
                    MessageBox.Show(txtPeso, "Debe marcar un género");
                    grpBxGenero.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtCorreoElectronico.Text))
                {
                    MessageBox.Show(txtCorreoElectronico, "Correo es requerido");
                    txtCorreoElectronico.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(mkdtxtTelefono.Text))
                {
                    MessageBox.Show(mkdtxtTelefono, "Teléfono es requerido");
                    mkdtxtTelefono.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show(txtDireccion, "Dirección es requerida");
                    txtDireccion.Focus();
                    return;
                }
                #endregion

                oDoctorEspecialista.Fotografia = (byte[])this.pbxFotografia.Tag;
                oDoctorEspecialista.CodigoEspecialista = mkdtxtIdentificación.Text;
                oDoctorEspecialista.Nombre = txtNombre.Text;
                oDoctorEspecialista.Apellidos = txtApellidos.Text;
                oDoctorEspecialista.EjercicioFisico = chBxEjercicioFisico.Checked ? "Sí" : "No";
                oDoctorEspecialista.AlcoholTabaco = chBxAlcoholTabaco.Checked ? "Sí" : "No";
                oDoctorEspecialista.Medicamentos = chBoxMedicamentos.Checked ? "Sí" : "No";
                oDoctorEspecialista.Altura = Convert.ToDouble(txtAltura.Text);
                oDoctorEspecialista.Peso = Convert.ToDouble(txtPeso.Text);
                oDoctorEspecialista.FechaNacimiento = dtpkrFechaNacimiento.Value;
                oDoctorEspecialista.Genero = _IBLLDoctorEspecialista.SeleccionaSexo(rdBtnFemenino.Checked,
                    rdBtnMasculino.Checked, rdBtnOtro.Checked);
                oDoctorEspecialista.Email = txtCorreoElectronico.Text;
                oDoctorEspecialista.Telefono = mkdtxtTelefono.Text;
                oDoctorEspecialista.Direccion = txtDireccion.Text;

                if (_IBLLDoctorEspecialista.SaveDoctorEspecialista(oDoctorEspecialista))
                    this.CargarDatosDataGridView();

                CambiarEstado(EstadoMantenimiento.Crear);
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
            CambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void mkdtxtIdentificación_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mkdtxtIdentificación.Select(0, 0);
        }

        private void mkdtxtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mkdtxtTelefono.Select(0, 0);
        }

        private void CargarDatosDataGridView()
        {
            IBLLDoctorEspecialista _IBLLDoctorEspecialista = new BLLDoctorEspecialista();

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvDoctorEspecialista.RowTemplate.Height = 100;
            dgvDoctorEspecialista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Cargar el DataGridView
            this.dgvDoctorEspecialista.DataSource = _IBLLDoctorEspecialista.ReadAllDoctorEspecialista();
        }

        private void LimpiarCasillas()
        {
            this.pbxFotografia.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_add_photo_alternate_black_48dp;
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            mkdtxtIdentificación.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            chBoxMedicamentos.Checked = false;
            chBxEjercicioFisico.Checked = false;
            chBxAlcoholTabaco.Checked = false;
            txtAltura.Clear();
            txtPeso.Clear();
            dtpkrFechaNacimiento.Value = DateTime.Now;
            rdBtnFemenino.Checked = false;
            rdBtnMasculino.Checked = false;
            rdBtnOtro.Checked = false;
            txtCorreoElectronico.Clear();
            mkdtxtTelefono.Clear();
            txtDireccion.Clear();
        }
    }
}
