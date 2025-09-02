namespace Practica2_App2
{
    partial class DatosPersonales1
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
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.lblEdad1 = new System.Windows.Forms.Label();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion1 = new System.Windows.Forms.Label();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxApellido.Location = new System.Drawing.Point(146, 27);
            this.txtBoxApellido.MaxLength = 15;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(448, 20);
            this.txtBoxApellido.TabIndex = 0;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxNombre.Location = new System.Drawing.Point(146, 64);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(448, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // lblApellido1
            // 
            this.lblApellido1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApellido1.Location = new System.Drawing.Point(65, 27);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(75, 17);
            this.lblApellido1.TabIndex = 2;
            this.lblApellido1.Text = "APELLIDO";
            // 
            // lblNombre1
            // 
            this.lblNombre1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre1.Location = new System.Drawing.Point(72, 64);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(68, 17);
            this.lblNombre1.TabIndex = 3;
            this.lblNombre1.Text = "NOMBRE";
            // 
            // txtBoxEdad
            // 
            this.txtBoxEdad.Location = new System.Drawing.Point(146, 101);
            this.txtBoxEdad.Name = "txtBoxEdad";
            this.txtBoxEdad.Size = new System.Drawing.Size(66, 20);
            this.txtBoxEdad.TabIndex = 2;
            this.txtBoxEdad.TextChanged += new System.EventHandler(this.txtBoxEdad_TextChanged);
            // 
            // lblEdad1
            // 
            this.lblEdad1.AutoSize = true;
            this.lblEdad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEdad1.Location = new System.Drawing.Point(94, 101);
            this.lblEdad1.Name = "lblEdad1";
            this.lblEdad1.Size = new System.Drawing.Size(46, 17);
            this.lblEdad1.TabIndex = 5;
            this.lblEdad1.Text = "EDAD";
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxDireccion.Location = new System.Drawing.Point(146, 138);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(448, 20);
            this.txtBoxDireccion.TabIndex = 3;
            // 
            // lblDireccion1
            // 
            this.lblDireccion1.AutoSize = true;
            this.lblDireccion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDireccion1.Location = new System.Drawing.Point(58, 138);
            this.lblDireccion1.Name = "lblDireccion1";
            this.lblDireccion1.Size = new System.Drawing.Size(82, 17);
            this.lblDireccion1.TabIndex = 7;
            this.lblDireccion1.Text = "DIRECCION";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultado2.Location = new System.Drawing.Point(47, 175);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(93, 17);
            this.lblResultado2.TabIndex = 8;
            this.lblResultado2.Text = "RESULTADO";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(164, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(268, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxResultado.Location = new System.Drawing.Point(50, 196);
            this.txtBoxResultado.Multiline = true;
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(544, 148);
            this.txtBoxResultado.TabIndex = 12;
            // 
            // DatosPersonales1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 402);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.lblDireccion1);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.lblEdad1);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxApellido);
            this.MinimumSize = new System.Drawing.Size(634, 441);
            this.Name = "DatosPersonales1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.Label lblEdad1;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.Label lblDireccion1;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBoxResultado;
    }
}

