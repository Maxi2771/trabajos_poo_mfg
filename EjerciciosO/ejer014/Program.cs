using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos[] productos = new Productos[]
            {
                new Perecedero("Lechuga", 10, 1),
                new Perecedero("Yogurt", 12, 1),
                new Noperecedero("Arroz", 10.5, "Granos"),
                new Noperecedero("Aceite", 12.5, "Líquidos")
            };

            int cant = 5;
            double total = 0;

            foreach (var p in productos)
            {
                double precioTotal = p.Calcular(cant);
                total += precioTotal;
                Console.WriteLine($"{p} cantidad: {cant} precio final: {precioTotal}");
            }
            Console.WriteLine($"Precio total de todos los productos: {total}");
            Console.ReadKey();
        }
    }
}
