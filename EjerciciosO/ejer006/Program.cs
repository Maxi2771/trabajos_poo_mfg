using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>();

            libros.Add(new Libro(1234567890, "La vuelta al mundo en 80 días", "Julio Verne", 50));
            libros.Add(new Libro(0987654321, "Sopa de diamantes", "Norma Huidobro", 100));

            foreach (Libro libro in libros)
            {
                libro.MostrarInfo();
            }

            Console.ReadKey();
        }
    }
}
