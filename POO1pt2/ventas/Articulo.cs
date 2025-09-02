using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas
{
    class Articulo
    {
        // private int codigoArticulo;
        //Otra forma de crear la propiedad del atributo omitiendo la declaración de atributo - prop + doble TAB
        public int CodigoArticulo { get; set; }
        //private float precio;
        public float Precio { get; set; }

        private int codMarca;

        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
