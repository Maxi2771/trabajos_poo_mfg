using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer011
{
    internal class Juego
    {
        private List<Jugador> jugadores;
        private Partido partido;
        private float pozo;
        private bool terminado = false;

        public List<Jugador> Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }

        public Partido Partido
        {
            get { return partido; }
            set { partido = value; }
        }

        public bool Terminado
        {
            get { return terminado; }
            set { terminado = value; }
        }

        public float Pozo
        {
            get { return pozo; }
            set { pozo = value; }
        }

        public Juego(List<Jugador> jugadores, Partido partido)
        {
            this.jugadores = jugadores;
            this.partido = partido;
        }

        public void Ronda(Random r)
        {
            string resultados = partido.Resultado(r);
            Console.WriteLine($"El partido será entre: {partido.Enfrentamiento(r)} \n Inicien sus apuestas:");
            List<Jugador> jugadoresApostando = new List<Jugador>();

            foreach(var  jugador in jugadores)
            {
                if (jugador.PuedeApostar())
                {
                    jugador.Dinero -= 100;
                    pozo += 100;
                    jugadoresApostando.Add(jugador);

                }
            }

            Console.WriteLine($"Resultado: {resultados}");
            if(jugadoresApostando.Count > 0)
            {
                foreach(Jugador jugador in jugadoresApostando)
                {
                    string apuesta = jugador.Resultado(r);
                    if (resultados == apuesta)
                    {
                        jugador.RondasGanadas++;
                        Console.WriteLine($"{jugador.Nombre} fue el ganador");
                        if (jugador.RondasGanadas == 2)
                        {
                            jugador.Dinero += pozo;
                            pozo = 0;
                            Console.WriteLine($"{jugador.Nombre} se lleva {jugador.Dinero} en premio");
                            terminado = true;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{jugador.Nombre} no ganó la apuesta ({apuesta})");
                    }
                }
            }
            else
            {
                Console.WriteLine($"La casa se lleva el pozo {pozo}");
                terminado = true;
            }
            Console.WriteLine($"Pozo acumulado {pozo}");
        }
    }
}
