namespace UTN.Winforms.Apolo.Layers.UI.Maintenance
{
    partial class frmMantenimientoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoPaciente));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.llblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chBoxMedicamentos = new System.Windows.Forms.CheckBox();
            this.chBxAlcoholTabaco = new System.Windows.Forms.CheckBox();
            this.chBxEjercicioFisico = new System.Windows.Forms.CheckBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.mkdtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.pbxFotografia = new System.Windows.Forms.PictureBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.grpBxGenero = new System.Windows.Forms.GroupBox();
            this.rdBtnOtro = new System.Windows.Forms.RadioButton();
            this.rdBtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdBtnFemenino = new System.Windows.Forms.RadioButton();
            this.mkdtxtIdentificación = new System.Windows.Forms.MaskedTextBox();
            this.dtpkrFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.lblCalidades = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opnFlDlogFotografia = new System.Windows.Forms.OpenFileDialog();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.grpBxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
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
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(813, 75);
            this.tspDoctorEspecialista.TabIndex = 1;
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
            this.toolStripBtnSalir.Click += new System.EventHandler(this.toolStripBtnSalir_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlPaciente);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPacientes);
            this.splitContainer1.Size = new System.Drawing.Size(813, 565);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaciente.Controls.Add(this.btnCancelar);
            this.pnlPaciente.Controls.Add(this.btnAceptar);
            this.pnlPaciente.Controls.Add(this.txtApellidos);
            this.pnlPaciente.Controls.Add(this.txtNombre);
            this.pnlPaciente.Controls.Add(this.llblApellidos);
            this.pnlPaciente.Controls.Add(this.lblNombre);
            this.pnlPaciente.Controls.Add(this.chBoxMedicamentos);
            this.pnlPaciente.Controls.Add(this.chBxAlcoholTabaco);
            this.pnlPaciente.Controls.Add(this.chBxEjercicioFisico);
            this.pnlPaciente.Controls.Add(this.txtPeso);
            this.pnlPaciente.Controls.Add(this.txtAltura);
            this.pnlPaciente.Controls.Add(this.lblPeso);
            this.pnlPaciente.Controls.Add(this.lblAltura);
            this.pnlPaciente.Controls.Add(this.mkdtxtTelefono);
            this.pnlPaciente.Controls.Add(this.txtCorreoElectronico);
            this.pnlPaciente.Controls.Add(this.lblCorreoElectronico);
            this.pnlPaciente.Controls.Add(this.pbxFotografia);
            this.pnlPaciente.Controls.Add(this.txtDireccion);
            this.pnlPaciente.Controls.Add(this.grpBxGenero);
            this.pnlPaciente.Controls.Add(this.mkdtxtIdentificación);
            this.pnlPaciente.Controls.Add(this.dtpkrFechaNacimiento);
            this.pnlPaciente.Controls.Add(this.lblIdentificacion);
            this.pnlPaciente.Controls.Add(this.lblFotografia);
            this.pnlPaciente.Controls.Add(this.lblCalidades);
            this.pnlPaciente.Controls.Add(this.lblTelefono);
            this.pnlPaciente.Controls.Add(this.lblFechaNacimiento);
            this.pnlPaciente.Controls.Add(this.lblDireccion);
            this.pnlPaciente.Controls.Add(this.lblGenero);
            this.pnlPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaciente.Location = new System.Drawing.Point(0, 0);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(386, 565);
            this.pnlPaciente.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_cancel_black_48dp1;
            this.btnCancelar.Location = new System.Drawing.Point(190, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 59);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_done_outline_black_48dp;
            this.btnAceptar.Location = new System.Drawing.Point(82, 494);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 58);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(135, 168);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // llblApellidos
            // 
            this.llblApellidos.AutoSize = true;
            this.llblApellidos.Location = new System.Drawing.Point(25, 168);
            this.llblApellidos.Name = "llblApellidos";
            this.llblApellidos.Size = new System.Drawing.Size(49, 13);
            this.llblApellidos.TabIndex = 27;
            this.llblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 145);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // chBoxMedicamentos
            // 
            this.chBoxMedicamentos.AutoSize = true;
            this.chBoxMedicamentos.Location = new System.Drawing.Point(135, 238);
            this.chBoxMedicamentos.Name = "chBoxMedicamentos";
            this.chBoxMedicamentos.Size = new System.Drawing.Size(95, 17);
            this.chBoxMedicamentos.TabIndex = 25;
            this.chBoxMedicamentos.Text = "Medicamentos";
            this.chBoxMedicamentos.UseVisualStyleBackColor = true;
            // 
            // chBxAlcoholTabaco
            // 
            this.chBxAlcoholTabaco.AutoSize = true;
            this.chBxAlcoholTabaco.Location = new System.Drawing.Point(135, 217);
            this.chBxAlcoholTabaco.Name = "chBxAlcoholTabaco";
            this.chBxAlcoholTabaco.Size = new System.Drawing.Size(103, 17);
            this.chBxAlcoholTabaco.TabIndex = 24;
            this.chBxAlcoholTabaco.Text = "Alcohol/Tabaco";
            this.chBxAlcoholTabaco.UseVisualStyleBackColor = true;
            // 
            // chBxEjercicioFisico
            // 
            this.chBxEjercicioFisico.AutoSize = true;
            this.chBxEjercicioFisico.Location = new System.Drawing.Point(135, 194);
            this.chBxEjercicioFisico.Name = "chBxEjercicioFisico";
            this.chBxEjercicioFisico.Size = new System.Drawing.Size(98, 17);
            this.chBxEjercicioFisico.TabIndex = 23;
            this.chBxEjercicioFisico.Text = "Ejercicio Físico";
            this.chBxEjercicioFisico.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(305, 218);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(38, 20);
            this.txtPeso.TabIndex = 22;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(305, 191);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(38, 20);
            this.txtAltura.TabIndex = 21;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(251, 220);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(55, 13);
            this.lblPeso.TabIndex = 19;
            this.lblPeso.Text = "Peso( kg )";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(251, 194);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(54, 13);
            this.lblAltura.TabIndex = 18;
            this.lblAltura.Text = "Altura( m )";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mkdtxtTelefono
            // 
            this.mkdtxtTelefono.Location = new System.Drawing.Point(135, 412);
            this.mkdtxtTelefono.Mask = "0000-0000";
            this.mkdtxtTelefono.Name = "mkdtxtTelefono";
            this.mkdtxtTelefono.Size = new System.Drawing.Size(200, 20);
            this.mkdtxtTelefono.TabIndex = 16;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(135, 386);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(200, 20);
            this.txtCorreoElectronico.TabIndex = 15;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(25, 393);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(93, 13);
            this.lblCorreoElectronico.TabIndex = 14;
            this.lblCorreoElectronico.Text = "Correo electrónico";
            // 
            // pbxFotografia
            // 
            this.pbxFotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFotografia.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_add_photo_alternate_black_48dp;
            this.pbxFotografia.Location = new System.Drawing.Point(143, 12);
            this.pbxFotografia.Name = "pbxFotografia";
            this.pbxFotografia.Size = new System.Drawing.Size(83, 85);
            this.pbxFotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFotografia.TabIndex = 13;
            this.pbxFotografia.TabStop = false;
            this.pbxFotografia.Click += new System.EventHandler(this.pbxFotografia_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(135, 438);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 46);
            this.txtDireccion.TabIndex = 11;
            // 
            // grpBxGenero
            // 
            this.grpBxGenero.Controls.Add(this.rdBtnOtro);
            this.grpBxGenero.Controls.Add(this.rdBtnMasculino);
            this.grpBxGenero.Controls.Add(this.rdBtnFemenino);
            this.grpBxGenero.Location = new System.Drawing.Point(135, 293);
            this.grpBxGenero.Name = "grpBxGenero";
            this.grpBxGenero.Size = new System.Drawing.Size(98, 90);
            this.grpBxGenero.TabIndex = 10;
            this.grpBxGenero.TabStop = false;
            // 
            // rdBtnOtro
            // 
            this.rdBtnOtro.AutoSize = true;
            this.rdBtnOtro.Location = new System.Drawing.Point(18, 62);
            this.rdBtnOtro.Name = "rdBtnOtro";
            this.rdBtnOtro.Size = new System.Drawing.Size(45, 17);
            this.rdBtnOtro.TabIndex = 2;
            this.rdBtnOtro.TabStop = true;
            this.rdBtnOtro.Text = "Otro";
            this.rdBtnOtro.UseVisualStyleBackColor = true;
            // 
            // rdBtnMasculino
            // 
            this.rdBtnMasculino.AutoSize = true;
            this.rdBtnMasculino.Location = new System.Drawing.Point(18, 39);
            this.rdBtnMasculino.Name = "rdBtnMasculino";
            this.rdBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasculino.TabIndex = 1;
            this.rdBtnMasculino.TabStop = true;
            this.rdBtnMasculino.Text = "Masculino";
            this.rdBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemenino
            // 
            this.rdBtnFemenino.AutoSize = true;
            this.rdBtnFemenino.Location = new System.Drawing.Point(18, 16);
            this.rdBtnFemenino.Name = "rdBtnFemenino";
            this.rdBtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdBtnFemenino.TabIndex = 0;
            this.rdBtnFemenino.TabStop = true;
            this.rdBtnFemenino.Text = "Femenino";
            this.rdBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // mkdtxtIdentificación
            // 
            this.mkdtxtIdentificación.Location = new System.Drawing.Point(135, 116);
            this.mkdtxtIdentificación.Mask = "00000000000000";
            this.mkdtxtIdentificación.Name = "mkdtxtIdentificación";
            this.mkdtxtIdentificación.Size = new System.Drawing.Size(100, 20);
            this.mkdtxtIdentificación.TabIndex = 1;
            this.mkdtxtIdentificación.ValidatingType = typeof(int);
            this.mkdtxtIdentificación.Click += new System.EventHandler(this.mkdtxtIdentificación_Click);
            // 
            // dtpkrFechaNacimiento
            // 
            this.dtpkrFechaNacimiento.Location = new System.Drawing.Point(135, 267);
            this.dtpkrFechaNacimiento.Name = "dtpkrFechaNacimiento";
            this.dtpkrFechaNacimiento.Size = new System.Drawing.Size(198, 20);
            this.dtpkrFechaNacimiento.TabIndex = 7;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(25, 119);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lblFotografia
            // 
            this.lblFotografia.AutoSize = true;
            this.lblFotografia.Location = new System.Drawing.Point(159, 100);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(56, 13);
            this.lblFotografia.TabIndex = 6;
            this.lblFotografia.Text = "Fotografía";
            // 
            // lblCalidades
            // 
            this.lblCalidades.AutoSize = true;
            this.lblCalidades.Location = new System.Drawing.Point(25, 194);
            this.lblCalidades.Name = "lblCalidades";
            this.lblCalidades.Size = new System.Drawing.Size(53, 13);
            this.lblCalidades.TabIndex = 1;
            this.lblCalidades.Text = "Calidades";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 419);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Télefono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(25, 267);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 441);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(27, 293);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Género";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.Apellid,
            this.fotografia,
            this.fechaNacimiento,
            this.genero,
            this.email,
            this.telefono,
            this.direccion});
            this.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(423, 565);
            this.dgvPacientes.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "idPaciente";
            this.id.HeaderText = "Identificación";
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
            // Apellid
            // 
            this.Apellid.DataPropertyName = "Apellidos";
            this.Apellid.HeaderText = "Apellidos";
            this.Apellid.Name = "Apellid";
            this.Apellid.ReadOnly = true;
            // 
            // fotografia
            // 
            this.fotografia.DataPropertyName = "Fotografia";
            this.fotografia.HeaderText = "Fotografía";
            this.fotografia.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.fotografia.Name = "fotografia";
            this.fotografia.ReadOnly = true;
            this.fotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "Genero";
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Correo Electrónico";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // opnFlDlogFotografia
            // 
            this.opnFlDlogFotografia.FileName = "objectopnFlDlogFotografia";
            // 
            // frmMantenimientoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmMantenimientoPaciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.frmMantenimientoPaciente_Load);
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlPaciente.ResumeLayout(false);
            this.pnlPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).EndInit();
            this.grpBxGenero.ResumeLayout(false);
            this.grpBxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCalidades;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Panel pnlPaciente;
        private System.Windows.Forms.DateTimePicker dtpkrFechaNacimiento;
        private System.Windows.Forms.ToolStripButton toolStripBtnCrear;
        private System.Windows.Forms.MaskedTextBox mkdtxtIdentificación;
        private System.Windows.Forms.ToolStripButton toolStripBtnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripBtnBorrar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.GroupBox grpBxGenero;
        private System.Windows.Forms.OpenFileDialog opnFlDlogFotografia;
        private System.Windows.Forms.RadioButton rdBtnOtro;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.RadioButton rdBtnFemenino;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.CheckBox chBxEjercicioFisico;
        private System.Windows.Forms.CheckBox chBxAlcoholTabaco;
        private System.Windows.Forms.CheckBox chBoxMedicamentos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label llblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MaskedTextBox mkdtxtTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellid;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}