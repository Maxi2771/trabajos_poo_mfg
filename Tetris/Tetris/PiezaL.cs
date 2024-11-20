using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class PiezaL : Pieza
    {
        public PiezaL(int filaInicial, int colInicial, ConsoleColor color) : base(color)
        {
            Bloques.Add((filaInicial, colInicial));
            Bloques.Add((filaInicial + 1, colInicial));
            Bloques.Add((filaInicial + 2, colInicial));
            Bloques.Add((filaInicial + 2, colInicial + 1));
            Centro = (filaInicial + 1, colInicial);
        }
    }
}
