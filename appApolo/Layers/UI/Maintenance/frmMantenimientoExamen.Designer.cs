namespace UTN.Winforms.Apolo.UI
{
    partial class frmMantenimientoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoExamen));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvExamen = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlExamen = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbTipoExamen = new System.Windows.Forms.ComboBox();
            this.LblTipoExamen = new System.Windows.Forms.Label();
            this.lblValorMinimo = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtValorMaximo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblValorMaximo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlExamen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCrear,
            this.toolStripBtnActualizar,
            this.toolStripBtnBorrar,
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(997, 75);
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
            this.toolStripBtnCrear.Click += new System.EventHandler(this.toolStripBtnCrear_Click);
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
            this.toolStripBtnActualizar.Click += new System.EventHandler(this.toolStripBtnActualizar_Click);
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
            this.toolStripBtnBorrar.Click += new System.EventHandler(this.toolStripBtnBorrar_Click);
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
            // dgvExamen
            // 
            this.dgvExamen.AllowUserToAddRows = false;
            this.dgvExamen.AllowUserToDeleteRows = false;
            this.dgvExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.costo,
            this.valorMinimo,
            this.valorMaximo});
            this.dgvExamen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamen.Location = new System.Drawing.Point(0, 0);
            this.dgvExamen.Name = "dgvExamen";
            this.dgvExamen.ReadOnly = true;
            this.dgvExamen.Size = new System.Drawing.Size(640, 319);
            this.dgvExamen.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlExamen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvExamen);
            this.splitContainer1.Size = new System.Drawing.Size(997, 319);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnlExamen
            // 
            this.pnlExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExamen.Controls.Add(this.btnCancelar);
            this.pnlExamen.Controls.Add(this.btnAceptar);
            this.pnlExamen.Controls.Add(this.cmbTipoExamen);
            this.pnlExamen.Controls.Add(this.LblTipoExamen);
            this.pnlExamen.Controls.Add(this.lblValorMinimo);
            this.pnlExamen.Controls.Add(this.txtCosto);
            this.pnlExamen.Controls.Add(this.txtValorMaximo);
            this.pnlExamen.Controls.Add(this.txtNombre);
            this.pnlExamen.Controls.Add(this.lblValorMaximo);
            this.pnlExamen.Controls.Add(this.txtCodigo);
            this.pnlExamen.Controls.Add(this.txtValorMinimo);
            this.pnlExamen.Controls.Add(this.lblCosto);
            this.pnlExamen.Controls.Add(this.lblCodigo);
            this.pnlExamen.Controls.Add(this.lblNombre);
            this.pnlExamen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExamen.Location = new System.Drawing.Point(0, 0);
            this.pnlExamen.Name = "pnlExamen";
            this.pnlExamen.Size = new System.Drawing.Size(353, 319);
            this.pnlExamen.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_cancel_black_48dp1;
            this.btnCancelar.Location = new System.Drawing.Point(163, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 59);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_done_outline_black_48dp;
            this.btnAceptar.Location = new System.Drawing.Point(55, 246);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 58);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbTipoExamen
            // 
            this.cmbTipoExamen.FormattingEnabled = true;
            this.cmbTipoExamen.Location = new System.Drawing.Point(136, 94);
            this.cmbTipoExamen.Name = "cmbTipoExamen";
            this.cmbTipoExamen.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoExamen.TabIndex = 12;
            // 
            // LblTipoExamen
            // 
            this.LblTipoExamen.AutoSize = true;
            this.LblTipoExamen.Location = new System.Drawing.Point(52, 102);
            this.LblTipoExamen.Name = "LblTipoExamen";
            this.LblTipoExamen.Size = new System.Drawing.Size(69, 13);
            this.LblTipoExamen.TabIndex = 11;
            this.LblTipoExamen.Text = "Tipo Exámen";
            // 
            // lblValorMinimo
            // 
            this.lblValorMinimo.AutoSize = true;
            this.lblValorMinimo.Location = new System.Drawing.Point(52, 168);
            this.lblValorMinimo.Name = "lblValorMinimo";
            this.lblValorMinimo.Size = new System.Drawing.Size(68, 13);
            this.lblValorMinimo.TabIndex = 3;
            this.lblValorMinimo.Text = "Valor mínimo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(136, 131);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 7;
            // 
            // txtValorMaximo
            // 
            this.txtValorMaximo.Location = new System.Drawing.Point(136, 207);
            this.txtValorMaximo.Name = "txtValorMaximo";
            this.txtValorMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtValorMaximo.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblValorMaximo
            // 
            this.lblValorMaximo.AutoSize = true;
            this.lblValorMaximo.Location = new System.Drawing.Point(52, 207);
            this.lblValorMaximo.Name = "lblValorMaximo";
            this.lblValorMaximo.Size = new System.Drawing.Size(69, 13);
            this.lblValorMaximo.TabIndex = 4;
            this.lblValorMaximo.Text = "Valor máximo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtValorMinimo
            // 
            this.txtValorMinimo.Location = new System.Drawing.Point(136, 168);
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtValorMinimo.TabIndex = 8;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(52, 131);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Costo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(52, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // id
            // 
            this.id.DataPropertyName = "idExamen";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Descripcion";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "Costo";
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // valorMinimo
            // 
            this.valorMinimo.DataPropertyName = "valorMinimo";
            this.valorMinimo.HeaderText = "Valor mínimo";
            this.valorMinimo.Name = "valorMinimo";
            this.valorMinimo.ReadOnly = true;
            // 
            // valorMaximo
            // 
            this.valorMaximo.DataPropertyName = "valorMaximo";
            this.valorMaximo.HeaderText = "Valor máximo";
            this.valorMaximo.Name = "valorMaximo";
            this.valorMaximo.ReadOnly = true;
            // 
            // frmMantenimientoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 394);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmMantenimientoExamen";
            this.Text = "Exámen";
            this.Load += new System.EventHandler(this.frmMantenimientoExamen_Load);
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamen)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlExamen.ResumeLayout(false);
            this.pnlExamen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.ToolStripButton toolStripBtnCrear;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DataGridView dgvExamen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtValorMaximo;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblValorMaximo;
        private System.Windows.Forms.Label lblValorMinimo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlExamen;
        private System.Windows.Forms.ComboBox cmbTipoExamen;
        private System.Windows.Forms.Label LblTipoExamen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMaximo;
    }
}