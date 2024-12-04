using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer005
{
    internal class Serie
    {
        private string titulo { get; set; }
        private string genero { get; set; }
        private string creador { get; set; }
        private bool entregado { get; set; }
        private int numT { get; set; }

        public Serie(string Titulo, string Genero, string Creador, int NumT)
        {
            this.titulo = Titulo;
            this.genero = Genero;
            this.creador = Creador;
            this.entregado = false;
            this.numT = NumT;
        }

        public Serie(string Titulo, string Creador)
        {
            this.titulo = Titulo;
            this.genero = "";
            this.creador = Creador;
            this.entregado = false;
            this.numT = 3;
        }

        public Serie()
        {
            this.titulo = "";
            this.genero = "";
            this.creador = "";
            this.numT = 3;
        }

        public void Entregar()
        {
            this.entregado = true;
        }

        public void Devolver()
        {
            this.entregado = false;
        }

        public bool IsEntregado()
        {
            return this.entregado;
        }

        public int CompareTo(object a)
        {
            Serie serie = (Serie)a;
            return this.numT.CompareTo(serie.numT);
        }

        public override string ToString()
        {
            return $"Título: {titulo}, Temporadas: {numT}, Género: {genero}, Creador: {creador}, Entregado: {entregado}";
        }
    }
}
