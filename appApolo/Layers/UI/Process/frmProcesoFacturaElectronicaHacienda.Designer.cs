namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    partial class frmProcesoFacturaElectronicaHacienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoFacturaElectronicaHacienda));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblRangoFechas = new System.Windows.Forms.Label();
            this.btnEnviarHacienda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.noFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tspDoctorEspecialista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(478, 75);
            this.tspDoctorEspecialista.TabIndex = 5;
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
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(110, 78);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(110, 114);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 7;
            // 
            // lblRangoFechas
            // 
            this.lblRangoFechas.AutoSize = true;
            this.lblRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoFechas.Location = new System.Drawing.Point(24, 84);
            this.lblRangoFechas.Name = "lblRangoFechas";
            this.lblRangoFechas.Size = new System.Drawing.Size(80, 13);
            this.lblRangoFechas.TabIndex = 8;
            this.lblRangoFechas.Text = "Fecha Inicial";
            // 
            // btnEnviarHacienda
            // 
            this.btnEnviarHacienda.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_send_black_48dp;
            this.btnEnviarHacienda.Location = new System.Drawing.Point(316, 78);
            this.btnEnviarHacienda.Name = "btnEnviarHacienda";
            this.btnEnviarHacienda.Size = new System.Drawing.Size(120, 55);
            this.btnEnviarHacienda.TabIndex = 9;
            this.btnEnviarHacienda.Text = "Enviar a Hacienda";
            this.btnEnviarHacienda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarHacienda.UseVisualStyleBackColor = true;
            this.btnEnviarHacienda.Click += new System.EventHandler(this.btnEnviarHacienda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFactura);
            this.groupBox1.Location = new System.Drawing.Point(27, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 305);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturas pendientes de enviar a Hacienda";
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noFactura,
            this.idPaciente,
            this.examen});
            this.dgvFactura.Location = new System.Drawing.Point(6, 22);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.Size = new System.Drawing.Size(398, 283);
            this.dgvFactura.TabIndex = 4;
            // 
            // noFactura
            // 
            this.noFactura.DataPropertyName = "IdFactura";
            this.noFactura.HeaderText = "No. Factura";
            this.noFactura.Name = "noFactura";
            this.noFactura.ReadOnly = true;
            // 
            // idPaciente
            // 
            this.idPaciente.DataPropertyName = "IdPaciente";
            this.idPaciente.HeaderText = "ID Paciente";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            // 
            // examen
            // 
            this.examen.DataPropertyName = "Fecha";
            this.examen.HeaderText = "Fecha";
            this.examen.Name = "examen";
            this.examen.ReadOnly = true;
            this.examen.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha Final";
            // 
            // frmProcesoFacturaElectronicaHacienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnviarHacienda);
            this.Controls.Add(this.lblRangoFechas);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmProcesoFacturaElectronicaHacienda";
            this.Text = "Factura Electrónica Hacienda";
            this.Load += new System.EventHandler(this.frmProcesoFacturaElectronicaHacienda_Load);
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lblRangoFechas;
        private System.Windows.Forms.Button btnEnviarHacienda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn examen;
    }
}