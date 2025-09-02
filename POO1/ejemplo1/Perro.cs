using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Perro
    {
        private string nombre;
        private string color;
        private string origen;

        //Propiedades
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        public string Origen
        {
            set { origen = value; }
            get { return origen; }
        }
    }
}
