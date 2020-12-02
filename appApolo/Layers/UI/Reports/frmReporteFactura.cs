using log4net;
using Microsoft.Reporting.WinForms;
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
using UTN.Winforms.Apolo.Properties;

namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    public partial class frmReporteFactura : Form
    {
        private decimal _IdFactura;
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        Usuario _Usuario = new Usuario();

        public frmReporteFactura(decimal pIdFactura)
        {
            _Usuario.Login = Settings.Default.Login;
            _Usuario.Password = Settings.Default.Password;
            InitializeComponent();
            _IdFactura = pIdFactura;
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection(_Usuario.Login, _Usuario.Password)))
                {
                    //Se le coloca al Adaptador la conexion a la BD.
                    FacturaTableAdapter.Connection = db._Conexion as System.Data.SqlClient.SqlConnection;
                    this.FacturaTableAdapter.Fill(this.DSReportes.Factura, _IdFactura);
                }

                string ruta = @"file:///" + @"C:/TEMP/qr.png";
                // Habilitar imagenes externas
                this.rptVisor.LocalReport.EnableExternalImages = true;
                ReportParameter param = new ReportParameter("quickresponse", ruta);
                this.rptVisor.LocalReport.SetParameters(param);
                this.rptVisor.RefreshReport();

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
            this.rptVisor.RefreshReport();
        }
    }
}
