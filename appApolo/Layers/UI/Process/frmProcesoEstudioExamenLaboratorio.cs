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
using UTN.Winforms.Apolo.Entities.DTO;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.BLL;
using UTN.Winforms.Apolo.Properties;

namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    public partial class frmProcesoEstudioExamenLaboratorio : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public frmProcesoEstudioExamenLaboratorio()
        {
            InitializeComponent();
        }

        private void frmProcesoEstudioExamenLaboratorio_Load(object sender, EventArgs e)
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

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            IBLLRegistroExamen _IBLLRegistroExamen = new BLLRegistroExamen();
            IBLLFactura _IBLLFactura = new BLLFactura();
            FacturaExamenDTO oFacturaExamenDTO = null;
            FacturaDetalle oFacturaDetalle = new FacturaDetalle();
            erp.Clear();

            try
            {
                RegistroExamen oRegistroExamen = new RegistroExamen();

                if (string.IsNullOrEmpty(txtIdentificacionPaciente.Text))
                {
                    erp.SetError(dgvDetalle, "Debe seleccionar un exámen pendiente y completar sus datos");
                    dgvDetalle.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtValorResultExam.Text))
                {
                    erp.SetError(txtValorResultExam, "Valor Resultado Exámen es requerido");
                    txtValorResultExam.Focus();
                    return;
                }
                double validaDoubleValorResultExamen = 0d;
                if (!double.TryParse(txtValorResultExam.Text, out validaDoubleValorResultExamen))
                {
                    erp.SetError(txtValorResultExam, "Valor Resultado Exámen debe ser numérico");
                    txtValorResultExam.Focus();
                    return;
                }

                this.CambiarEstado(EstadoMantenimiento.Crear);

                oFacturaExamenDTO = this.dgvDetalle.SelectedRows[0].DataBoundItem as FacturaExamenDTO;

                //Crea RegistroExamen
                //SecuenciaRegistroExamen se carga automatico con Identity

                //id del Usuario se carga a variable global al iniciar sesión
                oRegistroExamen.IdDoctorEspecialista = Convert.ToInt32(Settings.Default.IdUsuario);
                oRegistroExamen.IdFactura = oFacturaExamenDTO.IdFactura;
                oRegistroExamen.SecuenciaDetalleFact = oFacturaExamenDTO.Secuencia;
                oRegistroExamen.IdExamen = oFacturaExamenDTO.IdExamen;
                oRegistroExamen.Valor = Convert.ToDouble(txtValorResultExam.Text);
                oRegistroExamen.FechaMuestra = dtpFechaMuestra.Value;

                //Crea FacturaDetalle para cambiar EstadoExamen
                oFacturaDetalle.IdFactura = oFacturaExamenDTO.IdFactura;
                oFacturaDetalle.Secuencia = oFacturaExamenDTO.Secuencia;
                oFacturaDetalle.EstadoExamen = EstadoExamen.Disponible.ToString();

                if (_IBLLRegistroExamen.SaveRegistroExamen(oRegistroExamen)
                    && 
                    _IBLLFactura.UpdateEstadoDetalleFactura(oFacturaDetalle))
                    LimpiarCasillas();
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

        private void toolStripBtnLlenar_Click(object sender, EventArgs e)
        {
            FacturaExamenDTO oFacturaExamenDTO = null;

            try
            {
                if (this.dgvDetalle.SelectedRows.Count > 0)
                {
                    this.CambiarEstado(EstadoMantenimiento.Actualizar);

                    oFacturaExamenDTO = this.dgvDetalle.SelectedRows[0].DataBoundItem as FacturaExamenDTO;

                    this.txtIdentificacionPaciente.Text = oFacturaExamenDTO.IdPaciente.ToString();
                    this.txtNumeroFactura.Text = oFacturaExamenDTO.IdFactura.ToString();
                    this.txtNumeroExamen.Text = oFacturaExamenDTO.IdExamen.ToString();
                    this.txtDescripcionExamen.Text = oFacturaExamenDTO.DescripcionExamen.ToString();
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
                    txtValorResultExam.Enabled = false;
                    dtpFechaMuestra.Enabled = false;
                    break;
                case EstadoMantenimiento.Actualizar:
                    txtValorResultExam.Enabled = true;
                    dtpFechaMuestra.Enabled = true;
                    break;
                case EstadoMantenimiento.Borrar:
                    break;
                case EstadoMantenimiento.Ninguno:
                    break;
            }
        }

        private void LimpiarCasillas()
        {
            
            txtFiltroIdPaciente.Clear();
            txtIdentificacionPaciente.Clear();
            txtNumeroExamen.Clear();
            txtNumeroFactura.Clear();
            txtValorResultExam.Clear();
            txtDescripcionExamen.Clear();
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            IBLLFactura _IBLLFactura = new BLLFactura();

            //Cambiar el estado
            CambiarEstado(EstadoMantenimiento.Ninguno);

            // Cargar el DataGridView
            this.dgvDetalle.DataSource = _IBLLFactura.GetAllFacturaPendiente();
        }

        private void btnFiltroIdPaciente_Click(object sender, EventArgs e)
        {
            IBLLFactura _IBLLFactura = new BLLFactura();
            string filtro = string.Empty;
            try
            {
                filtro = this.txtFiltroIdPaciente.Text;
                filtro = filtro.Replace(' ', '%');
                filtro = "%" + filtro + "%";
                this.dgvDetalle.AutoGenerateColumns = false;

                this.dgvDetalle.DataSource = _IBLLFactura.ReadAllFacturaPendienteByFilter(filtro);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
    }
}
