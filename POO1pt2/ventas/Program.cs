using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Primer lote con 10 registros de productos, cada producto tiene:
             * - Código de artículo (3 números no correlativos)
             * - Precio
             * - Código de marca (del 1 al 10)
             * Segundo lote con las ventas de la semana. Cada venta tiene:
             * - Código de artículo
             * - Cantidad
             * - Código de cliente (1 al 100)
             * Este lote corta con código de cliente cero.
             */

            Articulo[] articulos = new Articulo[10];

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Código: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 al 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            //Cargado el vector completo

            Venta venta = new Venta();
            Console.WriteLine("Ingrese número de cliente(1 al 100): ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Código Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //Trabajamos...

                //Pido cliente nuevo...
                Console.WriteLine("Ingrese número de cliente(1 al 100): ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
