using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que calcule el promedio de un conjunto de números ingresados por el usuario.

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, cant, promedio, acumulador = 0;
            Console.Write("Cantidad de números que desea ingresar: ");
            cant = double.Parse(Console.ReadLine());
            for (int i = 1; i <= cant; i++)
            {
                Console.Write("Ingresar un número (" + i + "): ");
                num = double.Parse(Console.ReadLine());
                acumulador += num;
            }
            promedio = acumulador / cant;
            Console.WriteLine("El promedio es de: " + promedio);
            Console.ReadKey();
        }
    }
}
