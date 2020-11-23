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
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.BLL;

namespace UTN.Winforms.Apolo.UI
{
    public partial class frmMantenimientoExamen : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        ErrorProvider erp = new ErrorProvider();

        public frmMantenimientoExamen()
        {
            InitializeComponent();
        }

        private void frmMantenimientoExamen_Load(object sender, EventArgs e)
        {
            try
            {
                CargaDatosComboBox();
                CargarDatosDataGridView();
                this.CambiarEstado(EstadoMantenimiento.Ninguno);
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
            Examen oExamen = null;
            IBLLExamen _IBLLExamen = new BLLExamen();
            try
            {
                if (this.dgvExamen.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Actualizar);

                    oExamen = this.dgvExamen.SelectedRows[0].DataBoundItem as Examen;

                    this.txtCodigo.Text = oExamen.IdExamen;
                    this.txtNombre.Text = oExamen.Descripcion;
                    this.cmbTipoExamen.Text = oExamen.TipoExamen;
                    this.txtCosto.Text = oExamen.Costo.ToString();
                    this.txtValorMinimo.Text = oExamen.ValorMinimo.ToString();
                    this.txtValorMaximo.Text = oExamen.ValorMaximo.ToString();
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
            IBLLExamen _IBLLExamen = new BLLExamen();

            try
            {
                if (this.dgvExamen.SelectedRows.Count > 0 && this.dgvExamen.SelectedRows != null)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    Examen oExamen = this.dgvExamen.SelectedRows[0].DataBoundItem as Examen;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oExamen.IdExamen}{ oExamen.Descripcion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLExamen.DeleteExamen(oExamen.IdExamen);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IBLLExamen _IBLLExamen = new BLLExamen();
            try
            {
                Examen oExamen = new Examen();

                #region validaCampos
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    erp.SetError(txtCodigo, "Código es requerido");
                    txtCodigo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Nombre es requerido");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Debe ingresar un Tipo Examen, para esto dirigirse a mantenimiento->Tipo Exámen");
                    txtNombre.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtCosto.Text))
                {
                    erp.SetError(txtCosto, "Costo es requerido");
                    txtCosto.Focus();
                    return;
                }
                double validaDoubleCosto = 0d;
                if (!double.TryParse(txtCosto.Text, out validaDoubleCosto))
                {
                    erp.SetError(txtCosto, "Costo debe ser numérico");
                    txtCosto.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtValorMinimo.Text))
                {
                    erp.SetError(txtValorMinimo, "Valor mínimo es requerido");
                    txtValorMinimo.Focus();
                    return;
                }
                double validaDoubleValorMinimo = 0d;
                if (!double.TryParse(txtValorMinimo.Text, out validaDoubleValorMinimo))
                {
                    erp.SetError(txtValorMinimo, "Valor mínimo debe ser numérico");
                    txtValorMinimo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtValorMaximo.Text))
                {
                    erp.SetError(txtValorMaximo, "Valor mínimo es requerido");
                    txtValorMaximo.Focus();
                    return;
                }
                double validaDoubleValorMaximo = 0d;
                if (!double.TryParse(txtValorMaximo.Text, out validaDoubleValorMaximo))
                {
                    erp.SetError(txtValorMaximo, "Valor máximo debe ser numérico");
                    txtValorMaximo.Focus();
                    return;
                }
                #endregion

                oExamen.IdExamen = txtCodigo.Text;
                oExamen.Descripcion = txtNombre.Text;
                oExamen.TipoExamen = (cmbTipoExamen.SelectedItem as TipoExamen).IdTipoExamen;
                oExamen.Costo = Convert.ToDouble(txtCosto.Text);
                oExamen.ValorMinimo = Convert.ToDouble(txtValorMinimo.Text);
                oExamen.ValorMaximo = Convert.ToDouble(txtValorMaximo.Text);

                if (_IBLLExamen.SaveExamen(oExamen))
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

        private void CargaDatosComboBox()
        {
            IBLLTipoExamen _IBLLTipoExamen = new BLLTipoExamen();
            List<TipoExamen> lista = null;

            // Cargar el combo
            this.cmbTipoExamen.Items.Clear();
            lista = _IBLLTipoExamen.ReadAllTipoExamen();
            foreach (TipoExamen oTipoExamen in lista)
            {
                this.cmbTipoExamen.Items.Add(oTipoExamen);
            }
            
            // Colocar el primero como default
            this.cmbTipoExamen.SelectedIndex = 0;
        }

        private void limpiarCasillas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            this.cmbTipoExamen.SelectedIndex = 0;
            txtCosto.Clear();
            txtValorMinimo.Clear();
            txtValorMaximo.Clear();
        }

        private void CargarDatosDataGridView()
        {
            IBLLExamen _IBLLExamen = new BLLExamen();

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Cargar el DataGridView
            this.dgvExamen.DataSource = _IBLLExamen.ReadAllExamen();
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            switch (estado)
            {
                case EstadoMantenimiento.Crear:
                    txtCodigo.Enabled = true;
                    txtNombre.Enabled = true;
                    txtCosto.Enabled = true;
                    cmbTipoExamen.Enabled = true;
                    txtValorMinimo.Enabled = true;
                    txtValorMaximo.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    limpiarCasillas();
                    CargaDatosComboBox();
                    break;
                case EstadoMantenimiento.Actualizar:
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = true;
                    cmbTipoExamen.Enabled = true;
                    txtCosto.Enabled = true;
                    txtValorMinimo.Enabled = true;
                    txtValorMaximo.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    cmbTipoExamen.Enabled = false;
                    txtCosto.Enabled = false;
                    txtValorMinimo.Enabled = false;
                    txtValorMaximo.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    CargaDatosComboBox();
                    limpiarCasillas();
                    erp.Clear();
                    break;
            }
        }
    }
}
