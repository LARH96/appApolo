namespace UTN.Winforms.Apolo.Layers.UI.Administration
{
    partial class frmAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracion));
            this.msMenuAdministración = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnLeer = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.pnlCrearDatosUsuario = new System.Windows.Forms.Panel();
            this.txtFotografia = new System.Windows.Forms.TextBox();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnBuscarDocEspecialista = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenna = new System.Windows.Forms.TextBox();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenna = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpBxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rdBtnOtro = new System.Windows.Forms.RadioButton();
            this.rdBtnDoctorEspecialista = new System.Windows.Forms.RadioButton();
            this.sptCAdministracion = new System.Windows.Forms.SplitContainer();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.cmbTipoPerfil = new System.Windows.Forms.ComboBox();
            this.msMenuAdministración.SuspendLayout();
            this.pnlCrearDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.gpBxTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptCAdministracion)).BeginInit();
            this.sptCAdministracion.Panel1.SuspendLayout();
            this.sptCAdministracion.Panel2.SuspendLayout();
            this.sptCAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuAdministración
            // 
            this.msMenuAdministración.AutoSize = false;
            this.msMenuAdministración.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.crearUsuarioToolStripMenuItem,
            this.toolStripBtnLeer,
            this.toolStripBtnActualizar,
            this.toolStripBtnBorrar});
            this.msMenuAdministración.Location = new System.Drawing.Point(0, 0);
            this.msMenuAdministración.Name = "msMenuAdministración";
            this.msMenuAdministración.Size = new System.Drawing.Size(876, 70);
            this.msMenuAdministración.TabIndex = 1;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_home_black_18dp;
            this.homeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(66, 66);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_person_add_black_48dp;
            this.crearUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(90, 66);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // toolStripBtnLeer
            // 
            this.toolStripBtnLeer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLeer.Image")));
            this.toolStripBtnLeer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnLeer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLeer.Name = "toolStripBtnLeer";
            this.toolStripBtnLeer.Size = new System.Drawing.Size(52, 63);
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
            this.toolStripBtnActualizar.Size = new System.Drawing.Size(63, 63);
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
            this.toolStripBtnBorrar.Size = new System.Drawing.Size(52, 63);
            this.toolStripBtnBorrar.Text = "Borrar";
            this.toolStripBtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnBorrar.ToolTipText = "Borra el usuario de la fila seleccionada";
            // 
            // pnlCrearDatosUsuario
            // 
            this.pnlCrearDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrearDatosUsuario.Controls.Add(this.cmbTipoPerfil);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblTipoPerfil);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtFotografia);
            this.pnlCrearDatosUsuario.Controls.Add(this.pbxFotografia);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblId);
            this.pnlCrearDatosUsuario.Controls.Add(this.btnBuscarDocEspecialista);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblNombre);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblApellidos);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtConfirmarContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblConfirmarContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblFotografia);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtApellidos);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtId);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtNombre);
            this.pnlCrearDatosUsuario.Location = new System.Drawing.Point(29, 97);
            this.pnlCrearDatosUsuario.Name = "pnlCrearDatosUsuario";
            this.pnlCrearDatosUsuario.Size = new System.Drawing.Size(293, 350);
            this.pnlCrearDatosUsuario.TabIndex = 29;
            // 
            // txtFotografia
            // 
            this.txtFotografia.Enabled = false;
            this.txtFotografia.Location = new System.Drawing.Point(98, 12);
            this.txtFotografia.Multiline = true;
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.Size = new System.Drawing.Size(83, 85);
            this.txtFotografia.TabIndex = 28;
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFotografia.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_add_photo_alternate_black_48dp;
            this.pbxFotografia.Location = new System.Drawing.Point(98, 12);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(83, 85);
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFotografia.TabIndex = 15;
            this.pbxFotografia.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 124);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "-";
            // 
            // btnBuscarDocEspecialista
            // 
            this.btnBuscarDocEspecialista.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.btnBuscarDocEspecialista.Location = new System.Drawing.Point(244, 101);
            this.btnBuscarDocEspecialista.Name = "btnBuscarDocEspecialista";
            this.btnBuscarDocEspecialista.Size = new System.Drawing.Size(42, 40);
            this.btnBuscarDocEspecialista.TabIndex = 26;
            this.btnBuscarDocEspecialista.UseVisualStyleBackColor = true;
            this.btnBuscarDocEspecialista.Click += new System.EventHandler(this.btnBuscarDocEspecialista_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 155);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(11, 190);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(11, 226);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtConfirmarContrasenna
            // 
            this.txtConfirmarContrasenna.Location = new System.Drawing.Point(136, 309);
            this.txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            this.txtConfirmarContrasenna.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarContrasenna.TabIndex = 21;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(13, 284);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenna.TabIndex = 4;
            this.lblContrasenna.Text = "Contraseña";
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(136, 277);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenna.TabIndex = 20;
            // 
            // lblConfirmarContrasenna
            // 
            this.lblConfirmarContrasenna.AutoSize = true;
            this.lblConfirmarContrasenna.Location = new System.Drawing.Point(13, 316);
            this.lblConfirmarContrasenna.Name = "lblConfirmarContrasenna";
            this.lblConfirmarContrasenna.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmarContrasenna.TabIndex = 5;
            this.lblConfirmarContrasenna.Text = "Confirmar contraseña";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(136, 219);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 19;
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(114, 100);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(56, 13);
            this.lblFotografia.TabIndex = 14;
            this.lblFotografia.Text = "Fotografía";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(136, 190);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 121);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // gpBxTipoUsuario
            // 
            this.gpBxTipoUsuario.Controls.Add(this.rdBtnOtro);
            this.gpBxTipoUsuario.Controls.Add(this.rdBtnDoctorEspecialista);
            this.gpBxTipoUsuario.Location = new System.Drawing.Point(71, 15);
            this.gpBxTipoUsuario.Name = "gpBxTipoUsuario";
            this.gpBxTipoUsuario.Size = new System.Drawing.Size(208, 67);
            this.gpBxTipoUsuario.TabIndex = 26;
            this.gpBxTipoUsuario.TabStop = false;
            // 
            // rdBtnOtro
            // 
            this.rdBtnOtro.AutoSize = true;
            this.rdBtnOtro.Location = new System.Drawing.Point(19, 38);
            this.rdBtnOtro.Name = "rdBtnOtro";
            this.rdBtnOtro.Size = new System.Drawing.Size(184, 17);
            this.rdBtnOtro.TabIndex = 1;
            this.rdBtnOtro.TabStop = true;
            this.rdBtnOtro.Text = "Otro(Recepcionista/Vendedor/...)";
            this.rdBtnOtro.UseVisualStyleBackColor = true;
            this.rdBtnOtro.CheckedChanged += new System.EventHandler(this.rdBtnOtro_CheckedChanged);
            // 
            // rdBtnDoctorEspecialista
            // 
            this.rdBtnDoctorEspecialista.AutoSize = true;
            this.rdBtnDoctorEspecialista.Location = new System.Drawing.Point(19, 19);
            this.rdBtnDoctorEspecialista.Name = "rdBtnDoctorEspecialista";
            this.rdBtnDoctorEspecialista.Size = new System.Drawing.Size(116, 17);
            this.rdBtnDoctorEspecialista.TabIndex = 0;
            this.rdBtnDoctorEspecialista.TabStop = true;
            this.rdBtnDoctorEspecialista.Text = "Doctor Especialista";
            this.rdBtnDoctorEspecialista.UseVisualStyleBackColor = true;
            this.rdBtnDoctorEspecialista.CheckedChanged += new System.EventHandler(this.rdBtnDoctorEspecialista_CheckedChanged);
            // 
            // sptCAdministracion
            // 
            this.sptCAdministracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sptCAdministracion.Location = new System.Drawing.Point(12, 73);
            this.sptCAdministracion.Name = "sptCAdministracion";
            // 
            // sptCAdministracion.Panel1
            // 
            this.sptCAdministracion.Panel1.Controls.Add(this.gpBxTipoUsuario);
            this.sptCAdministracion.Panel1.Controls.Add(this.pnlCrearDatosUsuario);
            // 
            // sptCAdministracion.Panel2
            // 
            this.sptCAdministracion.Panel2.Controls.Add(this.dgvUsuarios);
            this.sptCAdministracion.Size = new System.Drawing.Size(852, 454);
            this.sptCAdministracion.SplitterDistance = 379;
            this.sptCAdministracion.TabIndex = 30;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(465, 450);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Location = new System.Drawing.Point(13, 257);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(54, 13);
            this.lblTipoPerfil.TabIndex = 29;
            this.lblTipoPerfil.Text = "Tipo Perfil";
            // 
            // cmbTipoPerfil
            // 
            this.cmbTipoPerfil.FormattingEnabled = true;
            this.cmbTipoPerfil.Location = new System.Drawing.Point(137, 249);
            this.cmbTipoPerfil.Name = "cmbTipoPerfil";
            this.cmbTipoPerfil.Size = new System.Drawing.Size(98, 21);
            this.cmbTipoPerfil.TabIndex = 30;
            // 
            // frmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 539);
            this.Controls.Add(this.sptCAdministracion);
            this.Controls.Add(this.msMenuAdministración);
            this.Name = "frmAdministracion";
            this.Text = "Administración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuAdministración.ResumeLayout(false);
            this.msMenuAdministración.PerformLayout();
            this.pnlCrearDatosUsuario.ResumeLayout(false);
            this.pnlCrearDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.gpBxTipoUsuario.ResumeLayout(false);
            this.gpBxTipoUsuario.PerformLayout();
            this.sptCAdministracion.Panel1.ResumeLayout(false);
            this.sptCAdministracion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptCAdministracion)).EndInit();
            this.sptCAdministracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMenuAdministración;
        private System.Windows.Forms.ToolStripButton toolStripBtnLeer;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.Panel pnlCrearDatosUsuario;
        private System.Windows.Forms.TextBox txtFotografia;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBuscarDocEspecialista;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContrasenna;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblConfirmarContrasenna;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpBxTipoUsuario;
        private System.Windows.Forms.RadioButton rdBtnOtro;
        private System.Windows.Forms.RadioButton rdBtnDoctorEspecialista;
        private System.Windows.Forms.SplitContainer sptCAdministracion;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.ComboBox cmbTipoPerfil;
    }
}