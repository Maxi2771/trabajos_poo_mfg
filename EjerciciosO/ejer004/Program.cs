using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
            for (int i = 0; i < 5; i++)
            {
                electrodomesticos.Add(new Lavadora(150, 30, 35));
                electrodomesticos.Add(new Television(200, 25, 42, true));
            }

            double precioTotalElectrodomesticos = 0;
            double precioTotalLavadoras = 0;
            double precioTotalTelevisiones = 0;

            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                double precioFinal = electrodomestico.PrecioFinal();
                precioTotalElectrodomesticos += precioFinal;
                if (electrodomestico is Lavadora)
                {
                    precioTotalLavadoras += precioFinal;
                }else if (electrodomestico is Television)
                {
                    precioTotalTelevisiones += precioFinal;
                }
            }
            Console.WriteLine($"Precio total de los electrodomésticos: {precioTotalElectrodomesticos}");
            Console.WriteLine($"Precio total de las lavadoras: {precioTotalLavadoras}");
            Console.WriteLine($"Precio total de las televisiones: {precioTotalTelevisiones}");

            Console.ReadKey();
        }
    }
}
