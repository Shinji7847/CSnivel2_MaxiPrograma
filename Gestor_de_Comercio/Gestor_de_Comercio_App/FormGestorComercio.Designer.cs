namespace Gestor_de_Comercio_App
{
    partial class FormGestorComercio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGestorComercio = new System.Windows.Forms.DataGridView();
            this.pBoxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestorComercio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 26);
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            // 
            // dgvGestorComercio
            // 
            this.dgvGestorComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestorComercio.Location = new System.Drawing.Point(12, 12);
            this.dgvGestorComercio.Name = "dgvGestorComercio";
            this.dgvGestorComercio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestorComercio.Size = new System.Drawing.Size(459, 275);
            this.dgvGestorComercio.TabIndex = 1;
            // 
            // pBoxImagenArticulo
            // 
            this.pBoxImagenArticulo.Location = new System.Drawing.Point(478, 12);
            this.pBoxImagenArticulo.Name = "pBoxImagenArticulo";
            this.pBoxImagenArticulo.Size = new System.Drawing.Size(290, 275);
            this.pBoxImagenArticulo.TabIndex = 2;
            this.pBoxImagenArticulo.TabStop = false;
            // 
            // FormGestorComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pBoxImagenArticulo);
            this.Controls.Add(this.dgvGestorComercio);
            this.Name = "FormGestorComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Comercio";
            this.Load += new System.EventHandler(this.FormGestorComercio_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestorComercio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvGestorComercio;
        private System.Windows.Forms.PictureBox pBoxImagenArticulo;
    }
}

