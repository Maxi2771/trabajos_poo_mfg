using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tetris
{
    internal class Program
    {
        static int cantFilas = 20;
        static int cantColumnas = 10;
        static List<Pieza> piezasFijas = new List<Pieza>();
        static Random r = new Random();
        static ConsoleColor[] colores = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow };
        static Pieza piezaActual = null;
        static Stopwatch stopwatch = new Stopwatch();
        static TimeSpan tiempoCaida = TimeSpan.FromMilliseconds(150);

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            stopwatch.Start();

            while (true)
            {
                if (piezaActual == null)
                {
                    piezaActual = GenerarNuevaPieza();
                    piezaActual.Dibujar();
                }

                if (stopwatch.Elapsed >= tiempoCaida)
                {
                    stopwatch.Restart();
                    piezaActual.Borrar();
                    piezaActual.MoverAbajo();
                    if (ColisionConFondo(piezaActual) || ColisionConPiezasAbajo(piezaActual))
                    {
                        piezaActual.Dibujar();
                        piezasFijas.Add(piezaActual);
                        EliminarFilasCompletas();
                        piezaActual = null;
                    }
                    else
                    {
                        piezaActual.Dibujar();
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    piezaActual.Borrar();

                    if (tecla.Key == ConsoleKey.LeftArrow)
                    {
                        piezaActual.MoverLateral(-1, cantColumnas, piezasFijas);
                    }
                    else if (tecla.Key == ConsoleKey.RightArrow)
                    {
                        piezaActual.MoverLateral(1, cantColumnas, piezasFijas);
                    }
                    else if (tecla.Key == ConsoleKey.Spacebar)
                    {
                        piezaActual.Rotar(cantColumnas, cantFilas, piezasFijas);
                    }

                    piezaActual.Dibujar();
                }
            }
        }

        static Pieza GenerarNuevaPieza()
        {
            int tipoPieza = r.Next(0, 4);
            ConsoleColor colorAleatorio = colores[r.Next(0, colores.Length)];

            switch (tipoPieza)
            {
                case 0: 
                    return new PiezaL(0, r.Next(0, cantColumnas), colorAleatorio);
                case 1: 
                    return new PiezaI(0, r.Next(0, cantColumnas), colorAleatorio);
                case 2: 
                    return new PiezaT(0, r.Next(0, cantColumnas), colorAleatorio);
                case 3: 
                    return new PiezaO(0, r.Next(0, cantColumnas), colorAleatorio);
                default: 
                    return new PiezaL(0, r.Next(0, cantColumnas), colorAleatorio);
            }
        }

        static bool ColisionConFondo(Pieza pieza)
        {
            foreach (var bloque in pieza.Bloques)
            {
                if (bloque.fila >= cantFilas - 1)
                {
                    return true;
                }
            }
            return false;
        }

        static bool ColisionConPiezasAbajo(Pieza pieza)
        {
            foreach (var bloque in pieza.Bloques)
            {
                if (pieza.ColisionaConPiezas(bloque.fila + 1, bloque.col, piezasFijas))
                {
                    return true;
                }
            }
            return false;
        }

        static void EliminarFilasCompletas()
        {
            for (int fila = 0; fila < cantFilas; fila++)
            {
                if (FilaCompleta(fila))
                {
                    EliminarFila(fila);
                    MoverPiezasHaciaAbajo(fila);
                }
            }
        }

        static bool FilaCompleta(int fila)
        {
            int bloquesEnFila = 0;
            foreach (var pieza in piezasFijas)
            {
                foreach (var bloque in pieza.Bloques)
                {
                    if (bloque.fila == fila) bloquesEnFila++;
                }
            }
            return bloquesEnFila == cantColumnas;
        }

        static void EliminarFila(int fila)
        {
            foreach (var pieza in piezasFijas)
            {
                pieza.Bloques.RemoveAll(b => b.fila == fila);
            }

            for (int col = 0; col < cantColumnas; col++)
            {
                Console.SetCursorPosition(col, fila);
                Console.Write(" ");
            }
        }

        static void MoverPiezasHaciaAbajo(int filaEliminada)
        {
            foreach (var pieza in piezasFijas)
            {
                for (int i = 0; i < pieza.Bloques.Count; i++)
                {
                    if (pieza.Bloques[i].fila < filaEliminada)
                    {
                        pieza.Bloques[i] = (pieza.Bloques[i].fila + 1, pieza.Bloques[i].col);
                    }
                }
            }

            RedibujarPiezas();
        }

        static void RedibujarPiezas()
        {
            foreach (var pieza in piezasFijas)
            {
                pieza.Borrar();
                pieza.Dibujar();
            }
        }
    }
}