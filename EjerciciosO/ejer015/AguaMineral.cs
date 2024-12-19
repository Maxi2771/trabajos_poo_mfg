using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer015
{
    internal class AguaMineral : Bebidas
    {
        private string origen;

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public AguaMineral(int id, double litros, double precio, string marca, string origen) : base(id, litros, precio, marca)
        {
            this.origen = origen;
        }

        public override double CalcularPrecio()
        {
            return Precio * Litros;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"ID: {ID} Litros: {Litros} Precio: {Precio} Marca: {Marca} Origen: {origen}");
        }
    }
}
