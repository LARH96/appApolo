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
using UTN.Winforms.Apolo.Layers.UI.Reports;

namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    public partial class frmProcesoEntregaExamenLaboratorio : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public frmProcesoEntregaExamenLaboratorio()
        {
            InitializeComponent();
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
                this.dgvDetallePresencial.AutoGenerateColumns = false;

                this.dgvDetallePresencial.DataSource = _IBLLFactura.ReadAllFacturaByFilter(filtro, EstadoExamen.Disponible);
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

        private void frmProcesoEntregaExamenLaboratorio_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosDataGridViewPresencial();
                CargarDatosDataGridViewCorreoElectronico();
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

        private void CargarDatosDataGridViewPresencial()
        {
            IBLLFactura _IBLLFactura = new BLLFactura();

            // Cargar el DataGridView
            this.dgvDetallePresencial.DataSource = _IBLLFactura.GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen.Disponible, 
                                                                                    (int)TipoEntregaExamen.Presencial);
        }

        private void CargarDatosDataGridViewCorreoElectronico()
        {
            IBLLFactura _IBLLFactura = new BLLFactura();

            // Cargar el DataGridView
            this.dgvDetalleEmail.DataSource = _IBLLFactura.GetAllFacturaByFilterTipoEntregaExamen(EstadoExamen.Disponible,
                                                                                    (int)TipoEntregaExamen.CorreoElectronico);
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            IBLLFactura _BLLFactura = new BLLFactura();
            FacturaExamenDTO oFacturaExamenDTO = new FacturaExamenDTO();
            FacturaDetalle oDetalleFactura = new FacturaDetalle();
            FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();
            Examen oExamen = new Examen();
            BLLExamen oBLLExamen = new BLLExamen();

            try
            {
                if (this.dgvDetallePresencial.SelectedRows.Count > 0)
                {
                    oFacturaExamenDTO = this.dgvDetallePresencial.SelectedRows[0].DataBoundItem as FacturaExamenDTO;
                    //id, sec, estado
                    oDetalleFactura.IdFactura = oFacturaExamenDTO.IdFactura;
                    oDetalleFactura.Secuencia = oFacturaExamenDTO.Secuencia;
                    oDetalleFactura.EstadoExamen = EstadoExamen.Entregado.ToString();
                    oExamen.IdExamen = oFacturaExamenDTO.IdExamen;

                    _BLLFactura.UpdateEstadoDetalleFactura(oDetalleFactura); //devuelve bool

                    //Parametros de Atributos son filtros del DataSet
                    frmReporteEntregaExamenLaboratorio ofrmReporteEntregaExamenLaboratorio =
                        new frmReporteEntregaExamenLaboratorio(oFacturaExamenDTO.IdPaciente,
                                                               oFacturaExamenDTO.IdFactura,
                                                               oFacturaExamenDTO.Secuencia,
                                                               oBLLExamen.CalculaResultadoExamen(oExamen, oDetalleFactura));
                    ofrmReporteEntregaExamenLaboratorio.ShowDialog();
                    CargarDatosDataGridViewPresencial();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            IBLLFactura _BLLFactura = new BLLFactura();
            IBLLPaciente _BLLPaciente = new BLLPaciente();
            FacturaExamenDTO oFacturaExamenDTO = new FacturaExamenDTO();
            FacturaDetalle oDetalleFactura = new FacturaDetalle();
            FacturaEncabezado oFacturaEncabezado = new FacturaEncabezado();
            Paciente oPaciente = new Paciente();
            Examen oExamen = new Examen();
            BLLExamen oBLLExamen = new BLLExamen();

            try
            {
                if (this.dgvDetalleEmail.SelectedRows.Count > 0)
                {
                    oFacturaExamenDTO = this.dgvDetalleEmail.SelectedRows[0].DataBoundItem as FacturaExamenDTO;
                    //id, sec, estado
                    oDetalleFactura.IdFactura = oFacturaExamenDTO.IdFactura;
                    oDetalleFactura.Secuencia = oFacturaExamenDTO.Secuencia;
                    oDetalleFactura.EstadoExamen = EstadoExamen.Entregado.ToString();
                    oExamen.IdExamen = oFacturaExamenDTO.IdExamen;

                    _BLLFactura.UpdateEstadoDetalleFactura(oDetalleFactura); //devuelve bool

                    oPaciente = _BLLPaciente.ReadPacienteById(oFacturaExamenDTO.IdPaciente.ToString());

                    //Parametros de Atributos son filtros del DataSet
                    frmReporteEntregaExamenLaboratorio ofrmReporteEntregaExamenLaboratorio =
                        new frmReporteEntregaExamenLaboratorio(oPaciente,
                                                               oFacturaExamenDTO.IdFactura,
                                                               oFacturaExamenDTO.Secuencia,
                                                               oBLLExamen.CalculaResultadoExamen(oExamen, oDetalleFactura),
                                                               oFacturaExamenDTO.DescripcionExamen);
                    ofrmReporteEntregaExamenLaboratorio.ShowDialog();

                    CargarDatosDataGridViewCorreoElectronico();
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
    }
}
