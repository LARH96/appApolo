namespace UTN.Winforms.Apolo.Layers.UI.Reports
{
    partial class frmReporte
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
            this.msMenuReporte = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinerosRecibidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoExámenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuReporte
            // 
            this.msMenuReporte.AutoSize = false;
            this.msMenuReporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.solicitudesDiariasToolStripMenuItem,
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem,
            this.dinerosRecibidosToolStripMenuItem,
            this.listadoExámenesToolStripMenuItem});
            this.msMenuReporte.Location = new System.Drawing.Point(0, 0);
            this.msMenuReporte.Name = "msMenuReporte";
            this.msMenuReporte.Size = new System.Drawing.Size(800, 72);
            this.msMenuReporte.TabIndex = 0;
            this.msMenuReporte.Text = "mnStpReporte";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_home_black_18dp;
            this.homeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(66, 68);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // solicitudesDiariasToolStripMenuItem
            // 
            this.solicitudesDiariasToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_pending_actions_black_48dp;
            this.solicitudesDiariasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.solicitudesDiariasToolStripMenuItem.Name = "solicitudesDiariasToolStripMenuItem";
            this.solicitudesDiariasToolStripMenuItem.Size = new System.Drawing.Size(114, 68);
            this.solicitudesDiariasToolStripMenuItem.Text = "Solicitudes Diarias";
            this.solicitudesDiariasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.solicitudesDiariasToolStripMenuItem.Click += new System.EventHandler(this.solicitudesDiariasToolStripMenuItem_Click);
            // 
            // históricoDeSolicitudesDePacientesClientesToolStripMenuItem
            // 
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_history_black_48dp;
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.Name = "históricoDeSolicitudesDePacientesClientesToolStripMenuItem";
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.Size = new System.Drawing.Size(197, 68);
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.Text = "Histórico Solicit. Pacient./Clientes";
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem.Click += new System.EventHandler(this.históricoDeSolicitudesDePacientesClientesToolStripMenuItem_Click);
            // 
            // dinerosRecibidosToolStripMenuItem
            // 
            this.dinerosRecibidosToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_request_page_black_48dp1;
            this.dinerosRecibidosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dinerosRecibidosToolStripMenuItem.Name = "dinerosRecibidosToolStripMenuItem";
            this.dinerosRecibidosToolStripMenuItem.Size = new System.Drawing.Size(110, 68);
            this.dinerosRecibidosToolStripMenuItem.Text = "Dineros recibidos";
            this.dinerosRecibidosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dinerosRecibidosToolStripMenuItem.Click += new System.EventHandler(this.dinerosRecibidosToolStripMenuItem_Click);
            // 
            // listadoExámenesToolStripMenuItem
            // 
            this.listadoExámenesToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_format_list_numbered_black_48dp;
            this.listadoExámenesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listadoExámenesToolStripMenuItem.Name = "listadoExámenesToolStripMenuItem";
            this.listadoExámenesToolStripMenuItem.Size = new System.Drawing.Size(113, 68);
            this.listadoExámenesToolStripMenuItem.Text = "Listado exámenes";
            this.listadoExámenesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.listadoExámenesToolStripMenuItem.Click += new System.EventHandler(this.listadoExámenesToolStripMenuItem_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenuReporte);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuReporte;
            this.Name = "frmReporte";
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuReporte.ResumeLayout(false);
            this.msMenuReporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuReporte;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeSolicitudesDePacientesClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinerosRecibidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoExámenesToolStripMenuItem;
    }
}