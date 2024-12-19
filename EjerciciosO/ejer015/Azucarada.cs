using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer015
{
    internal class Azucarada : Bebidas
    {
        private double porcentaje;
        private bool promocion = false;

        public double Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }

        public bool Promocion
        {
            get { return promocion; }
            set { promocion = value; }
        }

        public Azucarada(int id, double litros, double precio, string marca, double porcentaje, bool promocion) :base(id, litros, precio, marca)
        {
            this.porcentaje = porcentaje;
            this.promocion = promocion;
        }

        public override double CalcularPrecio()
        {
            double precioFinal = Precio * Litros;
            if(promocion)
            {
                precioFinal *= 0.1;
            }
            return precioFinal;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {ID} Litros: {Litros} Precio: {Precio} Marca: {Marca} Porcentaje: {Porcentaje} Promoción: {promocion}");
        }
    }
}
