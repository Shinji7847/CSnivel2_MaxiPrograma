using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Win_Forms_App
{
    public partial class FormAltaPokemon : Form
    {
        public FormAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Lee los datos
            Pokemon nuevoPokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                nuevoPokemon.Numero = (int.Parse(txtBoxNumero.Text));
                nuevoPokemon.Nombre = txtBoxNombre.Text;
                nuevoPokemon.Descripcion = txtBoxDescripcion.Text;

                //Se envía a DB mediante PokemonNegocio(AccesoDatos)
                negocio.agregar(nuevoPokemon);
                MessageBox.Show("Agregado correctamente.");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
