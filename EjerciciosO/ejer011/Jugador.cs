using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer011
{
    internal class Jugador : IResultado
    {
        private string nombre;
        private int id;
        private float dinero;
        private int rondasGanadas = 0;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public float Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public int RondasGanadas
        {
            get { return rondasGanadas; }
            set { rondasGanadas = value; }
        }

        public Jugador(int id, float dinero, string nombre)
        {
            this.id = id;
            this.dinero = dinero;
            this.nombre = nombre;
        }

        public bool PuedeApostar()
        {
            return dinero >= 100;
        }

        public string Resultado(Random r)
        {
            return $"{r.Next(0,6)}-{r.Next(0,6)}";
        }
    }
}
