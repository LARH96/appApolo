using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winforms.Apolo.Entities;

namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    public partial class frmProcesoAtencionClientePaciente : Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        private Paciente _Paciente = null;
        private FacturaEncabezado _FacturaEncabezado = null;

        public frmProcesoAtencionClientePaciente()
        {
            InitializeComponent();
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void toolStripBtnFacturar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarCasillas()
        {
            txtDescripcion.Clear();
            txtIdentificacionCliente.Clear();
            txtCodigoExamen.Clear();
            txtNoFactura.Clear();
            txtNombreCliente.Clear();
            txtReferenciaMedica.Clear();

            cmbTipoTarjeta.SelectedIndex = 0;

            rdbEfectivo.Checked = false;
            rdbTarjeta.Checked = false;
            rdbPresencial.Checked = false;
            rdbCorreoElectronico.Checked = false;

            mskNoTarjeta.Clear();

            dgvDetalle.DataSource = null;
        }
    }
}
