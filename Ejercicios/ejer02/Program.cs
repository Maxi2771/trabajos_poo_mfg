using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, retiros y consultar su saldo.

namespace ejer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double retirar, depositar, consultar, suma, resta = 0;
            Console.Write("Hagamos una simulación de cuanto dinero hay en el cajero: ");
            consultar = double.Parse(Console.ReadLine());
            Console.WriteLine("Buenos días ¿Qué desea hacer? (Depositar, Retirar o Consultar): ");
            string pregunta = Console.ReadLine();
            if (pregunta == "Depositar")
            {
                Console.WriteLine("¿Cuánto desea depositar?");
                depositar = double.Parse(Console.ReadLine());
                suma = consultar + depositar;
                Console.WriteLine("Perfecto se ha depositado " + depositar + " ahora hay " + suma + " en su cuenta");
            }
            else if (pregunta == "Retirar")
            {
                Console.WriteLine("¿Cuánto desea retirar?");
                retirar = double.Parse(Console.ReadLine());
                if (retirar > consultar)
                {
                    Console.WriteLine("No hay suficiente dinero en la cuenta");
                }
                else
                {
                    resta = consultar - retirar;
                    Console.WriteLine("Perfecto se ha retirado " + retirar + " ahora hay " + resta + " en su cuenta");
                }
            }
            else if (pregunta == "Consultar")
            {
                Console.WriteLine("En su cuenta hay " + consultar + " de dinero");
            }
            else
            {
                Console.WriteLine("Su respuesta no es parte de las opciones (Depositar, Retirar o Consultar)");
            }
            Console.ReadKey();
        }
    }
}
