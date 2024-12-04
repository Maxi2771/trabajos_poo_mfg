using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer010
{
    internal class Cartas
    {
        private int numero; 
        private string palo;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Palo
        {
            get { return palo; }
            set { palo = value; }
        }

        public Cartas(int numero, string palo)
        {
            this.numero = numero;
            this.Palo = palo;
        }

        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }
}
