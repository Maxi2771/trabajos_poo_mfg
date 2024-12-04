using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer009
{
    internal class Espectador
    {
        private string nombre;
        private int edad;
        private double dinero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public Espectador(string nombre, int edad, double dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }
    }
}
