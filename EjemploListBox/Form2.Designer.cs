namespace EjemploListBox
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilPersonaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem1,
            this.opcionesToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem1
            // 
            this.opcionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilPersonaToolStripMenuItem,
            this.abrirToolStripMenuItem1,
            this.guardarToolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.opcionesToolStripMenuItem1.Name = "opcionesToolStripMenuItem1";
            this.opcionesToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.opcionesToolStripMenuItem1.Text = "&Archivo";
            // 
            // perfilPersonaToolStripMenuItem
            // 
            this.perfilPersonaToolStripMenuItem.Name = "perfilPersonaToolStripMenuItem";
            this.perfilPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perfilPersonaToolStripMenuItem.Text = "Nuevo";
            // 
            // opcionesToolStripMenuItem2
            // 
            this.opcionesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilPersonaToolStripMenuItem1});
            this.opcionesToolStripMenuItem2.Name = "opcionesToolStripMenuItem2";
            this.opcionesToolStripMenuItem2.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem2.Text = "&Opciones";
            // 
            // perfilPersonaToolStripMenuItem1
            // 
            this.perfilPersonaToolStripMenuItem1.Name = "perfilPersonaToolStripMenuItem1";
            this.perfilPersonaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.perfilPersonaToolStripMenuItem1.Text = "Perfil &Persona";
            this.perfilPersonaToolStripMenuItem1.Click += new System.EventHandler(this.perfilPersonaToolStripMenuItem1_Click);
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 392);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(659, 431);
            this.MinimumSize = new System.Drawing.Size(659, 431);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfilPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem perfilPersonaToolStripMenuItem1;
    }
}