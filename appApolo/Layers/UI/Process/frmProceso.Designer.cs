namespace UTN.Winforms.Apolo.Layers.UI.Process
{
    partial class frmProceso
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
            this.msMenuProceso = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciónDelPacienteclienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudioExámenLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaExámenLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaElectrónicaHaciendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuProceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuProceso
            // 
            this.msMenuProceso.AutoSize = false;
            this.msMenuProceso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.atenciónDelPacienteclienteToolStripMenuItem,
            this.estudioExámenLaboratorioToolStripMenuItem,
            this.entregaExámenLaboratorioToolStripMenuItem,
            this.facturaElectrónicaHaciendaToolStripMenuItem});
            this.msMenuProceso.Location = new System.Drawing.Point(0, 0);
            this.msMenuProceso.Name = "msMenuProceso";
            this.msMenuProceso.Size = new System.Drawing.Size(800, 70);
            this.msMenuProceso.TabIndex = 1;
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
            // atenciónDelPacienteclienteToolStripMenuItem
            // 
            this.atenciónDelPacienteclienteToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_medical_services_black_48dp1;
            this.atenciónDelPacienteclienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.atenciónDelPacienteclienteToolStripMenuItem.Name = "atenciónDelPacienteclienteToolStripMenuItem";
            this.atenciónDelPacienteclienteToolStripMenuItem.Size = new System.Drawing.Size(157, 66);
            this.atenciónDelPacienteclienteToolStripMenuItem.Text = "Atención Paciente/Cliente";
            this.atenciónDelPacienteclienteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.atenciónDelPacienteclienteToolStripMenuItem.Click += new System.EventHandler(this.atenciónDelPacienteclienteToolStripMenuItem_Click);
            // 
            // estudioExámenLaboratorioToolStripMenuItem
            // 
            this.estudioExámenLaboratorioToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_leaderboard_black_48dp;
            this.estudioExámenLaboratorioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.estudioExámenLaboratorioToolStripMenuItem.Name = "estudioExámenLaboratorioToolStripMenuItem";
            this.estudioExámenLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(167, 66);
            this.estudioExámenLaboratorioToolStripMenuItem.Text = "Estudio Exámen Laboratorio";
            this.estudioExámenLaboratorioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.estudioExámenLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.estudioExámenLaboratorioToolStripMenuItem_Click);
            // 
            // entregaExámenLaboratorioToolStripMenuItem
            // 
            this.entregaExámenLaboratorioToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_assignment_turned_in_black_48dp2;
            this.entregaExámenLaboratorioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entregaExámenLaboratorioToolStripMenuItem.Name = "entregaExámenLaboratorioToolStripMenuItem";
            this.entregaExámenLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(168, 66);
            this.entregaExámenLaboratorioToolStripMenuItem.Text = "Entrega Exámen Laboratorio";
            this.entregaExámenLaboratorioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.entregaExámenLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.entregaExámenLaboratorioToolStripMenuItem_Click);
            // 
            // facturaElectrónicaHaciendaToolStripMenuItem
            // 
            this.facturaElectrónicaHaciendaToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_receipt_long_black_48dp;
            this.facturaElectrónicaHaciendaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturaElectrónicaHaciendaToolStripMenuItem.Name = "facturaElectrónicaHaciendaToolStripMenuItem";
            this.facturaElectrónicaHaciendaToolStripMenuItem.Size = new System.Drawing.Size(172, 66);
            this.facturaElectrónicaHaciendaToolStripMenuItem.Text = "Factura Electrónica Hacienda";
            this.facturaElectrónicaHaciendaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.facturaElectrónicaHaciendaToolStripMenuItem.Click += new System.EventHandler(this.facturaElectrónicaHaciendaToolStripMenuItem_Click);
            // 
            // frmProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenuProceso);
            this.IsMdiContainer = true;
            this.Name = "frmProceso";
            this.Text = "Procesos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuProceso.ResumeLayout(false);
            this.msMenuProceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuProceso;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenciónDelPacienteclienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudioExámenLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregaExámenLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaElectrónicaHaciendaToolStripMenuItem;
    }
}