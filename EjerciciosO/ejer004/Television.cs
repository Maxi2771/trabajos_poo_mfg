using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer004
{
    internal class Television : Electrodomestico
    {
        private int resolucion;
        private bool sintonizadorTDT;
        private int resolucionDefecto = 20;
        private bool sintonizadorTDT_Defecto = false;

        public Television()
        {
            this.resolucion = resolucionDefecto;
            this.sintonizadorTDT = sintonizadorTDT_Defecto;
        }

        public Television(double precioBase, double peso, int resolucion, bool sintonizadorTDT) : base(precioBase, peso)
        {
            this.resolucion = resolucionDefecto;
            this.sintonizadorTDT = sintonizadorTDT_Defecto;
        }

        public Television(double precioBase, string color, char consumoEnergetico, double peso, int resolucion, bool sintonizadorTDT) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public int Resolcion
        {
            get { return resolucion; }
        }

        public bool SintonizadorTDT
        {
            get { return sintonizadorTDT; }
        }

        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (resolucion > 40)
            {
                precioFinal += precioFinal * 0.30;
            }

            if (sintonizadorTDT)
            {
                precioFinal += 50;
            }
            return precioFinal;
        }
    }
}
