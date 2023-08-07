namespace formMain
{
    partial class formMain2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsPrincipal = new System.Windows.Forms.MenuStrip();
            mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            mnsPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnsPrincipal
            // 
            mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuArchivo });
            mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            mnsPrincipal.Name = "mnsPrincipal";
            mnsPrincipal.Size = new System.Drawing.Size(800, 24);
            mnsPrincipal.TabIndex = 1;
            mnsPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { altaToolStripMenuItem, mnuSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new System.Drawing.Size(60, 20);
            mnuArchivo.Text = "Archivo";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { usuarioToolStripMenuItem, alumnoToolStripMenuItem, planToolStripMenuItem, comisionToolStripMenuItem, materiaToolStripMenuItem });
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            alumnoToolStripMenuItem.Text = "Persona";
            alumnoToolStripMenuItem.Click += alumnoToolStripMenuItem_Click;
            // 
            // planToolStripMenuItem
            // 
            planToolStripMenuItem.Name = "planToolStripMenuItem";
            planToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            planToolStripMenuItem.Text = "Plan";
            planToolStripMenuItem.Click += planToolStripMenuItem_Click;
            // 
            // comisionToolStripMenuItem
            // 
            comisionToolStripMenuItem.Name = "comisionToolStripMenuItem";
            comisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            comisionToolStripMenuItem.Text = "Comision";
            comisionToolStripMenuItem.Click += comisionToolStripMenuItem_Click;
            // 
            // materiaToolStripMenuItem
            // 
            materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            materiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            materiaToolStripMenuItem.Text = "Materia";
            materiaToolStripMenuItem.Click += materiaToolStripMenuItem_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new System.Drawing.Size(180, 22);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // formMain2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(mnsPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = mnsPrincipal;
            Name = "formMain2";
            Text = "Academia";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormMain_Load;
            Shown += FormMain_Shown;
            mnsPrincipal.ResumeLayout(false);
            mnsPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
    }
}
