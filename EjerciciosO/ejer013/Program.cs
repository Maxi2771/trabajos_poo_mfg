using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comercial comercial1 = new Comercial("Maxi", 35, 1500, 250);
            Comercial comercial2 = new Comercial("Ludmi", 28, 1600, 150);
            Repartidor repartidor1 = new Repartidor("Fabri", 24, 1200, "Zona 3");
            Repartidor repartidor2 = new Repartidor("Agus", 26, 1300, "Zona 1");

            comercial1.Plus();
            comercial2.Plus();
            repartidor1.Plus();
            repartidor2.Plus();

            Console.ReadKey();
        }
    }
}
