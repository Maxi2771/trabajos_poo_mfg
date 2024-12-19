using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer011
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "Maxi", "Fabri", "Ludmi", "Agus", "Valen" };
            List<Jugador> jugadores = new List<Jugador>();
            for (int i = 0; i < nombres.Count; i++)
            {
                jugadores.Add(new Jugador(i + 1, r.Next(500, 10001), nombres[i]));
            }

            string[] equipos = { "San Lorenzo", "Huracan", "Boca", "River", "Independiente", "Racing", "Velez", "SacaChispas", "Los Andes" };
            Partido partido = new Partido(equipos);

            Juego juego = new Juego(jugadores, partido);

            while (!juego.Terminado)
            {
                juego.Ronda(r);
            }
            Console.ReadKey();
        }
    }
}
