namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    partial class frmProcesoEstudioExamenLaboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoEstudioExamenLaboratorio));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.sptContainer = new System.Windows.Forms.SplitContainer();
            this.grpBxExamenes = new System.Windows.Forms.GroupBox();
            this.txtFiltroIdPaciente = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxDatosExamenes = new System.Windows.Forms.GroupBox();
            this.LblFechaMuestra = new System.Windows.Forms.Label();
            this.dtpFechaMuestra = new System.Windows.Forms.DateTimePicker();
            this.txtValorResultExam = new System.Windows.Forms.TextBox();
            this.lblResultadoExamen = new System.Windows.Forms.Label();
            this.lblExamen = new System.Windows.Forms.Label();
            this.txtDescripcionExamen = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblIdentificacionPaciente = new System.Windows.Forms.Label();
            this.txtNumeroExamen = new System.Windows.Forms.TextBox();
            this.txtIdentificacionPaciente = new System.Windows.Forms.TextBox();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFiltroIdPaciente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStripBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLlenar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptContainer)).BeginInit();
            this.sptContainer.Panel1.SuspendLayout();
            this.sptContainer.Panel2.SuspendLayout();
            this.sptContainer.SuspendLayout();
            this.grpBxExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.grpBxDatosExamenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnGuardar,
            this.toolStripBtnLlenar,
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(963, 75);
            this.tspDoctorEspecialista.TabIndex = 4;
            this.tspDoctorEspecialista.Text = "toolStrip1";
            // 
            // sptContainer
            // 
            this.sptContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptContainer.Location = new System.Drawing.Point(0, 75);
            this.sptContainer.Name = "sptContainer";
            // 
            // sptContainer.Panel1
            // 
            this.sptContainer.Panel1.Controls.Add(this.grpBxExamenes);
            // 
            // sptContainer.Panel2
            // 
            this.sptContainer.Panel2.Controls.Add(this.grpBxDatosExamenes);
            this.sptContainer.Size = new System.Drawing.Size(963, 311);
            this.sptContainer.SplitterDistance = 599;
            this.sptContainer.TabIndex = 5;
            // 
            // grpBxExamenes
            // 
            this.grpBxExamenes.Controls.Add(this.txtFiltroIdPaciente);
            this.grpBxExamenes.Controls.Add(this.btnFiltroIdPaciente);
            this.grpBxExamenes.Controls.Add(this.dgvDetalle);
            this.grpBxExamenes.Location = new System.Drawing.Point(3, 5);
            this.grpBxExamenes.Name = "grpBxExamenes";
            this.grpBxExamenes.Size = new System.Drawing.Size(593, 300);
            this.grpBxExamenes.TabIndex = 0;
            this.grpBxExamenes.TabStop = false;
            this.grpBxExamenes.Text = "Exámenes Pendientes";
            // 
            // txtFiltroIdPaciente
            // 
            this.txtFiltroIdPaciente.Location = new System.Drawing.Point(16, 25);
            this.txtFiltroIdPaciente.Name = "txtFiltroIdPaciente";
            this.txtFiltroIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroIdPaciente.TabIndex = 2;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.noFactura,
            this.noExamen,
            this.codExamen,
            this.examen});
            this.dgvDetalle.Location = new System.Drawing.Point(6, 66);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(567, 236);
            this.dgvDetalle.TabIndex = 0;
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
            // grpBxDatosExamenes
            // 
            this.grpBxDatosExamenes.Controls.Add(this.btnCancelar);
            this.grpBxDatosExamenes.Controls.Add(this.LblFechaMuestra);
            this.grpBxDatosExamenes.Controls.Add(this.dtpFechaMuestra);
            this.grpBxDatosExamenes.Controls.Add(this.txtValorResultExam);
            this.grpBxDatosExamenes.Controls.Add(this.lblResultadoExamen);
            this.grpBxDatosExamenes.Controls.Add(this.lblExamen);
            this.grpBxDatosExamenes.Controls.Add(this.txtDescripcionExamen);
            this.grpBxDatosExamenes.Controls.Add(this.txtNumeroFactura);
            this.grpBxDatosExamenes.Controls.Add(this.lblNumeroFactura);
            this.grpBxDatosExamenes.Controls.Add(this.lblNombrePaciente);
            this.grpBxDatosExamenes.Controls.Add(this.lblIdentificacionPaciente);
            this.grpBxDatosExamenes.Controls.Add(this.txtNumeroExamen);
            this.grpBxDatosExamenes.Controls.Add(this.txtIdentificacionPaciente);
            this.grpBxDatosExamenes.Location = new System.Drawing.Point(3, 5);
            this.grpBxDatosExamenes.Name = "grpBxDatosExamenes";
            this.grpBxDatosExamenes.Size = new System.Drawing.Size(367, 300);
            this.grpBxDatosExamenes.TabIndex = 31;
            this.grpBxDatosExamenes.TabStop = false;
            this.grpBxDatosExamenes.Text = "Datos Exámen";
            // 
            // LblFechaMuestra
            // 
            this.LblFechaMuestra.AutoSize = true;
            this.LblFechaMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaMuestra.Location = new System.Drawing.Point(36, 178);
            this.LblFechaMuestra.Name = "LblFechaMuestra";
            this.LblFechaMuestra.Size = new System.Drawing.Size(102, 15);
            this.LblFechaMuestra.TabIndex = 49;
            this.LblFechaMuestra.Text = "Fecha Muestra";
            // 
            // dtpFechaMuestra
            // 
            this.dtpFechaMuestra.Enabled = false;
            this.dtpFechaMuestra.Location = new System.Drawing.Point(153, 174);
            this.dtpFechaMuestra.Name = "dtpFechaMuestra";
            this.dtpFechaMuestra.Size = new System.Drawing.Size(183, 20);
            this.dtpFechaMuestra.TabIndex = 48;
            // 
            // txtValorResultExam
            // 
            this.txtValorResultExam.Enabled = false;
            this.txtValorResultExam.Location = new System.Drawing.Point(187, 144);
            this.txtValorResultExam.Name = "txtValorResultExam";
            this.txtValorResultExam.Size = new System.Drawing.Size(100, 20);
            this.txtValorResultExam.TabIndex = 47;
            // 
            // lblResultadoExamen
            // 
            this.lblResultadoExamen.AutoSize = true;
            this.lblResultadoExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoExamen.Location = new System.Drawing.Point(36, 147);
            this.lblResultadoExamen.Name = "lblResultadoExamen";
            this.lblResultadoExamen.Size = new System.Drawing.Size(145, 13);
            this.lblResultadoExamen.TabIndex = 46;
            this.lblResultadoExamen.Text = "Valor Resultado Exámen";
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.Location = new System.Drawing.Point(36, 117);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(45, 13);
            this.lblExamen.TabIndex = 45;
            this.lblExamen.Text = "Exámen";
            // 
            // txtDescripcionExamen
            // 
            this.txtDescripcionExamen.Enabled = false;
            this.txtDescripcionExamen.Location = new System.Drawing.Point(187, 113);
            this.txtDescripcionExamen.Name = "txtDescripcionExamen";
            this.txtDescripcionExamen.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionExamen.TabIndex = 44;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Enabled = false;
            this.txtNumeroFactura.Location = new System.Drawing.Point(187, 57);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroFactura.TabIndex = 43;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(36, 61);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(63, 13);
            this.lblNumeroFactura.TabIndex = 42;
            this.lblNumeroFactura.Text = "No. Factura";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(36, 89);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(65, 13);
            this.lblNombrePaciente.TabIndex = 7;
            this.lblNombrePaciente.Text = "No. Examen";
            // 
            // lblIdentificacionPaciente
            // 
            this.lblIdentificacionPaciente.AutoSize = true;
            this.lblIdentificacionPaciente.Location = new System.Drawing.Point(36, 32);
            this.lblIdentificacionPaciente.Name = "lblIdentificacionPaciente";
            this.lblIdentificacionPaciente.Size = new System.Drawing.Size(115, 13);
            this.lblIdentificacionPaciente.TabIndex = 6;
            this.lblIdentificacionPaciente.Text = "Identificación Paciente";
            // 
            // txtNumeroExamen
            // 
            this.txtNumeroExamen.Enabled = false;
            this.txtNumeroExamen.Location = new System.Drawing.Point(187, 85);
            this.txtNumeroExamen.Name = "txtNumeroExamen";
            this.txtNumeroExamen.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroExamen.TabIndex = 8;
            // 
            // txtIdentificacionPaciente
            // 
            this.txtIdentificacionPaciente.Enabled = false;
            this.txtIdentificacionPaciente.Location = new System.Drawing.Point(187, 25);
            this.txtIdentificacionPaciente.Name = "txtIdentificacionPaciente";
            this.txtIdentificacionPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionPaciente.TabIndex = 9;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // btnFiltroIdPaciente
            // 
            this.btnFiltroIdPaciente.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_search_black_48dp;
            this.btnFiltroIdPaciente.Location = new System.Drawing.Point(122, 9);
            this.btnFiltroIdPaciente.Name = "btnFiltroIdPaciente";
            this.btnFiltroIdPaciente.Size = new System.Drawing.Size(115, 51);
            this.btnFiltroIdPaciente.TabIndex = 1;
            this.btnFiltroIdPaciente.Text = "Buscar por ID paciente";
            this.btnFiltroIdPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltroIdPaciente.UseVisualStyleBackColor = true;
            this.btnFiltroIdPaciente.Click += new System.EventHandler(this.btnFiltroIdPaciente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_cancel_black_48dp1;
            this.btnCancelar.Location = new System.Drawing.Point(132, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 59);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStripBtnGuardar
            // 
            this.toolStripBtnGuardar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_save_black_48dp;
            this.toolStripBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnGuardar.Name = "toolStripBtnGuardar";
            this.toolStripBtnGuardar.Size = new System.Drawing.Size(53, 72);
            this.toolStripBtnGuardar.Text = "Guardar";
            this.toolStripBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnGuardar.Click += new System.EventHandler(this.toolStripBtnGuardar_Click);
            // 
            // toolStripBtnLlenar
            // 
            this.toolStripBtnLlenar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_create_black_48dp;
            this.toolStripBtnLlenar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnLlenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLlenar.Name = "toolStripBtnLlenar";
            this.toolStripBtnLlenar.Size = new System.Drawing.Size(52, 72);
            this.toolStripBtnLlenar.Text = "Llenar";
            this.toolStripBtnLlenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnLlenar.Click += new System.EventHandler(this.toolStripBtnLlenar_Click);
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
            // frmProcesoEstudioExamenLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 386);
            this.Controls.Add(this.sptContainer);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmProcesoEstudioExamenLaboratorio";
            this.Text = "Estudio Exámen Laboratorio";
            this.Load += new System.EventHandler(this.frmProcesoEstudioExamenLaboratorio_Load);
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            this.sptContainer.Panel1.ResumeLayout(false);
            this.sptContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptContainer)).EndInit();
            this.sptContainer.ResumeLayout(false);
            this.grpBxExamenes.ResumeLayout(false);
            this.grpBxExamenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.grpBxDatosExamenes.ResumeLayout(false);
            this.grpBxDatosExamenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.ToolStripButton toolStripBtnGuardar;
        private System.Windows.Forms.ToolStripButton toolStripBtnLlenar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer sptContainer;
        private System.Windows.Forms.GroupBox grpBxDatosExamenes;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblIdentificacionPaciente;
        private System.Windows.Forms.TextBox txtNumeroExamen;
        private System.Windows.Forms.TextBox txtIdentificacionPaciente;
        private System.Windows.Forms.GroupBox grpBxExamenes;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.TextBox txtDescripcionExamen;
        private System.Windows.Forms.Label lblResultadoExamen;
        private System.Windows.Forms.TextBox txtFiltroIdPaciente;
        private System.Windows.Forms.Button btnFiltroIdPaciente;
        private System.Windows.Forms.TextBox txtValorResultExam;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label LblFechaMuestra;
        private System.Windows.Forms.DateTimePicker dtpFechaMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn noExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn codExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn examen;
        private System.Windows.Forms.Button btnCancelar;
    }
}