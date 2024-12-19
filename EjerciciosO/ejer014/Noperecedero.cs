using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    internal class Noperecedero : Productos
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Noperecedero(string nombre, double precio, string tipo) : base(nombre, precio)
        {
            this.tipo = tipo;
        }

        public override double Calcular(double cant)
        {
            return base.Calcular(cant);
        }

        public override string ToString()
        {
            return base.ToString() + $", Tipo: {tipo}";
        }
    }
}
