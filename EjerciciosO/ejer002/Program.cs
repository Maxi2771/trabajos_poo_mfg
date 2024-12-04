using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            char sexo;
            double peso, altura;
            List<Persona> list = new List<Persona>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese su sexo: ");
                sexo = char.Parse(Console.ReadLine());

                Console.Write("Ingrese su peso: ");
                peso = double.Parse(Console.ReadLine());

                Console.Write("Ingrese su altura: ");
                altura = double.Parse(Console.ReadLine());

                list.Add(new Persona(nombre, edad, sexo, peso, altura));
                Console.Clear();
            }

            Console.WriteLine("Calculo del IMC:  -1 = PI | 0 = DPI | 1 = SP");
            foreach (Persona persona in list)
            {
                Console.WriteLine("La persona esta en " + persona.CalcularIMC());
            }

            Console.WriteLine("¿Es mayor de edad?: true = si | false = no");
            foreach (Persona persona in list)
            {
                Console.WriteLine("La persona esta en " + persona.EsMayorDeEdad());
            }

            foreach (Persona persona in list)
            {
                Console.WriteLine(persona.Nombre + " tiene " + persona.Edad + " años, su DNI es " + persona.DNI + " de sexo " + persona.SEXO + ", pesa " + persona.PESO + " kg, " + " y mide " + persona.ALTURA + " metros.");
            }
            Console.ReadKey();
        }
    }
}
