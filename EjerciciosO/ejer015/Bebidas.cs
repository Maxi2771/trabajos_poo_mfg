using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer015
{
    abstract class Bebidas
    {
        private int id;
        private double litros;
        private double precio;
        private string marca;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Litros
        {
            get { return litros; }
            set { litros = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Bebidas(int id, double litros, double precio, string marca)
        {
            this.id = id;
            this.litros = litros;
            this.precio = precio;
            this.marca = marca;
        }

        public abstract double CalcularPrecio();
        public abstract void MostrarInformacion();
    }
}
