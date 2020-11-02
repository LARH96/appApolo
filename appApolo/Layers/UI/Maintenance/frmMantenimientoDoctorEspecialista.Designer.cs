namespace UTN.Winforms.Apolo.UI
{
    partial class frmMantenimientoDoctorOEspecialista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoDoctorOEspecialista));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLeer = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.llblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chBoxMedicamentos = new System.Windows.Forms.CheckBox();
            this.chBxHumoTabaco = new System.Windows.Forms.CheckBox();
            this.chBxEjercicioFisico = new System.Windows.Forms.CheckBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
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
            this.lblICodigoEspecialista = new System.Windows.Forms.Label();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.lblCalidades = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dgvDoctorEspecialista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografia = new System.Windows.Forms.DataGridViewImageColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotografia)).BeginInit();
            this.grpBxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorEspecialista)).BeginInit();
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
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(800, 75);
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
            this.splitContainer1.Panel1.Controls.Add(this.pnlPaciente);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDoctorEspecialista);
            this.splitContainer1.Size = new System.Drawing.Size(800, 516);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 3;
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaciente.Controls.Add(this.txtApellidos);
            this.pnlPaciente.Controls.Add(this.textBox1);
            this.pnlPaciente.Controls.Add(this.llblApellidos);
            this.pnlPaciente.Controls.Add(this.lblNombre);
            this.pnlPaciente.Controls.Add(this.chBoxMedicamentos);
            this.pnlPaciente.Controls.Add(this.chBxHumoTabaco);
            this.pnlPaciente.Controls.Add(this.chBxEjercicioFisico);
            this.pnlPaciente.Controls.Add(this.txtPeso);
            this.pnlPaciente.Controls.Add(this.txtAltura);
            this.pnlPaciente.Controls.Add(this.txtEdad);
            this.pnlPaciente.Controls.Add(this.lblPeso);
            this.pnlPaciente.Controls.Add(this.lblAltura);
            this.pnlPaciente.Controls.Add(this.lblEdad);
            this.pnlPaciente.Controls.Add(this.mkdtxtTelefono);
            this.pnlPaciente.Controls.Add(this.txtCorreoElectronico);
            this.pnlPaciente.Controls.Add(this.lblCorreoElectronico);
            this.pnlPaciente.Controls.Add(this.pbxFotografia);
            this.pnlPaciente.Controls.Add(this.txtDireccion);
            this.pnlPaciente.Controls.Add(this.grpBxGenero);
            this.pnlPaciente.Controls.Add(this.mkdtxtIdentificación);
            this.pnlPaciente.Controls.Add(this.dtpkrFechaNacimiento);
            this.pnlPaciente.Controls.Add(this.lblICodigoEspecialista);
            this.pnlPaciente.Controls.Add(this.lblFotografia);
            this.pnlPaciente.Controls.Add(this.lblCalidades);
            this.pnlPaciente.Controls.Add(this.lblTelefono);
            this.pnlPaciente.Controls.Add(this.lblFechaNacimiento);
            this.pnlPaciente.Controls.Add(this.lblDireccion);
            this.pnlPaciente.Controls.Add(this.lblGenero);
            this.pnlPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaciente.Location = new System.Drawing.Point(0, 0);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(379, 516);
            this.pnlPaciente.TabIndex = 7;
            this.pnlPaciente.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaciente_Paint);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(132, 180);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            // 
            // llblApellidos
            // 
            this.llblApellidos.AutoSize = true;
            this.llblApellidos.Location = new System.Drawing.Point(23, 177);
            this.llblApellidos.Name = "llblApellidos";
            this.llblApellidos.Size = new System.Drawing.Size(49, 13);
            this.llblApellidos.TabIndex = 36;
            this.llblApellidos.Text = "Apellidos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 151);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 35;
            this.lblNombre.Text = "Nombre";
            // 
            // chBoxMedicamentos
            // 
            this.chBoxMedicamentos.AutoSize = true;
            this.chBoxMedicamentos.Location = new System.Drawing.Point(132, 255);
            this.chBoxMedicamentos.Name = "chBoxMedicamentos";
            this.chBoxMedicamentos.Size = new System.Drawing.Size(95, 17);
            this.chBoxMedicamentos.TabIndex = 34;
            this.chBoxMedicamentos.Text = "Medicamentos";
            this.chBoxMedicamentos.UseVisualStyleBackColor = true;
            // 
            // chBxHumoTabaco
            // 
            this.chBxHumoTabaco.AutoSize = true;
            this.chBxHumoTabaco.Location = new System.Drawing.Point(132, 234);
            this.chBxHumoTabaco.Name = "chBxHumoTabaco";
            this.chBxHumoTabaco.Size = new System.Drawing.Size(96, 17);
            this.chBxHumoTabaco.TabIndex = 33;
            this.chBxHumoTabaco.Text = "Humo/Tabaco";
            this.chBxHumoTabaco.UseVisualStyleBackColor = true;
            // 
            // chBxEjercicioFisico
            // 
            this.chBxEjercicioFisico.AutoSize = true;
            this.chBxEjercicioFisico.Location = new System.Drawing.Point(132, 211);
            this.chBxEjercicioFisico.Name = "chBxEjercicioFisico";
            this.chBxEjercicioFisico.Size = new System.Drawing.Size(98, 17);
            this.chBxEjercicioFisico.TabIndex = 32;
            this.chBxEjercicioFisico.Text = "Ejercicio Físico";
            this.chBxEjercicioFisico.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(292, 257);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(38, 20);
            this.txtPeso.TabIndex = 31;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(292, 230);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(38, 20);
            this.txtAltura.TabIndex = 30;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(292, 204);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(38, 20);
            this.txtEdad.TabIndex = 29;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(238, 259);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(55, 13);
            this.lblPeso.TabIndex = 28;
            this.lblPeso.Text = "Peso( kg )";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(238, 233);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(54, 13);
            this.lblAltura.TabIndex = 27;
            this.lblAltura.Text = "Altura( m )";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(238, 211);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 26;
            this.lblEdad.Text = "Edad";
            // 
            // mkdtxtTelefono
            // 
            this.mkdtxtTelefono.Location = new System.Drawing.Point(134, 423);
            this.mkdtxtTelefono.Name = "mkdtxtTelefono";
            this.mkdtxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.mkdtxtTelefono.TabIndex = 16;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(134, 396);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(200, 20);
            this.txtCorreoElectronico.TabIndex = 15;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(23, 403);
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
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(133, 451);
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
            this.grpBxGenero.Location = new System.Drawing.Point(135, 306);
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
            this.mkdtxtIdentificación.Location = new System.Drawing.Point(132, 122);
            this.mkdtxtIdentificación.Mask = "00000000000000";
            this.mkdtxtIdentificación.Name = "mkdtxtIdentificación";
            this.mkdtxtIdentificación.Size = new System.Drawing.Size(100, 20);
            this.mkdtxtIdentificación.TabIndex = 1;
            this.mkdtxtIdentificación.ValidatingType = typeof(int);
            // 
            // dtpkrFechaNacimiento
            // 
            this.dtpkrFechaNacimiento.Location = new System.Drawing.Point(132, 283);
            this.dtpkrFechaNacimiento.Name = "dtpkrFechaNacimiento";
            this.dtpkrFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpkrFechaNacimiento.TabIndex = 7;
            // 
            // lblICodigoEspecialista
            // 
            this.lblICodigoEspecialista.AutoSize = true;
            this.lblICodigoEspecialista.Location = new System.Drawing.Point(23, 125);
            this.lblICodigoEspecialista.Name = "lblICodigoEspecialista";
            this.lblICodigoEspecialista.Size = new System.Drawing.Size(99, 13);
            this.lblICodigoEspecialista.TabIndex = 0;
            this.lblICodigoEspecialista.Text = "Código Especialista";
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
            this.lblCalidades.Location = new System.Drawing.Point(23, 211);
            this.lblCalidades.Name = "lblCalidades";
            this.lblCalidades.Size = new System.Drawing.Size(53, 13);
            this.lblCalidades.TabIndex = 1;
            this.lblCalidades.Text = "Calidades";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 427);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Télefono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(23, 290);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 455);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(23, 314);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Género";
            // 
            // dgvDoctorEspecialista
            // 
            this.dgvDoctorEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fotografia,
            this.fechaNacimiento,
            this.genero,
            this.email,
            this.telefono,
            this.direccion});
            this.dgvDoctorEspecialista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.dgvDoctorEspecialista.Name = "dgvDoctorEspecialista";
            this.dgvDoctorEspecialista.Size = new System.Drawing.Size(417, 516);
            this.dgvDoctorEspecialista.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Código Especialista";
            this.id.Name = "id";
            // 
            // fotografia
            // 
            this.fotografia.HeaderText = "Fotografía";
            this.fotografia.Name = "fotografia";
            this.fotografia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fotografia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            // 
            // genero
            // 
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            // 
            // email
            // 
            this.email.HeaderText = "Correo Electrónico";
            this.email.Name = "email";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // frmMantenimientoDoctorOEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmMantenimientoDoctorOEspecialista";
            this.Text = "Doctor Especialista";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorEspecialista)).EndInit();
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
        private System.Windows.Forms.Panel pnlPaciente;
        private System.Windows.Forms.MaskedTextBox mkdtxtTelefono;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.PictureBox pbxFotografia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox grpBxGenero;
        private System.Windows.Forms.RadioButton rdBtnOtro;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.RadioButton rdBtnFemenino;
        private System.Windows.Forms.MaskedTextBox mkdtxtIdentificación;
        private System.Windows.Forms.DateTimePicker dtpkrFechaNacimiento;
        private System.Windows.Forms.Label lblICodigoEspecialista;
        private System.Windows.Forms.Label lblFotografia;
        private System.Windows.Forms.Label lblCalidades;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.CheckBox chBoxMedicamentos;
        private System.Windows.Forms.CheckBox chBxHumoTabaco;
        private System.Windows.Forms.CheckBox chBxEjercicioFisico;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DataGridView dgvDoctorEspecialista;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label llblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn fotografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}