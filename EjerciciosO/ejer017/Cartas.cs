using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer017
{
    internal class Cartas
    {
        public enum PalosBarEspanola
        {
            OROS,
            COPAS,
            ESPADAS,
            BASTOS
        }

        public enum PalosBarFrancesa
        {
            DIAMANTES,
            PICAS,
            CORAZONES,
            TREBOLES
        }

        public class CartaGenerica<T>
        {
            private T palo;
            private int valor;

            public T Palo
            {
                get { return palo; }
                set { palo = value; }
            }

            public int Valor
            {
                get { return valor; }
                set { valor = value; }
            }

            public CartaGenerica(T palo, int valor)
            {
                this.palo = palo;
                this.valor = valor;
            }

        }
    }
}
