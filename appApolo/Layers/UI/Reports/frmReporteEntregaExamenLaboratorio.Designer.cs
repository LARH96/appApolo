namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    partial class frmReporteEntregaExamenLaboratorio
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
            this.DSReportes = new UTN.Winforms.Apolo.Layers.UI.Reports.DSReportes();
            this.ResultadoExamenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResultadoExamenTableAdapter = new UTN.Winforms.Apolo.Layers.UI.Reports.DSReportesTableAdapters.ResultadoExamenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoExamenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptVisor
            // 
            this.rptVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSResultExamen";
            reportDataSource1.Value = this.ResultadoExamenBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Winforms.Apolo.Layers.UI.Reports.rptEntregaExamenLaboratorio.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(0, 0);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.ServerReport.BearerToken = null;
            this.rptVisor.Size = new System.Drawing.Size(800, 450);
            this.rptVisor.TabIndex = 0;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResultadoExamenBindingSource
            // 
            this.ResultadoExamenBindingSource.DataMember = "ResultadoExamen";
            this.ResultadoExamenBindingSource.DataSource = this.DSReportes;
            // 
            // ResultadoExamenTableAdapter
            // 
            this.ResultadoExamenTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEntregaExamenLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptVisor);
            this.Name = "frmReporteEntregaExamenLaboratorio";
            this.Text = "Reporte Exámen Laboratorio";
            this.Load += new System.EventHandler(this.frmReporteEntregaExamenLaboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoExamenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource ResultadoExamenBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.ResultadoExamenTableAdapter ResultadoExamenTableAdapter;
    }
}