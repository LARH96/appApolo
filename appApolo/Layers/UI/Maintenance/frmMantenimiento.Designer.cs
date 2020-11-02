namespace UTN.Winforms.Apolo.UI
{
    partial class frmMantenimiento
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
            this.msMenuMantenimiento = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoExámenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresEspecialistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuMantenimiento
            // 
            this.msMenuMantenimiento.AutoSize = false;
            this.msMenuMantenimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.examenToolStripMenuItem,
            this.tipoExámenToolStripMenuItem,
            this.doctoresEspecialistaToolStripMenuItem});
            this.msMenuMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.msMenuMantenimiento.Name = "msMenuMantenimiento";
            this.msMenuMantenimiento.Size = new System.Drawing.Size(800, 73);
            this.msMenuMantenimiento.TabIndex = 0;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_home_black_18dp;
            this.homeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(66, 69);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.gGToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_accessibility_black_48dp;
            this.pacienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(94, 69);
            this.pacienteToolStripMenuItem.Text = "     Paciente     ";
            this.pacienteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // examenToolStripMenuItem
            // 
            this.examenToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_topic_black_48dp;
            this.examenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.examenToolStripMenuItem.Name = "examenToolStripMenuItem";
            this.examenToolStripMenuItem.Size = new System.Drawing.Size(91, 69);
            this.examenToolStripMenuItem.Text = "     Exámen     ";
            this.examenToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.examenToolStripMenuItem.Click += new System.EventHandler(this.examenToolStripMenuItem_Click);
            // 
            // tipoExámenToolStripMenuItem
            // 
            this.tipoExámenToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_description_black_48dp;
            this.tipoExámenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tipoExámenToolStripMenuItem.Name = "tipoExámenToolStripMenuItem";
            this.tipoExámenToolStripMenuItem.Size = new System.Drawing.Size(117, 69);
            this.tipoExámenToolStripMenuItem.Text = "     Tipo Exámen     ";
            this.tipoExámenToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tipoExámenToolStripMenuItem.Click += new System.EventHandler(this.tipoExámenToolStripMenuItem_Click);
            // 
            // doctoresEspecialistaToolStripMenuItem
            // 
            this.doctoresEspecialistaToolStripMenuItem.Image = global::UTN.Winforms.Apolo.Properties.Resources.baseline_people_alt_black_48dp;
            this.doctoresEspecialistaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doctoresEspecialistaToolStripMenuItem.Name = "doctoresEspecialistaToolStripMenuItem";
            this.doctoresEspecialistaToolStripMenuItem.Size = new System.Drawing.Size(120, 69);
            this.doctoresEspecialistaToolStripMenuItem.Text = "Doctor/Especialista";
            this.doctoresEspecialistaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.doctoresEspecialistaToolStripMenuItem.Click += new System.EventHandler(this.doctoresEspecialistaToolStripMenuItem_Click);
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMenuMantenimiento);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuMantenimiento;
            this.Name = "frmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimientos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuMantenimiento.ResumeLayout(false);
            this.msMenuMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoExámenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresEspecialistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}