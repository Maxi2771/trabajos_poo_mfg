using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer013
{
    internal class Comercial : Empleados
    {
        private double comision;
        private const double plus = 300;

        public double Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public Comercial(string nombre, int edad, double salario, double comision):base(nombre, edad, salario)
        {
            this.comision = comision;
        }

        public override void Plus()
        {
            if (Edad > 30 && Comision > 200)
            {
                Salario += plus;
                Console.WriteLine($"{Nombre} ha recibido un plus y su nuevo salario será {Salario}");
            }
            else
            {
                Console.WriteLine($"{Nombre} no cumple los requisitos para darle un plus");
            }
        }
    }
}
