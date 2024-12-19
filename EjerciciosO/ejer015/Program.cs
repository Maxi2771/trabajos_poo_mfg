using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen(3);

            almacen.AgregarProducto(new AguaMineral(1, 1.5, 1.20, "Marca 1", "Manantial A"), 0);
            almacen.AgregarProducto(new Azucarada(2, 1.0, 1.50, "Marca 2", 10, false), 1);
            almacen.AgregarProducto(new AguaMineral(3, 2.0, 1.00, "Marca 3", "Manantial B"), 0);
            almacen.AgregarProducto(new Azucarada(4, 1.5, 1.80, "Marca 4", 15, true), 1);
            almacen.MostrarInformacion();

            Console.WriteLine($"Precio total del almacén: {almacen.CalcularPrecioTotal()}");
            Console.WriteLine($"Precio total de la estantería 0: {almacen.CalcularPrecioEstanteria(0)}");
            Console.WriteLine($"Precio total de la estantería 1: {almacen.CalcularPrecioEstanteria(1)}");
            
            string marcaBuscada = "Marca 1";
            Console.WriteLine($"Precio total de la marca {marcaBuscada}: {almacen.CalcularPrecioPorMarca(marcaBuscada)}");

            almacen.EliminarProducto(2);
            almacen.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
