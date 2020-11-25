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

namespace UTN.Winforms.Apolo
{
    public partial class frmTipoExamen : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public frmTipoExamen()
        {
            InitializeComponent();
        }

        private void frmTipoExamen_Load(object sender, EventArgs e)
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
            TipoExamen oTipoExamen = null;
            IBLLTipoExamen _IBLLTipoExamen = new BLLTipoExamen();
            try
            {
                if (this.dgvTipoExamen.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Actualizar);

                    oTipoExamen = this.dgvTipoExamen.SelectedRows[0].DataBoundItem as TipoExamen;

                    this.txtCodigo.Text = oTipoExamen.IdTipoExamen;
                    this.txtTipoExamen.Text = oTipoExamen.Descripcion;
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
            IBLLTipoExamen _IBLLTipoExamen = new BLLTipoExamen();

            try
            {
                if (this.dgvTipoExamen.SelectedRows.Count > 0 && this.dgvTipoExamen.SelectedRows != null)
                {
                    this.CambiarEstado(EstadoMantenimiento.Borrar);

                    TipoExamen oTipoExamen = this.dgvTipoExamen.SelectedRows[0].DataBoundItem as TipoExamen;
                    if (MessageBox.Show($"¿Seguro que desea borrar el registro {oTipoExamen.IdTipoExamen}{ oTipoExamen.Descripcion}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _IBLLTipoExamen.DeleteTipoExamen(oTipoExamen.IdTipoExamen);
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
            IBLLTipoExamen _IBLLTipoExamen = new BLLTipoExamen();
            ErrorProvider erp = new ErrorProvider();
            try
            {
                TipoExamen oTipoExamen = new TipoExamen();

                #region validaCampos
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    erp.SetError(txtCodigo, "Código es requerido");
                    txtCodigo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtTipoExamen.Text))
                {
                    erp.SetError(txtTipoExamen, "Tipo Examen es requerido");
                    txtTipoExamen.Focus();
                    return;
                }
                #endregion

                oTipoExamen.IdTipoExamen = txtCodigo.Text;
                oTipoExamen.Descripcion = txtTipoExamen.Text;

                if (_IBLLTipoExamen.SaveTipoExamen(oTipoExamen))
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.CambiarEstado(EstadoMantenimiento.Ninguno);
        }

        private void LimpiarCasillas()
        {
            txtCodigo.Clear();
            txtTipoExamen.Clear();
        }

        private void CargarDatosDataGridView()
        {
            IBLLTipoExamen _IBLLTipoExamen = new BLLTipoExamen();

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Cargar el DataGridView
            this.dgvTipoExamen.DataSource = _IBLLTipoExamen.ReadAllTipoExamen();
        }

        private void CambiarEstado(EstadoMantenimiento estado)
        {
            switch (estado)
            {
                case EstadoMantenimiento.Crear:
                    txtCodigo.Enabled = true;
                    txtTipoExamen.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Actualizar:
                    txtCodigo.Enabled = false;
                    txtTipoExamen.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    txtCodigo.Enabled = false;
                    txtTipoExamen.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    LimpiarCasillas();
                    break;
            }
        }
    }
}
