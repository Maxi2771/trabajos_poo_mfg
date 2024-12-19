using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer016
{
    internal class Contacto
    {
        private string nombre;
        private int telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }
    }
}
