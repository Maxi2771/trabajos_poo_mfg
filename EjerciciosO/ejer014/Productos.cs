using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    internal class Productos
    {
        private string nombre;
        private double precio;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Productos(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public virtual double Calcular(double cant)
        {
            return precio * cant;
        }

        public override string ToString()
        {
            return $"Producto: {nombre}, Precio: {precio:C}";
        }
    }
}
