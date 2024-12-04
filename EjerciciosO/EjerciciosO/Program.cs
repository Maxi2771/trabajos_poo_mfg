using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Máximo");
            cuenta1.Ingresar(499.99);
            cuenta1.Retirar(299.99);
            Console.WriteLine(cuenta1.Mostrar());

            Cuenta cuenta2 = new Cuenta("Lu", 500);
            cuenta1.Ingresar(499.99);
            cuenta1.Retirar(299.99);
            Console.WriteLine(cuenta2.Mostrar());
            Console.ReadKey();
        }
    }
}
