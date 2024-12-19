using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer013
{
    public abstract class Empleados
    {
        private string nombre;
        private int edad;
        private double salario;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public abstract void Plus();

        public Empleados(string nombre, int edad, double salario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
        }
    }
}
