using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que genere una lista de números primos hasta un número ingresado por el usuario.*/

namespace ejer04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 2; i < numero; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine($"{i} es un número primo.");
                }
                else
                {
                    Console.WriteLine($"{i} no es un número primo.");
                }
            }
            Console.ReadKey();
        }

        static bool EsPrimo(int num)
        {
            if (num <= 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;

            for (int i = 3; i < num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

    }
}
