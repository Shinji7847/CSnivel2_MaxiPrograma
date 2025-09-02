using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string pais = txtNombre.Text;
            lvNombres.Items.Add(pais);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxColorFavorito.Items.Add("Azul");
            comboBoxColorFavorito.Items.Add("Rojo");
            comboBoxColorFavorito.Items.Add("Amarillo");
            comboBoxColorFavorito.Items.Add("Negro");
            comboBoxColorFavorito.Items.Add("Blanco");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dateTPFechaNacimiento.Value;
            //Operador ternario
            string chocolate = checkBoxChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string ocupacion;
            if (radioBtnEstudiante.Checked)
                ocupacion = "Estudiante";
            else if (radioBtnTrabajo.Checked)
                ocupacion = "Trabaja";
            else
                ocupacion = "No tiene trabajo";

            string colorFavorito = comboBoxColorFavorito.SelectedItem.ToString();

            MessageBox.Show("Nombre: " + nombre + " - Fecha de nacimiento: " + fecha + " - Opinión sobre chocolate: " + chocolate
                + " - Ocupación: " + ocupacion + " - Color Favorito: " + colorFavorito);
        }
    }
}
