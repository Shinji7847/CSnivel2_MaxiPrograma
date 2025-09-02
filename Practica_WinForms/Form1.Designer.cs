namespace Practica_WinForms
{
    partial class Ventana1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPrimera1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::Practica_WinForms.Properties.Resources.Signos;
            this.btn1.Location = new System.Drawing.Point(307, 151);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(184, 60);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Primer Botón";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(175, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PrimerEtiqueta1";
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // txtBoxPrimera1
            // 
            this.txtBoxPrimera1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxPrimera1.Location = new System.Drawing.Point(307, 125);
            this.txtBoxPrimera1.MaxLength = 200;
            this.txtBoxPrimera1.Name = "txtBoxPrimera1";
            this.txtBoxPrimera1.Size = new System.Drawing.Size(184, 20);
            this.txtBoxPrimera1.TabIndex = 2;
            this.txtBoxPrimera1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrimera1_KeyPress);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(307, 227);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox2.Size = new System.Drawing.Size(184, 20);
            this.txtBox2.TabIndex = 3;
            this.txtBox2.Leave += new System.EventHandler(this.txtBox2_Leave);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(781, 390);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBoxPrimera1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 429);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(771, 429);
            this.Name = "Ventana1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana1_FormClosed);
            this.Load += new System.EventHandler(this.Ventana1_Load);
            this.Click += new System.EventHandler(this.Ventana1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPrimera1;
        private System.Windows.Forms.TextBox txtBox2;
    }
}

