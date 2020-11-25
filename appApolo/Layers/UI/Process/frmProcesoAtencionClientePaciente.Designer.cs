namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    partial class frmProcesoAtencionClientePaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoAtencionClientePaciente));
            this.tspDoctorEspecialista = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnFacturar = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.sptContainer = new System.Windows.Forms.SplitContainer();
            this.grpBxFacturacion = new System.Windows.Forms.GroupBox();
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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtReferenciaMedica = new System.Windows.Forms.TextBox();
            this.lblIdentificacionCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.LblNoTarjeta = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.txtIdentificacionCliente = new System.Windows.Forms.TextBox();
            this.lblTipoTarjeta = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.grpBxDetalle = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
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
            this.sptContainer.Panel2.Controls.Add(this.textBox3);
            this.sptContainer.Panel2.Controls.Add(this.textBox2);
            this.sptContainer.Panel2.Controls.Add(this.textBox1);
            this.sptContainer.Panel2.Controls.Add(this.lblTotal);
            this.sptContainer.Panel2.Controls.Add(this.lblImpuesto);
            this.sptContainer.Panel2.Controls.Add(this.lblSubtotal);
            this.sptContainer.Panel2.Controls.Add(this.grpBxDetalle);
            this.sptContainer.Size = new System.Drawing.Size(994, 375);
            this.sptContainer.SplitterDistance = 327;
            this.sptContainer.TabIndex = 4;
            // 
            // grpBxFacturacion
            // 
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
            this.grpBxFacturacion.Controls.Add(this.lblNombreCliente);
            this.grpBxFacturacion.Controls.Add(this.txtReferenciaMedica);
            this.grpBxFacturacion.Controls.Add(this.lblIdentificacionCliente);
            this.grpBxFacturacion.Controls.Add(this.txtNombreCliente);
            this.grpBxFacturacion.Controls.Add(this.lblNumeroFactura);
            this.grpBxFacturacion.Controls.Add(this.LblNoTarjeta);
            this.grpBxFacturacion.Controls.Add(this.txtNoFactura);
            this.grpBxFacturacion.Controls.Add(this.txtIdentificacionCliente);
            this.grpBxFacturacion.Controls.Add(this.lblTipoTarjeta);
            this.grpBxFacturacion.Controls.Add(this.btnBuscarCliente);
            this.grpBxFacturacion.Location = new System.Drawing.Point(3, 3);
            this.grpBxFacturacion.Name = "grpBxFacturacion";
            this.grpBxFacturacion.Size = new System.Drawing.Size(286, 369);
            this.grpBxFacturacion.TabIndex = 31;
            this.grpBxFacturacion.TabStop = false;
            this.grpBxFacturacion.Text = "Facturación";
            // 
            // mskNoTarjeta
            // 
            this.mskNoTarjeta.Location = new System.Drawing.Point(133, 180);
            this.mskNoTarjeta.Mask = "0000-0000-0000-0000";
            this.mskNoTarjeta.Name = "mskNoTarjeta";
            this.mskNoTarjeta.Size = new System.Drawing.Size(121, 20);
            this.mskNoTarjeta.TabIndex = 42;
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(133, 153);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTarjeta.TabIndex = 41;
            // 
            // btnBuscarExamen
            // 
            this.btnBuscarExamen.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.btnBuscarExamen.Location = new System.Drawing.Point(237, 288);
            this.btnBuscarExamen.Name = "btnBuscarExamen";
            this.btnBuscarExamen.Size = new System.Drawing.Size(42, 40);
            this.btnBuscarExamen.TabIndex = 40;
            this.btnBuscarExamen.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(133, 315);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // txtCodigoExamen
            // 
            this.txtCodigoExamen.Enabled = false;
            this.txtCodigoExamen.Location = new System.Drawing.Point(133, 289);
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
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(18, 80);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre Cliente";
            // 
            // txtReferenciaMedica
            // 
            this.txtReferenciaMedica.Location = new System.Drawing.Point(133, 260);
            this.txtReferenciaMedica.Name = "txtReferenciaMedica";
            this.txtReferenciaMedica.Size = new System.Drawing.Size(100, 20);
            this.txtReferenciaMedica.TabIndex = 0;
            // 
            // lblIdentificacionCliente
            // 
            this.lblIdentificacionCliente.AutoSize = true;
            this.lblIdentificacionCliente.Location = new System.Drawing.Point(18, 54);
            this.lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            this.lblIdentificacionCliente.Size = new System.Drawing.Size(105, 13);
            this.lblIdentificacionCliente.TabIndex = 6;
            this.lblIdentificacionCliente.Text = "Identificación Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(131, 77);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 8;
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
            this.txtNoFactura.Location = new System.Drawing.Point(131, 22);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNoFactura.TabIndex = 28;
            // 
            // txtIdentificacionCliente
            // 
            this.txtIdentificacionCliente.Enabled = false;
            this.txtIdentificacionCliente.Location = new System.Drawing.Point(131, 51);
            this.txtIdentificacionCliente.Name = "txtIdentificacionCliente";
            this.txtIdentificacionCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacionCliente.TabIndex = 9;
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
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::UTN.Winforms.Apolo.Properties.Resources.round_person_search_black_48dp;
            this.btnBuscarCliente.Location = new System.Drawing.Point(237, 51);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(42, 40);
            this.btnBuscarCliente.TabIndex = 27;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(552, 319);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(552, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(552, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(484, 322);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(484, 293);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(50, 13);
            this.lblImpuesto.TabIndex = 2;
            this.lblImpuesto.Text = "Impuesto";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(484, 270);
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
            this.grpBxDetalle.Size = new System.Drawing.Size(655, 251);
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
            this.no,
            this.codExamen,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.total});
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(3, 16);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(649, 232);
            this.dgvDetalle.TabIndex = 0;
            // 
            // no
            // 
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // codExamen
            // 
            this.codExamen.HeaderText = "Código Examen";
            this.codExamen.Name = "codExamen";
            this.codExamen.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
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
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(133, 343);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 44;
            // 
            // frmProcesoAtencionClientePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.sptContainer);
            this.Controls.Add(this.tspDoctorEspecialista);
            this.Name = "frmProcesoAtencionClientePaciente";
            this.Text = "Atención Cliente/Paciente";
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
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtReferenciaMedica;
        private System.Windows.Forms.Label lblIdentificacionCliente;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label LblNoTarjeta;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.TextBox txtIdentificacionCliente;
        private System.Windows.Forms.Label lblTipoTarjeta;
        private System.Windows.Forms.Button btnBuscarCliente;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.MaskedTextBox mskNoTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn codExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}