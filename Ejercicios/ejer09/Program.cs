using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que permita al usuario calcular la distancia entre dos puntos en un plano cartesiano.*/

namespace ejer09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double px1, py1, px2, py2, restaX, restaY, cuadradoX, cuadradoY, sumaXY, raizXY;
            Console.Write("Punto 1 \nX del punto 1: ");
            px1 = double.Parse(Console.ReadLine());
            Console.Write("Punto 1 \nY del punto 1: ");
            py1 = double.Parse(Console.ReadLine());
            Console.Write("Punto 2 \nX del punto 2: ");
            px2 = double.Parse(Console.ReadLine());
            Console.Write("Punto 2 \nY del punto 2: ");
            py2 = double.Parse(Console.ReadLine());

            restaX = px2 - px1;
            restaY = py2 - py1;
            cuadradoX = restaX * restaX;
            cuadradoY = restaY * restaY;
            sumaXY = cuadradoX + cuadradoY;
            raizXY = Math.Sqrt(sumaXY);

            Console.WriteLine($"Distancia de los 2 puntos  {raizXY}");
            Console.ReadKey();
        }
    }
}
