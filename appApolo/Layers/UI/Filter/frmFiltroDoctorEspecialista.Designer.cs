namespace UTN.Winforms.Apolo.Layers.UI.Filtros
{
    partial class frmFiltroDoctorEspecialista
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMenuAdministración = new System.Windows.Forms.MenuStrip();
            this.toolStripBtnNuevaConsulta = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.msMenuAdministración.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 73);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(445, 20);
            this.txtFiltro.TabIndex = 6;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.fotografia,
            this.Column2,
            this.Apellidos1});
            this.dgvDatos.Location = new System.Drawing.Point(12, 99);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(445, 274);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodigoEspecialista";
            this.Column1.HeaderText = "Código Especialista";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // fotografia
            // 
            this.fotografia.DataPropertyName = "Fotografia";
            this.fotografia.HeaderText = "Fotografia";
            this.fotografia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotografia.Name = "fotografia";
            this.fotografia.ReadOnly = true;
            this.fotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Apellidos1
            // 
            this.Apellidos1.DataPropertyName = "Apellidos";
            this.Apellidos1.HeaderText = "Apellidos";
            this.Apellidos1.Name = "Apellidos1";
            this.Apellidos1.ReadOnly = true;
            this.Apellidos1.Width = 150;
            // 
            // msMenuAdministración
            // 
            this.msMenuAdministración.AutoSize = false;
            this.msMenuAdministración.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevaConsulta,
            this.toolStripBtnBuscar,
            this.toolStripBtnSalir});
            this.msMenuAdministración.Location = new System.Drawing.Point(0, 0);
            this.msMenuAdministración.Name = "msMenuAdministración";
            this.msMenuAdministración.Size = new System.Drawing.Size(473, 70);
            this.msMenuAdministración.TabIndex = 8;
            // 
            // toolStripBtnNuevaConsulta
            // 
            this.toolStripBtnNuevaConsulta.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_person_add_black_48dp;
            this.toolStripBtnNuevaConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevaConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevaConsulta.Name = "toolStripBtnNuevaConsulta";
            this.toolStripBtnNuevaConsulta.Size = new System.Drawing.Size(93, 63);
            this.toolStripBtnNuevaConsulta.Text = "Nueva consulta";
            this.toolStripBtnNuevaConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnNuevaConsulta.ToolTipText = "Actualiza datos del usuario y recarga los usuarios";
            this.toolStripBtnNuevaConsulta.Click += new System.EventHandler(this.toolStripBtnNuevaConsulta_Click);
            // 
            // toolStripBtnBuscar
            // 
            this.toolStripBtnBuscar.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.toolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBuscar.Name = "toolStripBtnBuscar";
            this.toolStripBtnBuscar.Size = new System.Drawing.Size(52, 63);
            this.toolStripBtnBuscar.Text = "Buscar";
            this.toolStripBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnBuscar.ToolTipText = "Buscar";
            this.toolStripBtnBuscar.Click += new System.EventHandler(this.toolStripBtnBuscar_Click);
            // 
            // toolStripBtnSalir
            // 
            this.toolStripBtnSalir.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_login_black_48dp1;
            this.toolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSalir.Name = "toolStripBtnSalir";
            this.toolStripBtnSalir.Size = new System.Drawing.Size(52, 63);
            this.toolStripBtnSalir.Text = "Salir";
            this.toolStripBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSalir.ToolTipText = "Borra el usuario de la fila seleccionada";
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click);
            // 
            // frmFiltroDoctorEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 385);
            this.Controls.Add(this.msMenuAdministración);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmFiltroDoctorEspecialista";
            this.Text = "Filtro Doctor Especialista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.msMenuAdministración.ResumeLayout(false);
            this.msMenuAdministración.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MenuStrip msMenuAdministración;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevaConsulta;
        private System.Windows.Forms.ToolStripButton toolStripBtnBuscar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos1;
    }
}