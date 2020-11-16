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

        private void toolStripBtnCrear_Click(object sender, EventArgs e)
        {
            IBLLPaciente _IBLLPaciente = new BLLPaciente();
            ErrorProvider erp = new ErrorProvider();
            try
            {
                Paciente oPaciente = new Paciente();

                #region validaCampos
                //if (string.IsNullOrEmpty((string)pbxFotografia.Tag))
                //{
                //    erp.SetError(pbxFotografia, "Fotografía es requerida");
                //    pbxFotografia.Focus();
                //    return;
                //}
                if (string.IsNullOrEmpty(mkdtxtIdentificación.Text))
                {
                    erp.SetError(mkdtxtIdentificación, "Identificación es requerida");
                    mkdtxtIdentificación.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Nombre es requerido");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    erp.SetError(txtApellidos, "Apellido es requerido");
                    txtApellidos.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtAltura.Text))
                {
                    erp.SetError(txtAltura, "Altura es requerida");
                    txtAltura.Focus();
                    return;
                }
                double validaDouble = 0d;
                if (!double.TryParse(txtAltura.Text, out validaDouble))
                {
                    erp.SetError(txtApellidos, "Altura debe ser numérico");
                    txtAltura.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPeso.Text))
                {
                    erp.SetError(txtPeso, "Peso es requerido");
                    txtPeso.Focus();
                    return;
                }
                double validaDoublePeso = 0d;
                if (!double.TryParse(txtPeso.Text, out validaDoublePeso))
                {
                    erp.SetError(txtPeso, "Peso debe ser numérico");
                    txtPeso.Focus();
                    return;
                }                
                if (rdBtnFemenino.Checked == false && rdBtnMasculino.Checked
                    == false && rdBtnOtro.Checked == false)
                {
                    erp.SetError(txtPeso, "Debe marcar un género");
                    grpBxGenero.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtCorreoElectronico.Text))
                {
                    erp.SetError(txtCorreoElectronico, "Correo es requerido");
                    txtCorreoElectronico.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(mkdtxtTelefono.Text))
                {
                    erp.SetError(mkdtxtTelefono, "Teléfono es requerido");
                    mkdtxtTelefono.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    erp.SetError(txtDireccion, "Dirección es requerida");
                    txtDireccion.Focus();
                    return;
                }
                #endregion

                oPaciente.Fotografia = (byte[]) pbxFotografia.Tag;
                oPaciente.IdPaciente = mkdtxtIdentificación.Text;
                oPaciente.Nombre = txtNombre.Text;
                oPaciente.Apellidos = txtApellidos.Text;
                oPaciente.EjercicioFisico = chBxEjercicioFisico.Checked ? "Sí" : "No";
                oPaciente.AlcoholTabaco = chBxAlcoholTabaco.Checked ? "Sí" : "No";
                oPaciente.Medicamentos = chBoxMedicamentos.Checked ? "Sí" : "No";
                oPaciente.Altura = Convert.ToDouble(txtAltura.Text);
                oPaciente.Peso = Convert.ToDouble(txtPeso.Text);
                oPaciente.FechaNacimiento = dtpkrFechaNacimiento.Value;
                if (rdBtnFemenino.Checked)
                    oPaciente.Genero = "f";
                else if (rdBtnMasculino.Checked)
                    oPaciente.Genero = "m";
                else
                    oPaciente.Genero = "o";
                oPaciente.Email = txtCorreoElectronico.Text;
                oPaciente.Telefono = mkdtxtTelefono.Text;
                oPaciente.Direccion = txtDireccion.Text;

                if (_IBLLPaciente.CreatePaciente(oPaciente))
                    this.CargarDatos();

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

        private void toolStripBtnLeer_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnActualizar_Click(object sender, EventArgs e)
        {

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
                        this.CargarDatos();
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

        private void toolStripBtnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDatos()
        {
            IBLLPaciente _IBLLPaciente = new BLLPaciente();
            //List<Paciente> lista = null;

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Configuracion del DataGridView para que se vea bien la imagen.
            dgvPacientes.AutoGenerateColumns = false;
            dgvPacientes.RowTemplate.Height = 100;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Cargar el DataGridView
            this.dgvPacientes.DataSource = _IBLLPaciente.ReadAllPaciente();
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {          
            switch (estado)
            {
                case EstadoMantenimiento.Crear:
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
                    break;
                case EstadoMantenimiento.Leer:
                    break;
                case EstadoMantenimiento.Actualizar:
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    mkdtxtIdentificación.Focus();
                    break;
            }
        }

        private void pbxFotografia_Click(object sender, EventArgs e)
        {
            opnFlDlogFotografia.Title = "Buscar fotografía";
            opnFlDlogFotografia.SupportMultiDottedExtensions = true;
            opnFlDlogFotografia.DefaultExt = "*.jpg";
            opnFlDlogFotografia.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";

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
    }
}

