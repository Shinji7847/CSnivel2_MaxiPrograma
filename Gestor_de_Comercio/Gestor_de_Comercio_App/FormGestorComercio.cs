using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaNegocio;

namespace Gestor_de_Comercio_App
{
    public partial class FormGestorComercio : Form
    {
        private List<Articulo> listaArticulo;

        public FormGestorComercio()
        {
            InitializeComponent();
        }

        private void FormGestorComercio_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulo = articuloNegocio.listar();
                dgvGestorComercio.DataSource = listaArticulo;
                pBoxImagenArticulo.Load(listaArticulo[0].ImagenUrl);
                //ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
