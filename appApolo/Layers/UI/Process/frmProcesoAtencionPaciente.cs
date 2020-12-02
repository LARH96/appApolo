using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Entities;
using UTN.Winforms.Apolo.Interfaces;
using UTN.Winforms.Apolo.Layers.BLL;
using UTN.Winforms.Apolo.Layers.UI.Filter;
using UTN.Winforms.Apolo.Layers.UI.Filtros;
using UTN.Winforms.Apolo.Layers.UI.Reports;

namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    public partial class frmProcesoAtencionPaciente : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private Paciente oPaciente = null;
        private FacturaEncabezado _FacturaEncabezado = null;

        public frmProcesoAtencionPaciente()
        {
            InitializeComponent();
        }

        private void frmProcesoAtencionPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                rdbEfectivo.Checked = true;
                CargaDatosComboBox();
                ConsigueNumeroFactura();
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

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void toolStripBtnFacturar_Click(object sender, EventArgs e)
        {
            IBLLFactura _BLLFactura = new BLLFactura();
            string rutaImagen = @"c:\temp\qr.png";
            double numeroFactura = 0d;

            try
            {
                if (oPaciente == null)
                {
                    MessageBox.Show("Debe Seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIdentificacionPaciente.Focus();
                    return;
                }

                if (_FacturaEncabezado == null)
                {
                    MessageBox.Show("No hay datos por facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_FacturaEncabezado._ListaFacturaDetalle.Count == 0)
                {
                    MessageBox.Show("No hay items en la factura ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _FacturaEncabezado = _BLLFactura.SaveFactura(_FacturaEncabezado);

                numeroFactura = _FacturaEncabezado.IdFactura;

                if (_FacturaEncabezado == null)
                    MessageBox.Show("Error al crear factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    toolStripBtnNuevo_Click(null, null);


                // Si existe borrelo
                if (File.Exists(rutaImagen))
                    File.Delete(rutaImagen);

                // Crear imagen quickresponse
                Image quickResponseImage = QuickResponse.QuickResponseGenerador(numeroFactura.ToString(), 53);

                // Salvarla en c:\temp para luego ser leida
                quickResponseImage.Save(rutaImagen, ImageFormat.Png);

                frmReporteFactura ofrmReporteFactura = new frmReporteFactura((decimal)numeroFactura);
                ofrmReporteFactura.ShowDialog();
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

        private void LimpiarCasillas()
        {
            IBLLFactura _BLLFactura = new BLLFactura();

            _FacturaEncabezado = null;

            txtDescripcion.Clear();
            txtIdentificacionPaciente.Clear();
            txtCodigoExamen.Clear();
            txtNoFactura.Clear();
            txtNombrePaciente.Clear();
            txtReferenciaMedica.Clear();

            cmbTipoTarjeta.SelectedIndex = 0;

            rdbEfectivo.Checked = true;
            rdbTarjeta.Checked = false;
            rdbPresencial.Checked = false;
            rdbCorreoElectronico.Checked = false;

            mskNoTarjeta.Clear();

            this.dgvDetalle.Rows.Clear();
            //dgvDetalle.DataSource = null;

            txtPrecio.Enabled = false;

            // Mostar Numero de factura
            this.txtNoFactura.Text = _BLLFactura.GetNextNumeroFactura().ToString();

            btnBuscarPaciente.Enabled = true;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmFiltroPaciente ofrmFiltroPaciente = new frmFiltroPaciente();
            this.oPaciente = new Paciente();

            try
            {
                erpError.Clear();
                ofrmFiltroPaciente.ShowDialog();

                if (ofrmFiltroPaciente.DialogResult == DialogResult.OK)
                {
                    oPaciente = ofrmFiltroPaciente._Paciente;
                    this.txtIdentificacionPaciente.Text = oPaciente.IdPaciente;
                    this.txtNombrePaciente.Text = oPaciente.Nombre;
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

        private void btnBuscarExamen_Click(object sender, EventArgs e)
        {
            frmFiltroExamen ofrmFiltroExamen = new frmFiltroExamen();
            Examen oExamen = new Examen();

            try
            {
                ofrmFiltroExamen.ShowDialog();

                if (ofrmFiltroExamen.DialogResult == DialogResult.OK)
                {
                    oExamen = ofrmFiltroExamen._Examen;
                    this.txtCodigoExamen.Text = oExamen.IdExamen;
                    this.txtDescripcion.Text = oExamen.Descripcion;
                    this.txtPrecio.Text = oExamen.Costo.ToString();
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

        private void CargaDatosComboBox()
        {
            IBLLTarjeta _IBLLTarjeta = new BLLTarjeta();
            List<Tarjeta> lista = null;

            // Cargar el combo
            this.cmbTipoTarjeta.Items.Clear();
            lista = _IBLLTarjeta.GetAllTarjeta();
            foreach (Tarjeta oTarjeta in lista)
            {
                this.cmbTipoTarjeta.Items.Add(oTarjeta);
            }

            // Colocar el primero como default
            this.cmbTipoTarjeta.SelectedIndex = 0;
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoTarjeta.Enabled = false;
            mskNoTarjeta.Enabled = false;
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoTarjeta.Enabled = true;
            mskNoTarjeta.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IBLLImpuesto _BLLImpuesto = new BLLImpuesto();
            IBLLExamen _BLLExamen = new BLLExamen();
            FacturaDetalle oFacturaDetalle = new FacturaDetalle();

            try
            {
                erpError.Clear();

                #region ValidaCampos
                if (string.IsNullOrEmpty(this.txtIdentificacionPaciente.Text))
                {
                    btnBuscarPaciente.Focus();
                    erpError.SetError(mskNoTarjeta, "Debe seleccionar un paciente");
                    return;
                }

                if (this.rdbTarjeta.Checked && string.IsNullOrEmpty(this.mskNoTarjeta.Text))
                {
                    mskNoTarjeta.Focus();
                    erpError.SetError(mskNoTarjeta, "El pago por tarjeta debe indicar su número");
                    return;
                }

                if (string.IsNullOrEmpty(this.txtReferenciaMedica.Text))
                {
                    txtReferenciaMedica.Focus();
                    erpError.SetError(txtReferenciaMedica, "Debe ingresar una referencia médica");
                    return;
                }

                if (string.IsNullOrEmpty(this.txtCodigoExamen.Text))
                {
                    txtCodigoExamen.Focus();
                    erpError.SetError(txtCodigoExamen, "Debe elegir un exámen");
                    return;
                }
                #endregion

                //Crea Encabezado de la Factura
                if (_FacturaEncabezado == null)
                {
                    _FacturaEncabezado = new FacturaEncabezado()
                    {
                        IdFactura = int.Parse(this.txtNoFactura.Text),
                        FechaFacturacion = DateTime.Now,
                        _Paciente = oPaciente,
                        XML = "",
                        TipoPago = this.rdbEfectivo.Checked ? 1 : 2,
                        ReferenciaMedica = txtReferenciaMedica.Text,
                        TipoEntregaExamen = this.rdbPresencial.Checked ? 1 : 2
                    };
                }

                //Crea Detalle de la Factura
                oFacturaDetalle.IdFactura = _FacturaEncabezado.IdFactura;
                oFacturaDetalle.Secuencia = _FacturaEncabezado._ListaFacturaDetalle.Count == 0 ?
                                                 1 : _FacturaEncabezado._ListaFacturaDetalle.Max(p => p.Secuencia) + 1;
                oFacturaDetalle.Examen = txtCodigoExamen.Text;
                oFacturaDetalle.Costo = Convert.ToDouble(txtPrecio.Text);
                oFacturaDetalle.Impuesto = ((double)_BLLImpuesto.GetImpuesto().Porcentaje / 100D) * oFacturaDetalle.Costo;

                // Agregar
                _FacturaEncabezado.AddDetalle(oFacturaDetalle);


                string[] lineaFactura = {oFacturaDetalle.Secuencia.ToString(),
                                         oFacturaDetalle.Examen.ToString(),
                                         txtDescripcion.Text,
                                         oFacturaDetalle.Costo.ToString(),
                                         oFacturaDetalle.Impuesto.ToString(),
                                         (oFacturaDetalle.Costo + oFacturaDetalle.Impuesto).ToString()
                                         };

                this.dgvDetalle.Rows.Add(lineaFactura);

                this.txtSubTotal.Text = _FacturaEncabezado.GetSubTotal().ToString();
                this.txtImpuesto.Text = _FacturaEncabezado.GetImpuesto().ToString();
                this.txtTotal.Text = (_FacturaEncabezado.GetSubTotal() + _FacturaEncabezado.GetImpuesto()).ToString();

                this.txtCodigoExamen.Clear();
                this.txtDescripcion.Clear();
                this.txtPrecio.Clear();
                btnBuscarPaciente.Enabled = false;
                btnAgregar.Focus();
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

        private void ConsigueNumeroFactura()
        {
            IBLLFactura _BLLFactura = new BLLFactura();
            this.txtNoFactura.Text = _BLLFactura.GetCurrentNumeroFactura().ToString();
        }
    }
}
