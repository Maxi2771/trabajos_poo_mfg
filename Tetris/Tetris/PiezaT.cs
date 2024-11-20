using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class PiezaT : Pieza
    {
        public PiezaT(int fila, int col, ConsoleColor color) : base(color)
        {
            Bloques.Add((fila, col));
            Bloques.Add((fila, col - 1));
            Bloques.Add((fila, col + 1));
            Bloques.Add((fila - 1, col));
        }
    }
}
