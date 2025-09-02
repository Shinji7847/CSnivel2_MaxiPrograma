using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        private int capacidad;
        private string color;
        private string material;

        //PROPIEDAD forma distinta de hacer los setter y getter - método escrito con mayus
        public int Capacidad
        {
            set { capacidad = value; }
            get { return capacidad; }
        }
    }
}
