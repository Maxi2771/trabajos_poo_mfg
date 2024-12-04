using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejer002
{
    internal class Persona
    {
        string nombre = "";
        int edad = 0;
        string dni = "";
        char sexo = 'H';
        double peso = 0;
        double altura = 0;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad {  
            get { return edad; } 
            set { edad = value; } 
        }
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public char SEXO
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public double PESO
        {
            get { return peso; }
            set { peso = value; }
        }
        public double ALTURA
        {
            get { return altura; }
            set { altura = value; }
        }

        public Persona()
        {
            GenerarDNI();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            GenerarDNI();
            this.sexo = sexo;
            ComprobarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }

        public int CalcularIMC()
        {
            double imc = peso / (altura * 2);
            if (imc > 20)
            {
                return -1;
            }
            else if (imc > 25 && imc < 20)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool EsMayorDeEdad()
        {
            if (this.edad > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ComprobarSexo(char sexo)
        {
            if (sexo == 'H')
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GenerarDNI()
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            Random r = new Random();
            int dniG = r.Next(0, 100000000);
            dni = dniG.ToString("D8") + letras[dniG % 23];
            DNI = dni;
        }
    }
}
