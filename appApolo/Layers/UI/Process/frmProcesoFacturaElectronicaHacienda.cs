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

namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    public partial class frmProcesoFacturaElectronicaHacienda : Form
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        IBLLFactura _IBLLFactura = new BLLFactura();

        public frmProcesoFacturaElectronicaHacienda()
        {
            InitializeComponent();
        }

        private void frmProcesoFacturaElectronicaHacienda_Load(object sender, EventArgs e)
        {
            try
            {
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

        private void CargarDatosDataGridView()
        {
            this.dgvFactura.AutoGenerateColumns = false;
            // Cargar el DataGridView
            this.dgvFactura.DataSource = _IBLLFactura.GetAllFacturaByFilterEstadoHaciendaSinEnviar();
        }

        private void btnEnviarHacienda_Click(object sender, EventArgs e)
        {
            string XMLHacienda = "";
            List<FacturaExamenDTO> _ListaFacturaExamenDTO = new List<FacturaExamenDTO>();
            List<FacturaExamenDTO> _ListaFiltradaFacturaExamenDTO = new List<FacturaExamenDTO>();
            IBLLMinisterioHacienda _IBLLMinisterioHacienda = new BLLMinisterioHacienda();
            MinisterioHacienda oMinisterioHacienda = new MinisterioHacienda();
            DateTime FechaInicial = dtpFechaFinal.Value;
            DateTime FechaFinal = dtpFechaFinal.Value;

            _ListaFacturaExamenDTO = _IBLLFactura.GetAllFacturaByFilterEstadoHaciendaSinEnviar();

            //Filtra DTO de Fechas entre rango solicitado
            _ListaFiltradaFacturaExamenDTO = _IBLLFactura.FiltraRangoFechasFactura(_ListaFacturaExamenDTO, FechaInicial, FechaFinal);

            //Crea XML a solo DTOs entre fechas
            XMLHacienda = _IBLLFactura.CrearXMLFacturaHacienda(_ListaFiltradaFacturaExamenDTO, FechaInicial, FechaFinal);

            //Guarda XML de Hacienda
            oMinisterioHacienda.IdMinisterioHacienda = _IBLLMinisterioHacienda.GetCurrentNumeroConsecutivo();
            _IBLLMinisterioHacienda.GetNextNumeroConsecutivo();
            oMinisterioHacienda.XML = XMLHacienda;
            _IBLLMinisterioHacienda.CreateMinisterioHacienda(oMinisterioHacienda);

            //Actualiza a EstadoEnviado las facturas que se enviaron a Hacienda
            _IBLLFactura.UpdateEstadoFacturaEncabezadoParaHacienda(_ListaFacturaExamenDTO);

            CargarDatosDataGridView();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}