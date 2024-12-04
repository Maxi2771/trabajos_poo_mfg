using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosO
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }

        public void Ingresar(double cant)
        {
            if (cant > 0)
            {
                cantidad += cant;
            }
        }

        public void Retirar(double cant)
        {
            if (cant > 0)
            {
                cantidad -= cant;
                if (cant < 0)
                {
                    cantidad = 0;
                }
            }
        }

        public string Mostrar()
        {
            return $"Titular {titular}, Cantidad {cantidad}";
        }
    }
}
