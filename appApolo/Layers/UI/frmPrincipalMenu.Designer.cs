namespace UTN.Winforms.Apolo
{
    partial class frmPrincipalMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnReportes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMantenimiento, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdministracion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnProcesos, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 394);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReportes.Enabled = false;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_analytics_black_48dp2;
            this.btnReportes.Location = new System.Drawing.Point(3, 200);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(393, 191);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMantenimiento.Enabled = false;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_edit_black_48dp;
            this.btnMantenimiento.Location = new System.Drawing.Point(3, 3);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(393, 191);
            this.btnMantenimiento.TabIndex = 0;
            this.btnMantenimiento.Text = "Mantenimientos";
            this.btnMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProcesos.Enabled = false;
            this.btnProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_miscellaneous_services_black_48dp;
            this.btnProcesos.Location = new System.Drawing.Point(402, 3);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(393, 191);
            this.btnProcesos.TabIndex = 1;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcesos.UseVisualStyleBackColor = false;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdministracion.Enabled = false;
            this.btnAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_lock_black_48dp1;
            this.btnAdministracion.Location = new System.Drawing.Point(402, 200);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(393, 191);
            this.btnAdministracion.TabIndex = 3;
            this.btnAdministracion.Text = "Administración";
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.Location = new System.Drawing.Point(352, 399);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(96, 46);
            this.btnCambiarUsuario.TabIndex = 2;
            this.btnCambiarUsuario.Text = "Cambiar Usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_help_black_18dp1;
            this.btnAcercaDe.Location = new System.Drawing.Point(722, 399);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 46);
            this.btnAcercaDe.TabIndex = 4;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_login_black_48dp;
            this.btnSalir.Location = new System.Drawing.Point(5, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 43);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipalMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmPrincipalMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnCambiarUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
    }
}