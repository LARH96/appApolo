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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracion));
            this.msMenuAdministración = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.pnlCrearDatosUsuario = new System.Windows.Forms.Panel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.llblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.msktxtIdentificación = new System.Windows.Forms.MaskedTextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.cmbTipoPerfil = new System.Windows.Forms.ComboBox();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.btnBuscarDocEspecialista = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtConfirmarContrasenna = new System.Windows.Forms.TextBox();
            this.lblContrasenna = new System.Windows.Forms.Label();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasenna = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.gpBxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rdBtnOtro = new System.Windows.Forms.RadioButton();
            this.rdBtnDoctorEspecialista = new System.Windows.Forms.RadioButton();
            this.sptCAdministracion = new System.Windows.Forms.SplitContainer();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.opnFlDlogFotografia = new System.Windows.Forms.OpenFileDialog();
            this.msMenuAdministración.SuspendLayout();
            this.pnlCrearDatosUsuario.SuspendLayout();
            this.gpBxTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptCAdministracion)).BeginInit();
            this.sptCAdministracion.Panel1.SuspendLayout();
            this.sptCAdministracion.Panel2.SuspendLayout();
            this.sptCAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuAdministración
            // 
            this.msMenuAdministración.AutoSize = false;
            this.msMenuAdministración.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.crearUsuarioToolStripMenuItem,
            this.toolStripBtnActualizar,
            this.toolStripBtnBorrar});
            this.msMenuAdministración.Location = new System.Drawing.Point(0, 0);
            this.msMenuAdministración.Name = "msMenuAdministración";
            this.msMenuAdministración.Size = new System.Drawing.Size(871, 70);
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
            this.toolStripBtnActualizar.Click += new System.EventHandler(this.toolStripBtnActualizar_Click);
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
            this.toolStripBtnBorrar.Click += new System.EventHandler(this.toolStripBtnBorrar_Click);
            // 
            // pnlCrearDatosUsuario
            // 
            this.pnlCrearDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrearDatosUsuario.Controls.Add(this.txtApellidos);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtNombre);
            this.pnlCrearDatosUsuario.Controls.Add(this.llblApellidos);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblNombre);
            this.pnlCrearDatosUsuario.Controls.Add(this.msktxtIdentificación);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblIdentificacion);
            this.pnlCrearDatosUsuario.Controls.Add(this.cmbTipoPerfil);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblTipoPerfil);
            this.pnlCrearDatosUsuario.Controls.Add(this.btnBuscarDocEspecialista);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtConfirmarContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.lblConfirmarContrasenna);
            this.pnlCrearDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.pnlCrearDatosUsuario.Location = new System.Drawing.Point(29, 85);
            this.pnlCrearDatosUsuario.Name = "pnlCrearDatosUsuario";
            this.pnlCrearDatosUsuario.Size = new System.Drawing.Size(293, 234);
            this.pnlCrearDatosUsuario.TabIndex = 29;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(140, 75);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 36;
            // 
            // llblApellidos
            // 
            this.llblApellidos.AutoSize = true;
            this.llblApellidos.Location = new System.Drawing.Point(17, 82);
            this.llblApellidos.Name = "llblApellidos";
            this.llblApellidos.Size = new System.Drawing.Size(49, 13);
            this.llblApellidos.TabIndex = 35;
            this.llblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre";
            // 
            // msktxtIdentificación
            // 
            this.msktxtIdentificación.Location = new System.Drawing.Point(140, 23);
            this.msktxtIdentificación.Mask = "00000000000000";
            this.msktxtIdentificación.Name = "msktxtIdentificación";
            this.msktxtIdentificación.Size = new System.Drawing.Size(100, 20);
            this.msktxtIdentificación.TabIndex = 33;
            this.msktxtIdentificación.ValidatingType = typeof(int);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(17, 26);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(10, 13);
            this.lblIdentificacion.TabIndex = 32;
            this.lblIdentificacion.Text = "-";
            // 
            // cmbTipoPerfil
            // 
            this.cmbTipoPerfil.FormattingEnabled = true;
            this.cmbTipoPerfil.Location = new System.Drawing.Point(141, 136);
            this.cmbTipoPerfil.Name = "cmbTipoPerfil";
            this.cmbTipoPerfil.Size = new System.Drawing.Size(98, 21);
            this.cmbTipoPerfil.TabIndex = 30;
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Location = new System.Drawing.Point(17, 144);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(54, 13);
            this.lblTipoPerfil.TabIndex = 29;
            this.lblTipoPerfil.Text = "Tipo Perfil";
            // 
            // btnBuscarDocEspecialista
            // 
            this.btnBuscarDocEspecialista.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.btnBuscarDocEspecialista.Location = new System.Drawing.Point(246, 3);
            this.btnBuscarDocEspecialista.Name = "btnBuscarDocEspecialista";
            this.btnBuscarDocEspecialista.Size = new System.Drawing.Size(42, 40);
            this.btnBuscarDocEspecialista.TabIndex = 26;
            this.btnBuscarDocEspecialista.UseVisualStyleBackColor = true;
            this.btnBuscarDocEspecialista.Click += new System.EventHandler(this.btnBuscarDocEspecialista_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(15, 113);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtConfirmarContrasenna
            // 
            this.txtConfirmarContrasenna.Location = new System.Drawing.Point(140, 196);
            this.txtConfirmarContrasenna.Name = "txtConfirmarContrasenna";
            this.txtConfirmarContrasenna.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarContrasenna.TabIndex = 21;
            // 
            // lblContrasenna
            // 
            this.lblContrasenna.AutoSize = true;
            this.lblContrasenna.Location = new System.Drawing.Point(17, 171);
            this.lblContrasenna.Name = "lblContrasenna";
            this.lblContrasenna.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenna.TabIndex = 4;
            this.lblContrasenna.Text = "Contraseña";
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(140, 164);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenna.TabIndex = 20;
            // 
            // lblConfirmarContrasenna
            // 
            this.lblConfirmarContrasenna.AutoSize = true;
            this.lblConfirmarContrasenna.Location = new System.Drawing.Point(17, 203);
            this.lblConfirmarContrasenna.Name = "lblConfirmarContrasenna";
            this.lblConfirmarContrasenna.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmarContrasenna.TabIndex = 5;
            this.lblConfirmarContrasenna.Text = "Confirmar contraseña";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(140, 106);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 19;
            // 
            // gpBxTipoUsuario
            // 
            this.gpBxTipoUsuario.Controls.Add(this.rdBtnOtro);
            this.gpBxTipoUsuario.Controls.Add(this.rdBtnDoctorEspecialista);
            this.gpBxTipoUsuario.Location = new System.Drawing.Point(71, 12);
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
            this.sptCAdministracion.Panel1.Controls.Add(this.btnCancelar);
            this.sptCAdministracion.Panel1.Controls.Add(this.gpBxTipoUsuario);
            this.sptCAdministracion.Panel1.Controls.Add(this.btnAceptar);
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
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellidos,
            this.fotografia,
            this.nombreUsuario,
            this.tipoPerfil});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(465, 450);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "IdUsuario";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "Apellidos";
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            // 
            // fotografia
            // 
            this.fotografia.DataPropertyName = "Fotografia";
            this.fotografia.HeaderText = "Fotografía";
            this.fotografia.Name = "fotografia";
            this.fotografia.ReadOnly = true;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.DataPropertyName = "Apellidos";
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // tipoPerfil
            // 
            this.tipoPerfil.DataPropertyName = "TipoPerfil";
            this.tipoPerfil.HeaderText = "Tipo del Perfil";
            this.tipoPerfil.Name = "tipoPerfil";
            this.tipoPerfil.ReadOnly = true;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_cancel_black_48dp1;
            this.btnCancelar.Location = new System.Drawing.Point(179, 334);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 59);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_done_outline_black_48dp;
            this.btnAceptar.Location = new System.Drawing.Point(71, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 58);
            this.btnAceptar.TabIndex = 32;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 527);
            this.Controls.Add(this.sptCAdministracion);
            this.Controls.Add(this.msMenuAdministración);
            this.Name = "frmAdministracion";
            this.Text = "Administración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministracion_Load);
            this.msMenuAdministración.ResumeLayout(false);
            this.msMenuAdministración.PerformLayout();
            this.pnlCrearDatosUsuario.ResumeLayout(false);
            this.pnlCrearDatosUsuario.PerformLayout();
            this.gpBxTipoUsuario.ResumeLayout(false);
            this.gpBxTipoUsuario.PerformLayout();
            this.sptCAdministracion.Panel1.ResumeLayout(false);
            this.sptCAdministracion.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sptCAdministracion)).EndInit();
            this.sptCAdministracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMenuAdministración;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.Panel pnlCrearDatosUsuario;
        private System.Windows.Forms.Button btnBuscarDocEspecialista;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContrasenna;
        private System.Windows.Forms.Label lblContrasenna;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblConfirmarContrasenna;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.GroupBox gpBxTipoUsuario;
        private System.Windows.Forms.RadioButton rdBtnOtro;
        private System.Windows.Forms.RadioButton rdBtnDoctorEspecialista;
        private System.Windows.Forms.SplitContainer sptCAdministracion;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.ComboBox cmbTipoPerfil;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label llblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox msktxtIdentificación;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.OpenFileDialog opnFlDlogFotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPerfil;
    }
}