using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que simule un juego de adivinanza de números, en el que el usuario debe adivinar un número generado aleatoriamente por el programa.*/

namespace ejer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Random rnd = new Random();
            var aleatorio = rnd.Next(0,10);
            Console.WriteLine("Ingresar un número entre 0 y 10");
            num = int.Parse(Console.ReadLine());
            if (aleatorio == num)
            {
                Console.WriteLine("El número es el correcto");
            }
            else
            {
                Console.WriteLine($"Fallaste vuelve a intentar \nEl número correcto era {aleatorio}");
            }
            Console.ReadKey();
        }
    }
}
