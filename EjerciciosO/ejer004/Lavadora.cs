using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer004
{
    internal class Lavadora : Electrodomestico
    {
        private double carga;
        private double cargaDefecto;

        public Lavadora()
        {
            carga = cargaDefecto;
        }
        public Lavadora(double carga, double precioBase, double peso) :base(precioBase, peso)
        {
            this.carga = cargaDefecto;
        }
        public Lavadora(double precioBase, string color, char consumoEnergetico, double peso, double carga) :base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public double Carga
        {
            get { return carga; }
        }

        public double getCarga()
        {
            return carga;
        }

        public override double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if(carga > 30)
            {
                precioFinal += 50;
            }
            return precioFinal;
        }
    }
}
