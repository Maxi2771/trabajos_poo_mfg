using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            series[0] = new Serie("The Walking Dead", "Terror", "Robert Kirkman", 2);
            series[1] = new Serie("El Mandalorian", "Ciencia Ficción", "Jon Favreau", 1);
            series[2] = new Serie("Stranger Things", "Duffer Brothers");
            series[3] = new Serie("Ben 10", "Man of Action");
            series[4] = new Serie("Young Justice", "Ciencia Ficción", "Greg Weisman", 4);


            videojuegos[0] = new Videojuego("Minecraft", "Sandbox", "Mojang", 100);
            videojuegos[1] = new Videojuego("Super Mario Odyssey", 15);
            videojuegos[2] = new Videojuego("Red Dead Redemption 2", "Aventura", "Rockstar Games", 60);
            videojuegos[3] = new Videojuego("Detroit Become Human", "Aventura", "Quantic Dream", 200);
            videojuegos[4] = new Videojuego("Mortal Kombat 11 Ultimate", 90);

            series[0].Entregar();
            series[4].Entregar();
            videojuegos[0].Entregar();
            videojuegos[4].Entregar();

            int seriesE = 0, videojuegosE = 0;
            Serie seriesEn = series[0];
            Videojuego videojuegosEn = videojuegos[0];

            foreach (Serie s in series)
            {
                if (s.IsEntregado())
                {
                    seriesE++;
                    s.Devolver();
                }
            }

            foreach (Videojuego v in videojuegos)
            {
                if (v.IsEntregado())
                {
                    videojuegosE++;
                    v.Devolver();
                }
            }
            Console.WriteLine($"Series Entregadas {seriesE}");
            Console.WriteLine($"Juegos Entregados {videojuegosE}");


            foreach (Serie s in series)
            {
                if (s.CompareTo(seriesEn) > 0)
                {
                    seriesEn = s;
                }
            }

            foreach (Videojuego v in videojuegos)
            {
                if (v.CompareTo(videojuegosEn) > 0)
                {
                    videojuegosEn = v;
                }
            }
            Console.WriteLine($"Series con más temporadas: {seriesEn}");
            Console.WriteLine($"Juegos con más horas jugadas: {videojuegosEn}");



            Console.ReadKey();
        }
    }
}
