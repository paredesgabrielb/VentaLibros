using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaLibros
{
    class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public int Cantidad { get; set; }

        public double Descuento { get; set; }

        public Tipo Tipo { get; set; }
        public Articulo(string nombre, double precio, int cantidad, Tipo tipo)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Tipo = tipo;
            Descuento = getDescuentoPorTipo(tipo);
        }

        public Articulo(double precio, int cantidad, Tipo tipo)
        {
            Nombre = tipo.ToString();
            Precio = precio;
            Cantidad = cantidad;
            Tipo = tipo;
            Descuento = getDescuentoPorTipo(tipo);
        }

        public double getTotal()
        {
            return Cantidad * Precio * Descuento;
        }

        private double getDescuentoPorTipo(Tipo tipo)
        {
            double result = 0;
            switch (tipo)
            {
                case Tipo.Cuaderno:
                    result = 1 - 0.1;
                    break;
                case Tipo.Libro:
                    result = 1 - 0.22;
                    break;
                case Tipo.Revista:
                    result = 1 - 0.16;
                    break;
            }

            return result;
        }


    }

    enum Tipo
    {
        Libro,
        Revista,
        Cuaderno
    }
}
