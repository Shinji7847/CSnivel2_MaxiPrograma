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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                    return;
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
            //ShowDialog no puede usarse pues una ventana padre debe tener la ventana hija dentro.(Estructura de padres e hijos)
        }
    }
}
