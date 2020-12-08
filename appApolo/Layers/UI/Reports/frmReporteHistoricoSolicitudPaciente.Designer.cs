namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    partial class frmReporteHistoricoSolicitudPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteHistoricoSolicitudPaciente));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SolicitudesPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSReportes = new UTN.Winforms.Apolo.Layers.UI.Reports.DSReportes();
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.rptVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SolicitudesPacientesTableAdapter = new UTN.Winforms.Apolo.Layers.UI.Reports.DSReportesTableAdapters.SolicitudesPacientesTableAdapter();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.toolStripBtnBuscar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SolicitudesPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // SolicitudesPacientesBindingSource
            // 
            this.SolicitudesPacientesBindingSource.DataMember = "SolicitudesPacientes";
            this.SolicitudesPacientesBindingSource.DataSource = this.DSReportes;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir,
            this.toolStripBtnBuscar});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(682, 75);
            this.tspDoctorEspecialista.TabIndex = 6;
            this.tspDoctorEspecialista.Text = "toolStrip1";
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSalir.Image")));
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(52, 72);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalir.ToolTipText = "Salir de la pantalla Paciente";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(518, 78);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(73, 13);
            this.lblFechaFinal.TabIndex = 15;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(324, 78);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicial.TabIndex = 14;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(460, 100);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 13;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(254, 100);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 12;
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPaciente.Location = new System.Drawing.Point(70, 78);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(153, 15);
            this.lblIdPaciente.TabIndex = 16;
            this.lblIdPaciente.Text = "Identificación Paciente";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Enabled = false;
            this.txtIdPaciente.Location = new System.Drawing.Point(73, 100);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(150, 20);
            this.txtIdPaciente.TabIndex = 17;
            // 
            // rptVisor
            // 
            reportDataSource2.Name = "DSHistoricoSolicitudPaciente";
            reportDataSource2.Value = this.SolicitudesPacientesBindingSource;
            this.rptVisor.LocalReport.DataSources.Add(reportDataSource2);
            this.rptVisor.LocalReport.ReportEmbeddedResource = "UTN.Winforms.Apolo.Layers.UI.Reports.rptHistoricoSolicitudPaciente.rdlc";
            this.rptVisor.Location = new System.Drawing.Point(12, 126);
            this.rptVisor.Name = "rptVisor";
            this.rptVisor.ServerReport.BearerToken = null;
            this.rptVisor.Size = new System.Drawing.Size(654, 359);
            this.rptVisor.TabIndex = 18;
            // 
            // SolicitudesPacientesTableAdapter
            // 
            this.SolicitudesPacientesTableAdapter.ClearBeforeFill = true;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(22, 74);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(42, 46);
            this.btnBuscarPaciente.TabIndex = 28;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // toolStripBtnBuscar
            // 
            this.toolStripBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnBuscar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_search_black_48dp;
            this.toolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBuscar.Name = "toolStripBtnBuscar";
            this.toolStripBtnBuscar.Size = new System.Drawing.Size(52, 72);
            this.toolStripBtnBuscar.Text = "Buscar";
            this.toolStripBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnBuscar.Click += new System.EventHandler(this.toolStripBtnBuscar_Click);
            // 
            // frmReporteHistoricoSolicitudPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 489);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.rptVisor);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmReporteHistoricoSolicitudPaciente";
            this.Text = "Historico Solicitud Paciente/Cliente";
            this.Load += new System.EventHandler(this.frmReporteHistoricoSolicitudPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SolicitudesPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private Microsoft.Reporting.WinForms.ReportViewer rptVisor;
        private System.Windows.Forms.BindingSource SolicitudesPacientesBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.SolicitudesPacientesTableAdapter SolicitudesPacientesTableAdapter;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.ToolStripButton toolStripBtnBuscar;
    }
}