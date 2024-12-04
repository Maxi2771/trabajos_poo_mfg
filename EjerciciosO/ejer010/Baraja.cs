using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer010
{
    internal class Baraja
    {
        private List<Cartas> cartas;
        private List<Cartas> cartasMonton;
        private Random r;

        public Baraja()
        {
            cartas = new List<Cartas>();
            cartasMonton = new List<Cartas>();
            r = new Random();
            string[] palos = { "Espadas", "Bastones", "Oro", "Copas" };

            for(int i = 1; i <= 12; i++)
            {
                if(i != 8 && i != 9)
                {
                    foreach(var palo in palos)
                    {
                        cartas.Add(new Cartas(i, palo));
                    }
                }
            }
        }

        public void Barajar()
        {
            int cantCartas = cartas.Count;
            while(cantCartas > 1)
            {
                int k = r.Next(cantCartas--);
                Cartas temp = cartas[cantCartas];
                cartas[cantCartas] = cartas[k];
                cartas[k] = temp;
            } 
        }

        public Cartas SiguienteCarta()
        {
            if(cartas.Count == 0)
            {
                Console.WriteLine("No hay cartas");
                return null;
            }
            Cartas carta = cartas[0];
            cartas.RemoveAt(0);
            cartasMonton.Add(carta);
            return carta;
        }

        public int cartasDisponibles()
        {
            return cartas.Count;
        }

        public List<Cartas> darCartas(int cant)
        {
            if(cant > cartas.Count)
            {
                Console.WriteLine("No hay suficientes cartas");
                return new List<Cartas>();
            }

            List<Cartas> cartasDevueltas = cartas.GetRange(0, cant);
            cartas.RemoveRange(0, cant);
            cartasMonton.AddRange(cartasDevueltas);
            return cartasDevueltas;
        }

        public void CartasMonton()
        {
            if(cartasMonton.Count == 0)
            {
                Console.WriteLine("No hay cartas en el monto");
                return;
            }
            Console.WriteLine("Cartas en el montón:");
            foreach (var carta in cartasMonton)
            {
                Console.WriteLine(carta);
            }
        }

        public void MostrarBaraja()
        {
            Console.WriteLine("Cartas restantes de la baraja");
            foreach(var carta in cartas)
            {
                Console.WriteLine(carta);
            }
        }
    }
}
