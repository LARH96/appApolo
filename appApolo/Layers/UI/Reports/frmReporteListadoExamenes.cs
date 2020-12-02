using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    public partial class frmReporteListadoExamenes : Form
    {
        public frmReporteListadoExamenes()
        {
            InitializeComponent();
        }

        private void frmReporteListadoExamenes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSReportes.Examen' table. You can move, or remove it, as needed.
            this.ExamenTableAdapter.Fill(this.DSReportes.Examen);

            this.rptVisor.RefreshReport();
        }
    }
}
