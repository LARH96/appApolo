using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winforms.Apolo.Layers.UI.Maintenance
{
    public partial class frmMantenimientoPaciente : Form
    {
        public frmMantenimientoPaciente()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripBtnCrear_Click(object sender, EventArgs e)
        {
            LimpiarDatosPaciente();
        }

        private void LimpiarDatosPaciente()
        {
            this.pbxFotografia.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_add_photo_alternate_black_48dp;
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            mkdtxtIdentificación.Text = null;

            dtpkrFechaNacimiento.Value = DateTime.Now;
            rdBtnFemenino.Checked = false;
            rdBtnMasculino.Checked = false;
            rdBtnOtro.Checked = false;
            mkdtxtTelefono.Text = null;
            txtDireccion.Text = null;
            txtCorreoElectronico = null;
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede leer el archivo. Original error: " + ex.Message);
                }
            }
        }

        private void mkdtxtIdentificación_Click(object sender, EventArgs e)
        {
            mkdtxtIdentificación.Select(0,0);
        }

        private void mkdtxtTelefono_Click(object sender, EventArgs e)
        {
            mkdtxtTelefono.Select(0, 0);
        }

        private void frmMantenimientoPaciente_Load(object sender, EventArgs e)
        {
            mkdtxtIdentificación.Focus();
        }
    }
}
