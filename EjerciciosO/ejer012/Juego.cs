using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012
{
    internal class Juego
    {
        List<Jugador> jugadores;
        Revolver revolver;

        public List<Jugador> Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }

        public Revolver Revolver
        {
            get { return revolver; }
            set { revolver = value; }
        }

        public Juego(int cant)
        {
            jugadores = new List<Jugador>();
            for (int i = 0; i < cant; i++)
            {
                jugadores.Add(new Jugador(i));
            }
            revolver = new Revolver();
        }

        public bool finJuego()
        {
            foreach(Jugador jugador in jugadores)
            {
                if (!jugador.Vivo)
                {
                    return true;
                }
            }
            return false;
        }

        public void Ronda()
        {
            foreach (Jugador jugador in jugadores)
            {
                if (finJuego())
                {
                    break;
                }
                jugador.Disparar(revolver);
                revolver.SiguienteBala();
            }
        }
    }
}
