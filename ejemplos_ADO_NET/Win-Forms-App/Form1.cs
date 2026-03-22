using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Forms_App
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon; //Lista para manipular en la ajecucion de la ventana

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns["UrlImagen"].Visible = false; //Oculta la columna UrlImagen
            cargarImagen(listaPokemon[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        /* private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemons.Load(imagen);
            }
            catch (Exception ex)
            {
                pbPokemons.Load("https://img.freepik.com/free-vector/illustration-gallery-icon_53876-27002.jpg?semt=ais_hybrid&w=740&q=80");
            }
        }
        */

        private void cargarImagen(string imagen)
        {
            try
            {
                // Si la URL está vacía, cargamos la de error directamente
                if (string.IsNullOrEmpty(imagen))
                    throw new Exception();

                pbPokemons.Load(imagen);
            }
            catch (Exception)
            {
                // Usa una imagen local o una URL que sepas que SIEMPRE funciona
                pbPokemons.Load("https://tse2.mm.bing.net/th/id/OIP.sWCvltMZF_s3mjA5sL-RdgHaE8?pid=Api&P=0&h=180");
            }
        }
    }
}
