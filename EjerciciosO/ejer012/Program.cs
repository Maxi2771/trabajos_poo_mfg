using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego juego;
            int cant;
            Console.Write("Ingresar cantidad de jugadores: ");
            cant = int.Parse(Console.ReadLine());
            if(cant > 6 || cant == 0)
            {
                cant = 6;
            }
            juego = new Juego(cant);
            while(!juego.finJuego())
            {
                juego.Ronda();
            }
            Console.WriteLine("Juego Terminado!");

            Console.ReadKey();
        }
    }
}
