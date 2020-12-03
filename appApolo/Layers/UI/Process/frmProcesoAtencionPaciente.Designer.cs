namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    partial class frmProcesoAtencionPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoAtencionPaciente));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnFacturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.sptContainer = new System.Windows.Forms.SplitContainer();
            this.grpBxFacturacion = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.mskNoTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.btnBuscarExamen = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigoExamen = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lbllblCodigoExamen = new System.Windows.Forms.Label();
            this.grpBxEntregaExamen = new System.Windows.Forms.GroupBox();
            this.rdbCorreoElectronico = new System.Windows.Forms.RadioButton();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.grpBxTipoPago = new System.Windows.Forms.GroupBox();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.lblReferenciaMedica = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtReferenciaMedica = new System.Windows.Forms.TextBox();
            this.lblIdentificacionPaciente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.LblNoTarjeta = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.txtIdentificacionPaciente = new System.Windows.Forms.TextBox();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpBxDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Secuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tspDoctorEspecialista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptContainer)).BeginInit();
            this.sptContainer.Panel1.SuspendLayout();
            this.sptContainer.Panel2.SuspendLayout();
            this.sptContainer.SuspendLayout();
            this.grpBxFacturacion.SuspendLayout();
            this.grpBxEntregaExamen.SuspendLayout();
            this.grpBxTipoPago.SuspendLayout();
            this.grpBxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // tspDoctorEspecialista
            // 
            this.tspDoctorEspecialista.AutoSize = false;
            this.tspDoctorEspecialista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNuevo,
            this.toolStripBtnFacturar,
            this.toolStripBtnSalir});
            this.tspDoctorEspecialista.Location = new System.Drawing.Point(0, 0);
            this.tspDoctorEspecialista.Name = "tspDoctorEspecialista";
            this.tspDoctorEspecialista.Size = new System.Drawing.Size(994, 75);
            this.tspDoctorEspecialista.TabIndex = 3;
            this.tspDoctorEspecialista.Text = "toolStrip1";
            // 
            // toolStripBtnNuevo
            // 
            this.toolStripBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNuevo.Image")));
            this.toolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            this.toolStripBtnNuevo.Size = new System.Drawing.Size(94, 72);
            this.toolStripBtnNuevo.Text = "Nueva Solicitud";
            this.toolStripBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnNuevo.Click += new System.EventHandler(this.toolStripBtnNuevo_Click);
            // 
            // toolStripBtnFacturar
            // 
            this.toolStripBtnFacturar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_receipt_long_black_48dp;
            this.toolStripBtnFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnFacturar.Name = "toolStripBtnFacturar";
            this.toolStripBtnFacturar.Size = new System.Drawing.Size(54, 72);
            this.toolStripBtnFacturar.Text = "Facturar";
            this.toolStripBtnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnFacturar.Click += new System.EventHandler(this.toolStripBtnFacturar_Click);
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
            // sptContainer
            // 
            this.sptContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptContainer.Location = new System.Drawing.Point(0, 75);
            this.sptContainer.Name = "sptContainer";
            // 
            // sptContainer.Panel1
            // 
            this.sptContainer.Panel1.Controls.Add(this.grpBxFacturacion);
            // 
            // sptContainer.Panel2
            // 
            this.sptContainer.Panel2.Controls.Add(this.txtTotal);
            this.sptContainer.Panel2.Controls.Add(this.txtImpuesto);
            this.sptContainer.Panel2.Controls.Add(this.txtSubTotal);
            this.sptContainer.Panel2.Controls.Add(this.lblTotal);
            this.sptContainer.Panel2.Controls.Add(this.lblImpuesto);
            this.sptContainer.Panel2.Controls.Add(this.lblSubtotal);
            this.sptContainer.Panel2.Controls.Add(this.grpBxDetalle);
            this.sptContainer.Size = new System.Drawing.Size(994, 398);
            this.sptContainer.SplitterDistance = 327;
            this.sptContainer.TabIndex = 4;
            // 
            // grpBxFacturacion
            // 
            this.grpBxFacturacion.Controls.Add(this.btnAgregar);
            this.grpBxFacturacion.Controls.Add(this.txtPrecio);
            this.grpBxFacturacion.Controls.Add(this.lblPrecio);
            this.grpBxFacturacion.Controls.Add(this.mskNoTarjeta);
            this.grpBxFacturacion.Controls.Add(this.cmbTipoTarjeta);
            this.grpBxFacturacion.Controls.Add(this.btnBuscarExamen);
            this.grpBxFacturacion.Controls.Add(this.txtDescripcion);
            this.grpBxFacturacion.Controls.Add(this.txtCodigoExamen);
            this.grpBxFacturacion.Controls.Add(this.lblDescripcion);
            this.grpBxFacturacion.Controls.Add(this.lbllblCodigoExamen);
            this.grpBxFacturacion.Controls.Add(this.grpBxEntregaExamen);
            this.grpBxFacturacion.Controls.Add(this.grpBxTipoPago);
            this.grpBxFacturacion.Controls.Add(this.lblReferenciaMedica);
            this.grpBxFacturacion.Controls.Add(this.lblNombrePaciente);
            this.grpBxFacturacion.Controls.Add(this.txtReferenciaMedica);
            this.grpBxFacturacion.Controls.Add(this.lblIdentificacionPaciente);
            this.grpBxFacturacion.Controls.Add(this.txtNombrePaciente);
            this.grpBxFacturacion.Controls.Add(this.lblNumeroFactura);
            this.grpBxFacturacion.Controls.Add(this.LblNoTarjeta);
            this.grpBxFacturacion.Controls.Add(this.txtNoFactura);
            this.grpBxFacturacion.Controls.Add(this.txtIdentificacionPaciente);
            this.grpBxFacturacion.Controls.Add(this.lblTipoTarjeta);
            this.grpBxFacturacion.Controls.Add(this.btnBuscarPaciente);
            this.grpBxFacturacion.Location = new System.Drawing.Point(3, 3);
            this.grpBxFacturacion.Name = "grpBxFacturacion";
            this.grpBxFacturacion.Size = new System.Drawing.Size(321, 414);
            this.grpBxFacturacion.TabIndex = 31;
            this.grpBxFacturacion.TabStop = false;
            this.grpBxFacturacion.Text = "Facturación";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_done_outline_black_48dp;
            this.btnAgregar.Location = new System.Drawing.Point(243, 340);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 46);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(139, 343);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 44;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 346);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 43;
            this.lblPrecio.Text = "Precio";
            // 
            // mskNoTarjeta
            // 
            this.mskNoTarjeta.Enabled = false;
            this.mskNoTarjeta.Location = new System.Drawing.Point(139, 180);
            this.mskNoTarjeta.Mask = "0000-0000-0000-0000";
            this.mskNoTarjeta.Name = "mskNoTarjeta";
            this.mskNoTarjeta.Size = new System.Drawing.Size(121, 20);
            this.mskNoTarjeta.TabIndex = 42;
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.Enabled = false;
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(139, 153);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTarjeta.TabIndex = 41;
            // 
            // btnBuscarExamen
            // 
            this.btnBuscarExamen.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_search_black_48dp;
            this.btnBuscarExamen.Location = new System.Drawing.Point(243, 288);
            this.btnBuscarExamen.Name = "btnBuscarExamen";
            this.btnBuscarExamen.Size = new System.Drawing.Size(44, 47);
            this.btnBuscarExamen.TabIndex = 40;
            this.btnBuscarExamen.UseVisualStyleBackColor = true;
            this.btnBuscarExamen.Click += new System.EventHandler(this.btnBuscarExamen_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(139, 315);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // txtCodigoExamen
            // 
            this.txtCodigoExamen.Enabled = false;
            this.txtCodigoExamen.Location = new System.Drawing.Point(139, 289);
            this.txtCodigoExamen.Name = "txtCodigoExamen";
            this.txtCodigoExamen.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoExamen.TabIndex = 38;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 315);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lbllblCodigoExamen
            // 
            this.lbllblCodigoExamen.AutoSize = true;
            this.lbllblCodigoExamen.Location = new System.Drawing.Point(20, 288);
            this.lbllblCodigoExamen.Name = "lbllblCodigoExamen";
            this.lbllblCodigoExamen.Size = new System.Drawing.Size(81, 13);
            this.lbllblCodigoExamen.TabIndex = 36;
            this.lbllblCodigoExamen.Text = "Código Examen";
            // 
            // grpBxEntregaExamen
            // 
            this.grpBxEntregaExamen.Controls.Add(this.rdbCorreoElectronico);
            this.grpBxEntregaExamen.Controls.Add(this.rdbPresencial);
            this.grpBxEntregaExamen.Location = new System.Drawing.Point(23, 204);
            this.grpBxEntregaExamen.Name = "grpBxEntregaExamen";
            this.grpBxEntregaExamen.Size = new System.Drawing.Size(210, 47);
            this.grpBxEntregaExamen.TabIndex = 35;
            this.grpBxEntregaExamen.TabStop = false;
            this.grpBxEntregaExamen.Text = "Entrega Exámen";
            // 
            // rdbCorreoElectronico
            // 
            this.rdbCorreoElectronico.AutoSize = true;
            this.rdbCorreoElectronico.Location = new System.Drawing.Point(98, 19);
            this.rdbCorreoElectronico.Name = "rdbCorreoElectronico";
            this.rdbCorreoElectronico.Size = new System.Drawing.Size(112, 17);
            this.rdbCorreoElectronico.TabIndex = 1;
            this.rdbCorreoElectronico.TabStop = true;
            this.rdbCorreoElectronico.Text = "Correo Electrónico";
            this.rdbCorreoElectronico.UseVisualStyleBackColor = true;
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Location = new System.Drawing.Point(7, 19);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(74, 17);
            this.rdbPresencial.TabIndex = 0;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // grpBxTipoPago
            // 
            this.grpBxTipoPago.Controls.Add(this.rdbEfectivo);
            this.grpBxTipoPago.Controls.Add(this.rdbTarjeta);
            this.grpBxTipoPago.Location = new System.Drawing.Point(21, 103);
            this.grpBxTipoPago.Name = "grpBxTipoPago";
            this.grpBxTipoPago.Size = new System.Drawing.Size(212, 44);
            this.grpBxTipoPago.TabIndex = 34;
            this.grpBxTipoPago.TabStop = false;
            this.grpBxTipoPago.Text = "Tipo Pago";
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(30, 19);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 29;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            this.rdbEfectivo.CheckedChanged += new System.EventHandler(this.rdbEfectivo_CheckedChanged);
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(118, 19);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rdbTarjeta.TabIndex = 30;
            this.rdbTarjeta.TabStop = true;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            this.rdbTarjeta.CheckedChanged += new System.EventHandler(this.rdbTarjeta_CheckedChanged);
            // 
            // lblReferenciaMedica
            // 
            this.lblReferenciaMedica.AutoSize = true;
            this.lblReferenciaMedica.Location = new System.Drawing.Point(20, 263);
            this.lblReferenciaMedica.Name = "lblReferenciaMedica";
            this.lblReferenciaMedica.Size = new System.Drawing.Size(97, 13);
            this.lblReferenciaMedica.TabIndex = 1;
            this.lblReferenciaMedica.Text = "Referencia Médica";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(18, 80);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePaciente.TabIndex = 7;
            this.lblNombrePaciente.Text = "Nombre Paciente";
            // 
            // txtReferenciaMedica
            // 
            this.txtReferenciaMedica.Location = new System.Drawing.Point(139, 260);
            this.txtReferenciaMedica.Name = "txtReferenciaMedica";
            this.txtReferenciaMedica.Size = new System.Drawing.Size(100, 20);
            this.txtReferenciaMedica.TabIndex = 0;
            // 
            // lblIdentificacionPaciente
            // 
            this.lblIdentificacionPaciente.AutoSize = true;
            this.lblIdentificacionPaciente.Location = new System.Drawing.Point(18, 54);
            this.lblIdentificacionPaciente.Name = "lblIdentificacionPaciente";
            this.lblIdentificacionPaciente.Size = new System.Drawing.Size(115, 13);
            this.lblIdentificacionPaciente.TabIndex = 6;
            this.lblIdentificacionPaciente.Text = "Identificación Paciente";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Enabled = false;
            this.txtNombrePaciente.Location = new System.Drawing.Point(139, 77);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePaciente.TabIndex = 8;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(20, 25);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(63, 13);
            this.lblNumeroFactura.TabIndex = 2;
            this.lblNumeroFactura.Text = "No. Factura";
            // 
            // LblNoTarjeta
            // 
            this.LblNoTarjeta.AutoSize = true;
            this.LblNoTarjeta.Location = new System.Drawing.Point(20, 178);
            this.LblNoTarjeta.Name = "LblNoTarjeta";
            this.LblNoTarjeta.Size = new System.Drawing.Size(56, 13);
            this.LblNoTarjeta.TabIndex = 5;
            this.LblNoTarjeta.Text = "No. tarjeta";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Enabled = false;
            this.txtNoFactura.Location = new System.Drawing.Point(139, 22);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNoFactura.TabIndex = 28;
            // 
            // txtIdentificacionPaciente
            // 
            this.txtIdentificacionPaciente.Enabled = false;
            this.txtIdentificacionPaciente.Location = new System.Drawing.Point(139, 51);
            this.txtIdentificacionPaciente.Name = "txtIdentificacionPaciente";
            this.txtIdentificacionPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionPaciente.TabIndex = 9;
            // 
            // lblTipoTarjeta
            // 
            this.lblTipoTarjeta.AutoSize = true;
            this.lblTipoTarjeta.Location = new System.Drawing.Point(18, 156);
            this.lblTipoTarjeta.Name = "lblTipoTarjeta";
            this.lblTipoTarjeta.Size = new System.Drawing.Size(60, 13);
            this.lblTipoTarjeta.TabIndex = 4;
            this.lblTipoTarjeta.Text = "Tipo tarjeta";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.btnBuscarPaciente.Location = new System.Drawing.Point(245, 51);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(42, 46);
            this.btnBuscarPaciente.TabIndex = 27;
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(551, 357);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(551, 331);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 20);
            this.txtImpuesto.TabIndex = 5;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(551, 305);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(483, 360);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(483, 331);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(50, 13);
            this.lblImpuesto.TabIndex = 2;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(483, 308);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // grpBxDetalle
            // 
            this.grpBxDetalle.Controls.Add(this.dgvDetalle);
            this.grpBxDetalle.Location = new System.Drawing.Point(3, 3);
            this.grpBxDetalle.Name = "grpBxDetalle";
            this.grpBxDetalle.Size = new System.Drawing.Size(655, 296);
            this.grpBxDetalle.TabIndex = 0;
            this.grpBxDetalle.TabStop = false;
            this.grpBxDetalle.Text = "Detalle";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Secuencia,
            this.codExamen,
            this.descripcion,
            this.precio,
            this.impuesto,
            this.total});
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(649, 277);
            this.dgvDetalle.TabIndex = 0;
            // 
            // Secuencia
            // 
            this.Secuencia.DataPropertyName = "Secuencia";
            this.Secuencia.HeaderText = "No.";
            this.Secuencia.Name = "Secuencia";
            this.Secuencia.ReadOnly = true;
            // 
            // codExamen
            // 
            this.codExamen.DataPropertyName = "idExamen";
            this.codExamen.HeaderText = "Código Examen";
            this.codExamen.Name = "codExamen";
            this.codExamen.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "Costo";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // impuesto
            // 
            this.impuesto.HeaderText = "Impuesto";
            this.impuesto.Name = "impuesto";
            this.impuesto.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // frmProcesoAtencionPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 473);
            this.Controls.Add(this.sptContainer);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmProcesoAtencionPaciente";
            this.Text = "Atención Paciente";
            this.Load += new System.EventHandler(this.frmProcesoAtencionPaciente_Load);
            this.tspDoctorEspecialista.ResumeLayout(false);
            this.tspDoctorEspecialista.PerformLayout();
            this.sptContainer.Panel1.ResumeLayout(false);
            this.sptContainer.Panel2.ResumeLayout(false);
            this.sptContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptContainer)).EndInit();
            this.sptContainer.ResumeLayout(false);
            this.grpBxFacturacion.ResumeLayout(false);
            this.grpBxFacturacion.PerformLayout();
            this.grpBxEntregaExamen.ResumeLayout(false);
            this.grpBxEntregaExamen.PerformLayout();
            this.grpBxTipoPago.ResumeLayout(false);
            this.grpBxTipoPago.PerformLayout();
            this.grpBxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspDoctorEspecialista;
        private System.Windows.Forms.ToolStripButton toolStripBtnNuevo;
        private System.Windows.Forms.ToolStripButton toolStripBtnFacturar;
        private System.Windows.Forms.ToolStripButton toolStripBtnSalir;
        private System.Windows.Forms.SplitContainer sptContainer;
        private System.Windows.Forms.GroupBox grpBxFacturacion;
        private System.Windows.Forms.Label lblReferenciaMedica;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtReferenciaMedica;
        private System.Windows.Forms.Label lblIdentificacionPaciente;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label LblNoTarjeta;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.TextBox txtIdentificacionPaciente;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.GroupBox grpBxDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.GroupBox grpBxEntregaExamen;
        private System.Windows.Forms.RadioButton rdbCorreoElectronico;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.GroupBox grpBxTipoPago;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoExamen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lbllblCodigoExamen;
        private System.Windows.Forms.Button btnBuscarExamen;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.MaskedTextBox mskNoTarjeta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn codExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}