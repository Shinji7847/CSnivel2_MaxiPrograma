using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonoApp
{
    class Telefono
    {
        private string modelo;
        private string marca;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; } 
        }
        public string NumeroTelefonico { get; set; } //La misma propiedad crea el atributo por detrás

        public Telefono(string modelo, string marca)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        public string llamar()
        {
            return "Realizando llamada...";
        }

        public string llamar(string contacto)
        {
            return "Llamando a... " + contacto;
        }
    }
}
