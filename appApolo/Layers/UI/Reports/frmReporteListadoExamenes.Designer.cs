namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    partial class frmReporteListadoExamenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSReportes = new UTN.Winforms.Apolo.Layers.UI.Reports.DSReportes();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenTableAdapter = new UTN.Winforms.Apolo.Layers.UI.Reports.DSReportesTableAdapters.ExamenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptVisor
            // 
            this.rptVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSListExamen";
            reportDataSource1.Value = this.examenBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Winforms.Apolo.Layers.UI.Reports.rptListExamen.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 0);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.ServerReport.BearerToken = null;
            this.rptVisor.Size = new System.Drawing.Size(800, 450);
            this.rptVisor.TabIndex = 0;
            // 
            // dSReportes
            // 
            this.dSReportes.DataSetName = "DSReportes";
            this.dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataMember = "Examen";
            this.examenBindingSource.DataSource = this.dSReportes;
            // 
            // examenTableAdapter
            // 
            this.examenTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteListadoExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptVisor);
            this.Name = "frmReporteListadoExamenes";
            this.Text = "Listado Examenes";
            this.Load += new System.EventHandler(this.frmReporteListadoExamenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private DSReportes dSReportes;
        private System.Windows.Forms.BindingSource examenBindingSource;
        private DSReportesTableAdapters.ExamenTableAdapter examenTableAdapter;
    }
}