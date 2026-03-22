using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_App
{
    class Elemento
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion; //Sobreescritura de método ToString para modificar lo que la App muestra en la grilla.
        }
    }
}
