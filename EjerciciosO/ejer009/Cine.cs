using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer009
{
    internal class Cine
    {
        Pelicula pelicula;
        Asiento[,] asiento;

        public Cine(Pelicula pelicula)
        {
            this.pelicula = pelicula;
            asiento = new Asiento[8, 9]; 

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    asiento[i, j] = new Asiento();
                }
            }
        }

        public bool SentarEspectador(Espectador espectador)
        {
            if(espectador.Edad < pelicula.EdadMinima)
            {
                Console.WriteLine($"{espectador.Nombre} no cumple con la edad minima");
                return false;
            }

            if(espectador.Dinero < pelicula.Precio)
            {
                Console.WriteLine($"{espectador.Nombre} no tiene suficiente dinero");
                return false;
            }

            for(int i = 0;i < 8;i++)
            {
                for(int j = 0;j < 9; j++)
                {
                    if (!asiento[i, j].Ocupado)
                    {
                        asiento[i,j].Ocupado = true;
                        Console.WriteLine($"{espectador.Nombre} se ha sentado en el asiento {ObtenerAsiento(i, j)}.");
                        //ImprimirEstadoAsientos();
                        return true;
                    }
                }
            }
            Console.WriteLine("Asientos no disponibles");
            return false;
        }

        private string ObtenerAsiento(int fila, int columna)
        {
            char letraColumna = (char)('A' + columna);
            return $"{8-fila} {letraColumna}";
        }

        //ImprimirEstadoAsientos esto me permite ver los asientos

        /*private void ImprimirEstadoAsientos()
        {
            Console.WriteLine("Estado de los asientos:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(asiento[i, j].Ocupado ? "[X] " : "[ ] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }*/
    }
}
