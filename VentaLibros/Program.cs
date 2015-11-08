using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaLibros
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            List<Articulo> listaArticulos = new List<Articulo>();

            do
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("********* SISTEMA DE PEDIDOS *********");
                Console.WriteLine("**************************************");
                
                Console.WriteLine("Que articulo desea comprar?");
                Console.WriteLine("1.- Libros");
                Console.WriteLine("2.- Revista");
                Console.WriteLine("3.- Cuaderno");
                Console.WriteLine("4.- Obtener Factura");
                Console.WriteLine("5.- Salir");

               option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        listaArticulos.Add(printCantPrecio(Tipo.Libro));
                        break;

                    case 2:
                        listaArticulos.Add(printCantPrecio(Tipo.Revista));
                        break;

                    case 3:
                        listaArticulos.Add(printCantPrecio(Tipo.Cuaderno));
                        break;
                    
                    case 4:
                        Console.WriteLine("El Total de su Pedido es: "+listaArticulos.Sum(x=>x.getTotal()));
                        break;

                    case 5:
                        break;
                }

            } while (option != 5);

        }

        static Articulo printCantPrecio(Tipo tipo)
        {
            int cant = 0;
            double precio = 0;
            Console.WriteLine("Digite Cantidad de " + tipo.ToString() + ":");
            cant = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite el Precio " + tipo.ToString() + ":");
            precio = Double.Parse(Console.ReadLine());
            return new Articulo(precio, cant, tipo);
        }
    }
}
