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
            this.toolStripBtnLeer = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlExamen = new System.Windows.Forms.Panel();
            this.lblValorMinimo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblValorMaximo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
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
            this.toolStripBtnLeer,
            this.toolStripBtnActualizar,
            this.toolStripBtnBorrar,
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(838, 75);
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
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.costo,
            this.valorMinimo,
            this.valorMaximo});
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(537, 375);
            this.dgvPacientes.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            // 
            // valorMinimo
            // 
            this.valorMinimo.HeaderText = "Valor mínimo";
            this.valorMinimo.Name = "valorMinimo";
            // 
            // valorMaximo
            // 
            this.valorMaximo.HeaderText = "Valor Máximo";
            this.valorMaximo.Name = "valorMaximo";
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvPacientes);
            this.splitContainer1.Size = new System.Drawing.Size(838, 375);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnlExamen
            // 
            this.pnlExamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExamen.Controls.Add(this.lblValorMinimo);
            this.pnlExamen.Controls.Add(this.textBox3);
            this.pnlExamen.Controls.Add(this.textBox5);
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
            this.pnlExamen.Size = new System.Drawing.Size(297, 375);
            this.pnlExamen.TabIndex = 10;
            // 
            // lblValorMinimo
            // 
            this.lblValorMinimo.AutoSize = true;
            this.lblValorMinimo.Location = new System.Drawing.Point(52, 138);
            this.lblValorMinimo.Name = "lblValorMinimo";
            this.lblValorMinimo.Size = new System.Drawing.Size(68, 13);
            this.lblValorMinimo.TabIndex = 3;
            this.lblValorMinimo.Text = "Valor mínimo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
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
            this.lblValorMaximo.Location = new System.Drawing.Point(52, 177);
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
            this.txtValorMinimo.Location = new System.Drawing.Point(136, 138);
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtValorMinimo.TabIndex = 8;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(52, 101);
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
            // frmMantenimientoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmMantenimientoExamen";
            this.Text = "Exámen";
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripBtnLeer;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblValorMaximo;
        private System.Windows.Forms.Label lblValorMinimo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMaximo;
        private System.Windows.Forms.Panel pnlExamen;
    }
}