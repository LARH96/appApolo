using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

namespace UTN.Winforms.Apolo.Layers.UI.Maintenance
{
    public partial class frmMantenimientoPaciente : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public frmMantenimientoPaciente()
        {
            InitializeComponent();
        }

        private void frmMantenimientoPaciente_Load(object sender, EventArgs e)
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
            Paciente oPaciente = null;
            IBLLPaciente _IBLLPaciente = new BLLPaciente();
            LimpiarCasillas();
            try
            {
                if (this.dgvPacientes.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Actualizar);

                    oPaciente = this.dgvPacientes.SelectedRows[0].DataBoundItem as Paciente;

                    this.pbxFotografia.Image = new Bitmap(new MemoryStream(oPaciente.Fotografia));
                    this.pbxFotografia.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbxFotografia.Tag = oPaciente.Fotografia;

                    mkdtxtIdentificación.Text = oPaciente.IdPaciente;
                    txtNombre.Text = oPaciente.Nombre;
                    txtApellidos.Text = oPaciente.Apellidos;
                    if (oPaciente.EjercicioFisico == "Sí")
                        chBxEjercicioFisico.Checked = true;
                    else
                        chBxEjercicioFisico.Checked = false;

                    if (oPaciente.AlcoholTabaco == "Sí")
                        chBxAlcoholTabaco.Checked = true;
                    else
                        chBxAlcoholTabaco.Checked = false;

                    if (oPaciente.Medicamentos == "Sí")
                        chBoxMedicamentos.Checked = true;
                    else
                        chBoxMedicamentos.Checked = false;

                    txtAltura.Text = oPaciente.Altura.ToString();
                    txtPeso.Text = oPaciente.Peso.ToString();
                    dtpkrFechaNacimiento.Value = oPaciente.FechaNacimiento;

                    if (oPaciente.Genero == "f")
                        rdBtnFemenino.Checked = true;
                    else if(oPaciente.Genero == "m")
                         rdBtnMasculino.Checked = true;
                    else
                        rdBtnOtro.Checked = true;

                    txtCorreoElectronico.Text = oPaciente.Email;
                    mkdtxtTelefono.Text = oPaciente.Telefono;
                    txtDireccion.Text = oPaciente.Direccion;
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
            IBLLPaciente _BLLPaciente = new BLLPaciente();

            try
            {
                if (this.dgvPacientes.SelectedRows.Count > 0)
                {
                    //this.CambiarEstado(EstadoMantenimiento.Borrar)
                    Paciente oPaciente = this.dgvPacientes.SelectedRows[0].DataBoundItem as Paciente;

                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oPaciente.IdPaciente} {oPaciente.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLPaciente.DeletePaciente(oPaciente.IdPaciente);
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
            IBLLPaciente _IBLLPaciente = new BLLPaciente();
            try
            {
                Paciente oPaciente = new Paciente();

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

                oPaciente.Fotografia = (byte[])this.pbxFotografia.Tag;
                oPaciente.IdPaciente = mkdtxtIdentificación.Text;
                oPaciente.Nombre = txtNombre.Text;
                oPaciente.Apellidos = txtApellidos.Text;
                oPaciente.EjercicioFisico = chBxEjercicioFisico.Checked ? "Sí" : "No";
                oPaciente.AlcoholTabaco = chBxAlcoholTabaco.Checked ? "Sí" : "No";
                oPaciente.Medicamentos = chBoxMedicamentos.Checked ? "Sí" : "No";
                oPaciente.Altura = Convert.ToDouble(txtAltura.Text);
                oPaciente.Peso = Convert.ToDouble(txtPeso.Text);
                oPaciente.FechaNacimiento = dtpkrFechaNacimiento.Value;
                oPaciente.Genero = _IBLLPaciente.SeleccionaSexo(rdBtnFemenino.Checked, rdBtnMasculino.Checked, rdBtnOtro.Checked);
                oPaciente.Email = txtCorreoElectronico.Text;
                oPaciente.Telefono = mkdtxtTelefono.Text;
                oPaciente.Direccion = txtDireccion.Text;

                if (_IBLLPaciente.SavePaciente(oPaciente))
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

        private void toolStripBtnSalir_Click_1(object sender, EventArgs e)
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

        private void mkdtxtIdentificación_Click(object sender, EventArgs e)
        {
            mkdtxtIdentificación.Select(0, 0);
        }

        private void mkdtxtTelefono_Click(object sender, EventArgs e)
        {
            mkdtxtTelefono.Select(0, 0);
        }

        private void CargarDatosDataGridView()
        {
            IBLLPaciente _IBLLPaciente = new BLLPaciente();

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvPacientes.RowTemplate.Height = 100;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Cargar el DataGridView
            this.dgvPacientes.DataSource = _IBLLPaciente.ReadAllPaciente();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiarEstado(EstadoMantenimiento.Ninguno);
        }
    }
}

