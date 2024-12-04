using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices ecuacion = new Raices(1, -5, 6);
            ecuacion.Calcular();

            Console.ReadKey();
        }
    }
}
