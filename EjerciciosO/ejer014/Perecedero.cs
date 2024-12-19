using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    internal class Perecedero : Productos
    {
        private int diasCaducar;

        public int DiasCaducar
        {
            get { return diasCaducar; }
            set { diasCaducar = value; }
        }

        public Perecedero(string nombre, double precio, int diasCaducar) : base(nombre, precio)
        {
            this.diasCaducar = diasCaducar;
        }

        public override double Calcular(double cant)
        {
            double preciofinal = base.Calcular(cant);
            if(diasCaducar == 1)
            {
                preciofinal /= 4;
            }
            else if(diasCaducar == 2)
            {
                preciofinal /= 3;
            }
            else if(diasCaducar == 3)
            {
                preciofinal /= 2;
            }
            return preciofinal;
        }

        public override string ToString()
        {
            return base.ToString() + $", Días a caducar: {diasCaducar}";
        }
    }
}
