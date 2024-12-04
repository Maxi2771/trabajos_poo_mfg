using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer009
{
    internal class Pelicula
    {
        private string titulo;
        private string duracion;
        private int edadMinima;
        private string director;
        private double precio;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int EdadMinima
        {
            get { return edadMinima; }
            set { edadMinima = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Pelicula(string titulo, string duracion, int edadMinima, string director, double precio)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edadMinima = edadMinima;
            this.director = director;
            this.precio = precio;
        }
    }
}
