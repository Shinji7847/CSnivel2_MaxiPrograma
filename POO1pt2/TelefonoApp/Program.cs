using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("g100", "Motorola");
            Telefono t2 = new Telefono("A50", "Samsung");
            t1.NumeroTelefonico = "3492412749";
            t1.CodigoOperador = 1;
            t2.CodigoOperador = 4;
            t2.NumeroTelefonico = "3404454544";

            Console.WriteLine("Telefono " + t2.Marca + " modelo " + t2.Modelo + " y codigo " + t2.CodigoOperador);

            Console.WriteLine("Existe un telefono de marca " + t1.Marca + " y modelo " + t1.Modelo + 
                ", que tiene como numero " + t1.NumeroTelefonico + " y su código es: " + t1.CodigoOperador);

            string llamada1 = t1.llamar();
            string llamada2 = t1.llamar(t2.NumeroTelefonico);
            Console.WriteLine(llamada1);
            Console.WriteLine(llamada2);
            Console.ReadKey();
        }
    }
}
