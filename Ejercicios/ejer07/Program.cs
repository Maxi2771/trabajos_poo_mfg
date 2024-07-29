using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que permita al usuario ingresar una serie de números y determine cuál es el número más grande y cuál es el número más pequeño.*/

namespace ejer07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, cant;
            List<int> serieN = new List<int>();
            Console.Write("¿Cuántos números desea ingresar? ");
            cant = int.Parse(Console.ReadLine());
            for (int i = 0; i < cant; i++)
            {
                Console.Clear();
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
                serieN.Add(num);
            }

            int numMax = serieN[0];
            int numMin = serieN[0]; 
            foreach (int x in serieN)
            {
                if(x > numMax)
                {
                    numMax = x;
                }
                if(x < numMin)
                {
                    numMin = x;
                }
            }
            Console.Write($"Número mayor: {numMax} \nNúmero menor: {numMin}");
            Console.ReadKey();
        }
    }
}
