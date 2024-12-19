using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer013
{
    internal class Repartidor : Empleados
    {
        private string zona;
        private const double plus = 300;

        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public Repartidor(string nombre, int edad, double salario, string zona) : base(nombre, edad, salario)
        {
            this.zona = zona;
        }

        public override void Plus()
        {
            if(Edad < 25 && Zona == "Zona 3")
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
