using log4net;
using Microsoft.Reporting.WinForms;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    public partial class frmReporteEntregaExamenLaboratorio : Form
    {
        private int IdPaciente { get; set; }
        private int IdFactura { get; set; }
        private int IdSecuencia { get; set; }
        private string ResultadoExamen { get; set; }
        private string EmailPaciente { get; set; }

        private string DescripcionExamen { get; set; }
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public frmReporteEntregaExamenLaboratorio(int IdPaciente, int IdFactura, int IdSecuencia, string ResultadoExamen)
        {
            InitializeComponent();
            this.IdPaciente = IdPaciente;
            this.IdFactura = IdFactura;
            this.IdSecuencia = IdSecuencia;
            this.ResultadoExamen = ResultadoExamen;
        }

        //Para Envio de Correo Electrónico
        public frmReporteEntregaExamenLaboratorio(Paciente pPaciente, int IdFactura, int IdSecuencia, string ResultadoExamen, 
            string pDescripcionExamen)
        {
            InitializeComponent();
            this.IdPaciente = Convert.ToInt32(pPaciente.IdPaciente);
            this.IdFactura = IdFactura;
            this.IdSecuencia = IdSecuencia;
            this.ResultadoExamen = ResultadoExamen;
            this.DescripcionExamen = pDescripcionExamen;
            this.EmailPaciente = pPaciente.Email;
        }

        private void frmReporteEntregaExamenLaboratorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSReportes.ResultadoExamen' table. You can move, or remove it, as needed.
            this.ResultadoExamenTableAdapter.Fill(this.DSReportes.ResultadoExamen,this.IdFactura,this.IdSecuencia,this.IdPaciente.ToString());

            ReportParameter param = new ReportParameter("resultExam", this.ResultadoExamen);
            this.rptVisor.LocalReport.SetParameters(param);

            this.rptVisor.RefreshReport();

            EnviaCorreoElectronico();
        }

        public void EnviaCorreoElectronico()
        {
            string ruta = @"c:\temp\reporte.pdf";
            try
            {
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");

                byte[] Bytes = this.rptVisor.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }


                MailMessage mensaje = new MailMessage();
                mensaje.IsBodyHtml = true;
                mensaje.Subject = "Resultado de Exámen Laboratorio " + DescripcionExamen;
                mensaje.Body = "    Estimado paciente de Laboratorio Clínico Apolo S.A,\nadjuntamos " +
                               "resultado de su exámen de " + DescripcionExamen;
                mensaje.From = new MailAddress("generictestlarh96@gmail.com");
                mensaje.To.Add(this.EmailPaciente);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("generictestlarh96@gmail.com", "C0mpl1c4d4");
                smtp.EnableSsl = true;
                Attachment attachment = new Attachment(ruta);
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
                MessageBox.Show("Correo Enviado");
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
