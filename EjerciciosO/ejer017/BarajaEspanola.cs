using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer017
{
    class BarajaEspanola : Baraja
    {
        private bool jugar = false;

        public bool Jugar
        {
            get { return jugar; }
            set { jugar = value; }
        }

        public BarajaEspanola(int cartasTotal, int cartasPalo, bool jugar):base(cartasTotal,cartasPalo)
        {
            this.jugar = jugar;
        }

        public void JugarCartas(bool jugarC)
        {
            if (jugarC)
            {
                CartasTotal = 48;
            }
            else
            {
                CartasTotal = 40;
            }
        }
    }
}
