using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejer017.Cartas;

namespace ejer017
{
    internal class BarajaFrancesa : Baraja
    {
        public BarajaFrancesa(int cartasTotal, int cartasPalo):base(cartasTotal, cartasPalo)
        {
            
        }

        public void JugarCartas()
        {
            CartasTotal = 52;
            CartasPalo = 13;
        }

        public bool CartaRoja(CartaGenerica<PalosBarFrancesa> c)
        {
            if(c.Palo == PalosBarFrancesa.CORAZONES || c.Palo == PalosBarFrancesa.DIAMANTES)
            {
                return true;
            }
            else
                return false;
        }

        public bool CartaNegra(CartaGenerica<PalosBarFrancesa> c)
        {
            if (c.Palo == PalosBarFrancesa.PICAS || c.Palo == PalosBarFrancesa.TREBOLES)
            {
                return true;
            }
            else
                return false;
        }

        public string ObtenerCarta(CartaGenerica<PalosBarFrancesa> francesa, CartaGenerica<PalosBarEspanola> española)
        {
            if (francesa.Palo == PalosBarFrancesa.TREBOLES || francesa.Palo == PalosBarFrancesa.DIAMANTES || francesa.Palo == PalosBarFrancesa.CORAZONES || francesa.Palo == PalosBarFrancesa.PICAS)
            {
                switch (francesa.Valor)
                {
                    case 1: 
                        return "As";
                    case 11: 
                        return "Jota";
                    case 12: 
                        return "Reina";
                    case 13: 
                        return "Rey";
                    default: 
                        return francesa.Valor.ToString();
                }
            }
            else if (española.Palo == PalosBarEspanola.OROS || española.Palo == PalosBarEspanola.COPAS || española.Palo == PalosBarEspanola.ESPADAS || española.Palo == PalosBarEspanola.BASTOS)
            {
                switch (española.Valor)
                {
                    case 1: 
                        return "As";
                    case 11: 
                        return "Sota";
                    case 12: 
                        return "Caballo";
                    case 13: 
                        return "Rey";
                    default: 
                        return española.Valor.ToString();
                }
            }
            else
                return "Carta no valida";
        }
    }
}
