using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class PiezaO : Pieza
    {
        public PiezaO(int fila, int col, ConsoleColor color) : base(color)
        {
            Bloques.Add((fila, col));
            Bloques.Add((fila, col + 1));
            Bloques.Add((fila - 1, col));
            Bloques.Add((fila - 1, col + 1));
        }
    }
}
