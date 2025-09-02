using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.setEdad(31);

            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella();
            //Propiedad
            b1.Capacidad = 200;

            Perro perro1 = new Perro();
            perro1.Nombre = "Charly";
            perro1.Color = "Negro";
            perro1.Origen = "Argentino";

            Console.WriteLine("El primer perro se llama " + perro1.Nombre + " es de origen " + perro1.Origen 
                + " y su color es " + perro1.Color);
            Console.ReadKey();
        }
    }
}
