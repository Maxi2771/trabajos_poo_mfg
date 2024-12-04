using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer005
{
    internal class Videojuego
    {
        private string titulo { get; set; }
        private string genero { get; set; }
        private string compania { get; set; }
        private int horasE { get; set; }
        private bool entregado { get; set; }

        public Videojuego(string titulo, string genero, string compania, int horasE)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.compania = compania;
            this.horasE = horasE;
            this.entregado = false;
        }

        public Videojuego(string titulo, int horasE)
        {
            this.titulo = titulo;
            this.genero = "";
            this.compania = "";
            this.horasE = horasE;
            this.entregado = false;
        }

        public Videojuego()
        {
            this.titulo = "";
            this.genero = "";
            this.compania = "";
            this.horasE = 10;
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
            Videojuego videojuego = (Videojuego)a;
            return this.horasE.CompareTo(videojuego.horasE);
        }

        public override string ToString()
        {
            return $"Título: {titulo}, Horas jugadas: {horasE}, Género: {genero}, Compañía: {compania}, Entregado: {entregado}";
        }
    }
}
