    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula = new Pelicula("Como entrenar a tu dragón", "1h 38m", 6, " Chris Sanders, Dean DeBlois", 100);
            Cine cine = new Cine(pelicula);

            Random random = new Random();
            string[] nombres = { "Máximo", "Fabrizio", "Gino", "Agustín", "Ludmila" };
            for (int i = 0; i < 80; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int edad = random.Next(4,18);
                double dinero = random.Next(10, 120);

                Espectador espectador = new Espectador(nombre, edad, dinero);
                cine.SentarEspectador(espectador);
            }

            Console.ReadKey();
        }
    }
}
