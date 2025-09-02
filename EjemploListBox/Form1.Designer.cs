namespace EjemploListBox
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.lvNombres = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTPFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.radioBtnEstudiante = new System.Windows.Forms.RadioButton();
            this.radioBtnTrabajo = new System.Windows.Forms.RadioButton();
            this.radioBtnSinTrabajo = new System.Windows.Forms.RadioButton();
            this.groupBoxOcupacion = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColorFavorito = new System.Windows.Forms.ComboBox();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxOcupacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(110, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(110, 415);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(57, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(8, 81);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(96, 13);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha Nacimiento:";
            // 
            // lvNombres
            // 
            this.lvNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNombres.HideSelection = false;
            this.lvNombres.Location = new System.Drawing.Point(111, 287);
            this.lvNombres.Name = "lvNombres";
            this.lvNombres.Size = new System.Drawing.Size(256, 119);
            this.lvNombres.TabIndex = 6;
            this.lvNombres.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Perfil Persona";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTPFechaNacimiento
            // 
            this.dateTPFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTPFechaNacimiento.Location = new System.Drawing.Point(110, 81);
            this.dateTPFechaNacimiento.Name = "dateTPFechaNacimiento";
            this.dateTPFechaNacimiento.Size = new System.Drawing.Size(256, 20);
            this.dateTPFechaNacimiento.TabIndex = 1;
            // 
            // checkBoxChocolate
            // 
            this.checkBoxChocolate.AutoSize = true;
            this.checkBoxChocolate.Location = new System.Drawing.Point(111, 118);
            this.checkBoxChocolate.Name = "checkBoxChocolate";
            this.checkBoxChocolate.Size = new System.Drawing.Size(141, 17);
            this.checkBoxChocolate.TabIndex = 2;
            this.checkBoxChocolate.Text = "¿Te gusta el chocolate?";
            this.checkBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // radioBtnEstudiante
            // 
            this.radioBtnEstudiante.AutoSize = true;
            this.radioBtnEstudiante.Location = new System.Drawing.Point(23, 19);
            this.radioBtnEstudiante.Name = "radioBtnEstudiante";
            this.radioBtnEstudiante.Size = new System.Drawing.Size(75, 17);
            this.radioBtnEstudiante.TabIndex = 0;
            this.radioBtnEstudiante.Text = "Estudiante";
            this.radioBtnEstudiante.UseVisualStyleBackColor = true;
            // 
            // radioBtnTrabajo
            // 
            this.radioBtnTrabajo.AutoSize = true;
            this.radioBtnTrabajo.Checked = true;
            this.radioBtnTrabajo.Location = new System.Drawing.Point(126, 19);
            this.radioBtnTrabajo.Name = "radioBtnTrabajo";
            this.radioBtnTrabajo.Size = new System.Drawing.Size(61, 17);
            this.radioBtnTrabajo.TabIndex = 10;
            this.radioBtnTrabajo.TabStop = true;
            this.radioBtnTrabajo.Text = "Trabajo";
            this.radioBtnTrabajo.UseVisualStyleBackColor = true;
            // 
            // radioBtnSinTrabajo
            // 
            this.radioBtnSinTrabajo.AutoSize = true;
            this.radioBtnSinTrabajo.Location = new System.Drawing.Point(229, 19);
            this.radioBtnSinTrabajo.Name = "radioBtnSinTrabajo";
            this.radioBtnSinTrabajo.Size = new System.Drawing.Size(79, 17);
            this.radioBtnSinTrabajo.TabIndex = 11;
            this.radioBtnSinTrabajo.Text = "Sin Trabajo";
            this.radioBtnSinTrabajo.UseVisualStyleBackColor = true;
            // 
            // groupBoxOcupacion
            // 
            this.groupBoxOcupacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxOcupacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxOcupacion.Controls.Add(this.radioBtnEstudiante);
            this.groupBoxOcupacion.Controls.Add(this.radioBtnSinTrabajo);
            this.groupBoxOcupacion.Controls.Add(this.radioBtnTrabajo);
            this.groupBoxOcupacion.Location = new System.Drawing.Point(110, 156);
            this.groupBoxOcupacion.Name = "groupBoxOcupacion";
            this.groupBoxOcupacion.Size = new System.Drawing.Size(351, 45);
            this.groupBoxOcupacion.TabIndex = 3;
            this.groupBoxOcupacion.TabStop = false;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(32, 215);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(72, 13);
            this.labelColor.TabIndex = 13;
            this.labelColor.Text = "Color favorito:";
            // 
            // comboBoxColorFavorito
            // 
            this.comboBoxColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColorFavorito.FormattingEnabled = true;
            this.comboBoxColorFavorito.Location = new System.Drawing.Point(110, 212);
            this.comboBoxColorFavorito.Name = "comboBoxColorFavorito";
            this.comboBoxColorFavorito.Size = new System.Drawing.Size(256, 21);
            this.comboBoxColorFavorito.TabIndex = 4;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(110, 255);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(98, 26);
            this.btnVerPerfil.TabIndex = 5;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 496);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.comboBoxColorFavorito);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.groupBoxOcupacion);
            this.Controls.Add(this.checkBoxChocolate);
            this.Controls.Add(this.dateTPFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvNombres);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(708, 563);
            this.MinimumSize = new System.Drawing.Size(500, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOcupacion.ResumeLayout(false);
            this.groupBoxOcupacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lvNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTPFechaNacimiento;
        private System.Windows.Forms.CheckBox checkBoxChocolate;
        private System.Windows.Forms.RadioButton radioBtnEstudiante;
        private System.Windows.Forms.RadioButton radioBtnTrabajo;
        private System.Windows.Forms.RadioButton radioBtnSinTrabajo;
        private System.Windows.Forms.GroupBox groupBoxOcupacion;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColorFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

