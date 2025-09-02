using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_WinForms
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento Click, atención.");
            //this.BackColor = Color.Blue;
            if (txtBoxPrimera1.Text == "")
                txtBoxPrimera1.BackColor = Color.Red;
            else
                txtBoxPrimera1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Cyan;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Cursor = Cursors.Arrow;
        }

        private void txtBoxPrimera1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59 && e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtBox2.Text.Length + " caracteres");
        }

        private void Ventana1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau... chau...");
        }

        private void Ventana1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }
    }
        
}
