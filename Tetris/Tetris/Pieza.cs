using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Pieza
    {
        public List<(int fila, int col)> Bloques { get; set; }
        public ConsoleColor Color { get; set; }
        public (int fila, int col) Centro { get; set; }

        public Pieza(ConsoleColor color)
        {
            Bloques = new List<(int fila, int col)>();
            Color = color;
        }

        public virtual void MoverAbajo()
        {
            for (int i = 0; i < Bloques.Count; i++)
            {
                Bloques[i] = (Bloques[i].fila + 1, Bloques[i].col);
            }
            Centro = (Centro.fila + 1, Centro.col);
        }

        public virtual bool MoverLateral(int direccion, int cantColumnas, List<Pieza> piezasFijas)
        {
            foreach (var bloque in Bloques)
            {
                int nuevaColumna = bloque.col + direccion;
                if (nuevaColumna < 0 || nuevaColumna >= cantColumnas ||
                    ColisionaConPiezas(bloque.fila, nuevaColumna, piezasFijas))
                {
                    return false;
                }
            }

            for (int i = 0; i < Bloques.Count; i++)
            {
                Bloques[i] = (Bloques[i].fila, Bloques[i].col + direccion);
            }
            Centro = (Centro.fila, Centro.col + direccion);
            return true;
        }

        public bool ColisionaConPiezas(int fila, int col, List<Pieza> piezasFijas)
        {
            foreach (var pieza in piezasFijas)
            {
                foreach (var bloque in pieza.Bloques)
                {
                    if (bloque.fila == fila && bloque.col == col)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public virtual void Dibujar()
        {
            Console.ForegroundColor = Color;
            foreach (var bloque in Bloques)
            {
                if (bloque.fila >= 0)
                {
                    Console.SetCursorPosition(bloque.col, bloque.fila);
                    Console.Write("*");
                }
            }
        }

        public virtual void Borrar()
        {
            foreach (var bloque in Bloques)
            {
                int consolaAncho = Console.BufferWidth;
                int consolaAlto = Console.BufferHeight;

                if (bloque.fila >= 0 && bloque.fila < consolaAlto)
                {
                    Console.SetCursorPosition(bloque.col, bloque.fila);
                    Console.Write(" ");
                }
            }
        }

        public virtual bool Rotar(int cantColumnas, int cantFilas, List<Pieza> piezasFijas)
        {
            List<(int fila, int col)> nuevaPosicion = new List<(int fila, int col)>();

            foreach (var bloque in Bloques)
            {
                int nuevaFila = Centro.fila - (bloque.col - Centro.col);
                int nuevaColumna = Centro.col + (bloque.fila - Centro.fila);

                if (nuevaFila < 0 || nuevaFila >= cantFilas || nuevaColumna < 0 || nuevaColumna >= cantColumnas ||
                    ColisionaConPiezas(nuevaFila, nuevaColumna, piezasFijas))
                {
                    return false;
                }

                nuevaPosicion.Add((nuevaFila, nuevaColumna));
            }

            Bloques = nuevaPosicion;
            return true;
        }
    }
}
