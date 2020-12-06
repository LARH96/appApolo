namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    partial class frmProcesoEntregaExamenLaboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoEntregaExamenLaboratorio));
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.spltEntregaExamenLab = new System.Windows.Forms.SplitContainer();
            this.grpBxPresencial = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtFiltroIdPaciente = new System.Windows.Forms.TextBox();
            this.btnFiltroIdPaciente = new System.Windows.Forms.Button();
            this.dgvDetallePresencial = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpxBoxCorreo = new System.Windows.Forms.GroupBox();
            this.dgvDetalleEmail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltEntregaExamenLab)).BeginInit();
            this.spltEntregaExamenLab.Panel1.SuspendLayout();
            this.spltEntregaExamenLab.Panel2.SuspendLayout();
            this.spltEntregaExamenLab.SuspendLayout();
            this.grpBxPresencial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresencial)).BeginInit();
            this.gpxBoxCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEmail)).BeginInit();
            this.SuspendLayout();
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
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(1240, 75);
            this.tspDoctorEspecialista.TabIndex = 4;
            this.tspDoctorEspecialista.Text = "toolStrip1";
            // 
            // spltEntregaExamenLab
            // 
            this.spltEntregaExamenLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltEntregaExamenLab.Location = new System.Drawing.Point(0, 75);
            this.spltEntregaExamenLab.Name = "spltEntregaExamenLab";
            // 
            // spltEntregaExamenLab.Panel1
            // 
            this.spltEntregaExamenLab.Panel1.Controls.Add(this.grpBxPresencial);
            // 
            // spltEntregaExamenLab.Panel2
            // 
            this.spltEntregaExamenLab.Panel2.Controls.Add(this.gpxBoxCorreo);
            this.spltEntregaExamenLab.Size = new System.Drawing.Size(1240, 375);
            this.spltEntregaExamenLab.SplitterDistance = 630;
            this.spltEntregaExamenLab.TabIndex = 5;
            // 
            // grpBxPresencial
            // 
            this.grpBxPresencial.Controls.Add(this.btnImprimir);
            this.grpBxPresencial.Controls.Add(this.txtFiltroIdPaciente);
            this.grpBxPresencial.Controls.Add(this.btnFiltroIdPaciente);
            this.grpBxPresencial.Controls.Add(this.dgvDetallePresencial);
            this.grpBxPresencial.Location = new System.Drawing.Point(3, 3);
            this.grpBxPresencial.Name = "grpBxPresencial";
            this.grpBxPresencial.Size = new System.Drawing.Size(592, 369);
            this.grpBxPresencial.TabIndex = 0;
            this.grpBxPresencial.TabStop = false;
            this.grpBxPresencial.Text = "Entrega Presencial";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_receipt_long_black_48dp;
            this.btnImprimir.Location = new System.Drawing.Point(233, 20);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(99, 51);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtFiltroIdPaciente
            // 
            this.txtFiltroIdPaciente.Location = new System.Drawing.Point(6, 36);
            this.txtFiltroIdPaciente.Name = "txtFiltroIdPaciente";
            this.txtFiltroIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroIdPaciente.TabIndex = 5;
            // 
            // btnFiltroIdPaciente
            // 
            this.btnFiltroIdPaciente.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_search_black_48dp;
            this.btnFiltroIdPaciente.Location = new System.Drawing.Point(112, 20);
            this.btnFiltroIdPaciente.Name = "btnFiltroIdPaciente";
            this.btnFiltroIdPaciente.Size = new System.Drawing.Size(115, 51);
            this.btnFiltroIdPaciente.TabIndex = 4;
            this.btnFiltroIdPaciente.Text = "Buscar por ID paciente";
            this.btnFiltroIdPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltroIdPaciente.UseVisualStyleBackColor = true;
            this.btnFiltroIdPaciente.Click += new System.EventHandler(this.btnFiltroIdPaciente_Click);
            // 
            // dgvDetallePresencial
            // 
            this.dgvDetallePresencial.AllowUserToAddRows = false;
            this.dgvDetallePresencial.AllowUserToDeleteRows = false;
            this.dgvDetallePresencial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePresencial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.noFactura,
            this.noExamen,
            this.codExamen,
            this.examen});
            this.dgvDetallePresencial.Location = new System.Drawing.Point(6, 77);
            this.dgvDetallePresencial.Name = "dgvDetallePresencial";
            this.dgvDetallePresencial.ReadOnly = true;
            this.dgvDetallePresencial.Size = new System.Drawing.Size(586, 283);
            this.dgvDetallePresencial.TabIndex = 3;
            // 
            // idPaciente
            // 
            this.idPaciente.DataPropertyName = "IdPaciente";
            this.idPaciente.HeaderText = "ID Paciente";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            // 
            // noFactura
            // 
            this.noFactura.DataPropertyName = "IdFactura";
            this.noFactura.HeaderText = "No. Factura";
            this.noFactura.Name = "noFactura";
            this.noFactura.ReadOnly = true;
            // 
            // noExamen
            // 
            this.noExamen.DataPropertyName = "Secuencia";
            this.noExamen.HeaderText = "No. Examen";
            this.noExamen.Name = "noExamen";
            this.noExamen.ReadOnly = true;
            // 
            // codExamen
            // 
            this.codExamen.DataPropertyName = "IdExamen";
            this.codExamen.HeaderText = "Cód. Exámen";
            this.codExamen.Name = "codExamen";
            this.codExamen.ReadOnly = true;
            // 
            // examen
            // 
            this.examen.DataPropertyName = "DescripcionExamen";
            this.examen.HeaderText = "Descripción Exámen";
            this.examen.Name = "examen";
            this.examen.ReadOnly = true;
            this.examen.Width = 120;
            // 
            // gpxBoxCorreo
            // 
            this.gpxBoxCorreo.Controls.Add(this.dgvDetalleEmail);
            this.gpxBoxCorreo.Controls.Add(this.btnEnviar);
            this.gpxBoxCorreo.Location = new System.Drawing.Point(12, 3);
            this.gpxBoxCorreo.Name = "gpxBoxCorreo";
            this.gpxBoxCorreo.Size = new System.Drawing.Size(591, 369);
            this.gpxBoxCorreo.TabIndex = 0;
            this.gpxBoxCorreo.TabStop = false;
            this.gpxBoxCorreo.Text = "Entrega Por Correo Electrónico";
            // 
            // dgvDetalleEmail
            // 
            this.dgvDetalleEmail.AllowUserToAddRows = false;
            this.dgvDetalleEmail.AllowUserToDeleteRows = false;
            this.dgvDetalleEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvDetalleEmail.Location = new System.Drawing.Point(0, 77);
            this.dgvDetalleEmail.Name = "dgvDetalleEmail";
            this.dgvDetalleEmail.ReadOnly = true;
            this.dgvDetalleEmail.Size = new System.Drawing.Size(582, 283);
            this.dgvDetalleEmail.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPaciente";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Paciente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdFactura";
            this.dataGridViewTextBoxColumn2.HeaderText = "No. Factura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Secuencia";
            this.dataGridViewTextBoxColumn3.HeaderText = "No. Examen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdExamen";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cód. Exámen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DescripcionExamen";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción Exámen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_send_black_48dp;
            this.btnEnviar.Location = new System.Drawing.Point(223, 20);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 52);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmProcesoEntregaExamenLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.spltEntregaExamenLab);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmProcesoEntregaExamenLaboratorio";
            this.Text = "Entrega Exámen Laboratorio";
            this.Load += new System.EventHandler(this.frmProcesoEntregaExamenLaboratorio_Load);
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            this.spltEntregaExamenLab.Panel1.ResumeLayout(false);
            this.spltEntregaExamenLab.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltEntregaExamenLab)).EndInit();
            this.spltEntregaExamenLab.ResumeLayout(false);
            this.grpBxPresencial.ResumeLayout(false);
            this.grpBxPresencial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePresencial)).EndInit();
            this.gpxBoxCorreo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.SplitContainer spltEntregaExamenLab;
        private System.Windows.Forms.GroupBox grpBxPresencial;
        private System.Windows.Forms.GroupBox gpxBoxCorreo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtFiltroIdPaciente;
        private System.Windows.Forms.Button btnFiltroIdPaciente;
        private System.Windows.Forms.DataGridView dgvDetallePresencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn noExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn codExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn examen;
        private System.Windows.Forms.DataGridView dgvDetalleEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}