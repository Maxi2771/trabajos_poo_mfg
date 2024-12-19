using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer017
{
    abstract class Baraja
    {
        private int cartasTotal;
        private int cartasPalo;

        public int CartasTotal
        {
            get { return cartasTotal; }
            set { cartasTotal = value; }
        }

        public int CartasPalo
        {
            get { return cartasPalo; }
            set { cartasPalo = value; }
        }

        public Baraja(int cartasTotal, int cartasPalo)
        {
            this.cartasTotal = cartasTotal;
            this.cartasPalo = cartasPalo;
        }

        //public abstract void CrearBaraja();
    }
}
