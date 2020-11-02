namespace UTN.Winforms.Apolo
{
    partial class frmTipoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoExamen));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLeer = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTipoExamen = new System.Windows.Forms.TextBox();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.lblTipoExamen = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCrear,
            this.toolStripBtnLeer,
            this.toolStripBtnActualizar,
            this.toolStripBtnBorrar,
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(488, 75);
            this.tspDoctorEspecialista.TabIndex = 2;
            this.tspDoctorEspecialista.Text = "toolStrip1";
            // 
            // toolStripBtnCrear
            // 
            this.toolStripBtnCrear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCrear.Image")));
            this.toolStripBtnCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCrear.Name = "toolStripBtnCrear";
            this.toolStripBtnCrear.Size = new System.Drawing.Size(52, 72);
            this.toolStripBtnCrear.Text = "Crear";
            this.toolStripBtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnCrear.ToolTipText = "Crear un nuevo usuario";
            // 
            // toolStripBtnLeer
            // 
            this.toolStripBtnLeer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLeer.Image")));
            this.toolStripBtnLeer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnLeer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLeer.Name = "toolStripBtnLeer";
            this.toolStripBtnLeer.Size = new System.Drawing.Size(52, 72);
            this.toolStripBtnLeer.Text = "Leer";
            this.toolStripBtnLeer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnLeer.ToolTipText = "Leer los usuarios existentes";
            // 
            // toolStripBtnActualizar
            // 
            this.toolStripBtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnActualizar.Image")));
            this.toolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnActualizar.Name = "toolStripBtnActualizar";
            this.toolStripBtnActualizar.Size = new System.Drawing.Size(63, 72);
            this.toolStripBtnActualizar.Text = "Actualizar";
            this.toolStripBtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnActualizar.ToolTipText = "Actualiza datos del usuario y recarga los usuarios";
            // 
            // toolStripBtnBorrar
            // 
            this.toolStripBtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBorrar.Image")));
            this.toolStripBtnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBorrar.Name = "toolStripBtnBorrar";
            this.toolStripBtnBorrar.Size = new System.Drawing.Size(52, 72);
            this.toolStripBtnBorrar.Text = "Borrar";
            this.toolStripBtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnBorrar.ToolTipText = "Borra el usuario de la fila seleccionada";
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
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPacientes);
            this.splitContainer1.Size = new System.Drawing.Size(488, 375);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTipoExamen);
            this.panel1.Controls.Add(this.txtCódigo);
            this.panel1.Controls.Add(this.lblTipoExamen);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 375);
            this.panel1.TabIndex = 0;
            // 
            // txtTipoExamen
            // 
            this.txtTipoExamen.Location = new System.Drawing.Point(90, 57);
            this.txtTipoExamen.Name = "txtTipoExamen";
            this.txtTipoExamen.Size = new System.Drawing.Size(120, 20);
            this.txtTipoExamen.TabIndex = 3;
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(90, 24);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(120, 20);
            this.txtCódigo.TabIndex = 2;
            // 
            // lblTipoExamen
            // 
            this.lblTipoExamen.AutoSize = true;
            this.lblTipoExamen.Location = new System.Drawing.Point(17, 60);
            this.lblTipoExamen.Name = "lblTipoExamen";
            this.lblTipoExamen.Size = new System.Drawing.Size(69, 13);
            this.lblTipoExamen.TabIndex = 1;
            this.lblTipoExamen.Text = "Tipo Exámen";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tipoExamen});
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(253, 375);
            this.dgvPacientes.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            // 
            // tipoExamen
            // 
            this.tipoExamen.HeaderText = "Tipo Exámen";
            this.tipoExamen.Name = "tipoExamen";
            // 
            // frmTipoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmTipoExamen";
            this.Text = "Tipo Exámen";
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.ToolStripButton toolStripBtnCrear;
        private System.Windows.Forms.ToolStripButton toolStripBtnLeer;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTipoExamen;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.Label lblTipoExamen;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoExamen;
    }
}