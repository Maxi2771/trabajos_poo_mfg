using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            baraja.Barajar();
            Console.WriteLine($"Cartas disponibles: {baraja.cartasDisponibles()}");
            baraja.MostrarBaraja();
            Console.WriteLine("Siguiente carta:");
            Console.WriteLine(baraja.SiguienteCarta());
            Console.WriteLine($"Cartas disponibles: {baraja.cartasDisponibles()}");
            baraja.MostrarBaraja();
            Console.WriteLine("\nDar 5 cartas:");
            var cartasDadas = baraja.darCartas(5);
            foreach (var carta in cartasDadas)
            {
                Console.WriteLine(carta);
            }
            Console.WriteLine($"Cartas disponibles: {baraja.cartasDisponibles()}");
            baraja.MostrarBaraja();
            Console.WriteLine("\nCartas en el montón:");
            baraja.CartasMonton();

            Console.ReadKey();
        }
    }
}
