using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //Posee ATRIBUTOS o MIEMBROS

        private int edad;
        private float sueldo;
        private string nombre;

        //Encapsulamiento: Los atributos no deben ser accedidos desde el exterior.
        //Se necesita encapsular los atributos

        //Modificadores de visibilidad: public, private, protected, internal
        //Dentro de las clases las funciones se denominan METODOS

        //Método Setter
        public void setEdad(int e)
        {
            edad = e;
        }

        //Método Getter
        public int getEdad()
        {
            return edad;
        }
    }
}
