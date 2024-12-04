using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Camtidad de contraseñas: ");
            int cant = int.Parse(Console.ReadLine());
            Console.Write("Longitud de las contraseñas: ");
            int longitud = int.Parse(Console.ReadLine());

            Password[] passwords = new Password[cant];
            bool[] esFuerteArray = new bool[cant];

            for (int i = 0; i < cant; i++)
            {
                passwords[i] = new Password(longitud);
                passwords[i].generarPassword();
                esFuerteArray[i] = passwords[i].esFuerte();
            }

            Console.WriteLine("\nContraseñas generadas y su fortaleza:");
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine($"{passwords[i].obtenerPassword()} {esFuerteArray[i]}");
            }

            Console.ReadKey();
        }
    }
}
