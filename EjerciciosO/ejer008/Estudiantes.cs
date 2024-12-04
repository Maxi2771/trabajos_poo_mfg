using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer008
{
    internal class Estudiantes
    {
        string nombre, sexo;
        int edad, faltas;
        double calificacion;
        bool presente;


        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; } 
        }
        public int Edad { 
            get { return edad; } 
            set { edad = value; } 
        }
        public string Sexo { 
            get { return sexo; } 
            set { sexo = value; } 
        }
        public double Calificacion { 
            get { return calificacion; } 
            set { calificacion = value; } 
        }
        public bool Presente { 
            get { return presente; } 
            set { presente = value; } 
        }
        public int Faltas { 
            get { return faltas; } 
            set { faltas = value; } 
        }

        public Estudiantes(string nombre, int edad, string sexo, double calificacion, bool presente, int faltas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.calificacion = calificacion;
            this.presente = presente;
            this.faltas = faltas;
        }
    }
}
