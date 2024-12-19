using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012
{
    internal class Revolver
    {
        private int posicionActual;
        private int posicionBala;

        public int PosicionActual
        {
            get { return posicionActual; }
            set { posicionActual = value; }
        }

        public int PosicionBala
        {
            get { return posicionBala; }
            set { posicionBala = value; }
        }

        public Revolver()
        {
            Random r = new Random();
            posicionActual = r.Next(1, 9);
            posicionBala = r.Next(1, 9);
        }

        public bool Disparar()
        {
            return posicionBala == posicionActual;
        }

        public void SiguienteBala()
        {
            posicionActual++;
            if(posicionActual > 8)
            {
                posicionActual = 1;
            }
        }
    }
}
