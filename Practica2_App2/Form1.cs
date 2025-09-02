using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_App2
{
    public partial class DatosPersonales1 : Form
    {
        public DatosPersonales1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == "")
                txtBoxNombre.BackColor = Color.Red;
            else
                txtBoxNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtBoxApellido.Text == "")
                txtBoxApellido.BackColor = Color.Red;
            else
                txtBoxApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtBoxEdad.Text == "")
                txtBoxEdad.BackColor = Color.Red;
            else
                txtBoxEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtBoxDireccion.Text == "")
                txtBoxDireccion.BackColor = Color.Red;
            else
                txtBoxDireccion.BackColor = System.Drawing.SystemColors.Control;

            string nombre = txtBoxNombre.Text;
            string apellido = txtBoxApellido.Text;
            int edad = int.Parse(txtBoxEdad.Text);
            string direccion = txtBoxDireccion.Text;

            string resultado = $"Nombre y apellido: {nombre} {apellido} " +
                $"Edad: {edad} " +
                $"Dirección: {direccion}";
            txtBoxResultado.Text = resultado; 
        }

        private void txtBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBoxEdad.Text, out _))
                MessageBox.Show("La edad debe ser un número entero.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
