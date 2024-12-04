using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer007
{
    class Raices
    {
        private double a, b, c;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Discriminante()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public bool TieneRaices()
        {
            return Discriminante() >= 0;
        }

        public bool TieneRaiz()
        {
            return Discriminante() == 0;
        }

        public void ObtenerRaices()
        {
            if (TieneRaices())
            {
                double discriminante = Discriminante();
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine($"Raíz 1 = {x1} y Raíz 2 = {x2}");
            }
            else
            {
                Console.WriteLine("No tiene soluciones reales.");
            }
        }

        public void ObtenerRaiz()
        {
            if (TieneRaiz())
            {
                double x = -b / (2 * a);
                Console.WriteLine($"La solución es: {x}");
            }
            else
            {
                Console.WriteLine("No tiene una solución real.");
            }
        }

        public void Calcular()
        {
            if (TieneRaices())
            {
                ObtenerRaices();
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }
        }
    }
}
