using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que permita al usuario convertir una cantidad de una unidad de medida a otra, por ejemplo, de metros a pies.*/

namespace ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            string respuesta, sistema;
            Console.WriteLine("¿Qué quiere medir? (longitud / clima / tiempo)");
            respuesta = Console.ReadLine();
            respuesta = respuesta.ToLower();
            if (respuesta == "longitud")
            {
                Console.Clear();
                Console.Write("Por default esta en metros la medida \nIngrese un número: ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el sistema de medida al que desea pasar {num} metros \n kilometro, centimetro, milimetro, pie, pulgada");
                sistema = Console.ReadLine();
                sistema = sistema.ToLower();
                switch (sistema)
                {
                    case "kilometro":
                        double kilometro = num / 1000;
                        Console.WriteLine($"{num} metro/s = {kilometro} kilometro/s");
                        break;
                    case "centimetro":
                        double centimetro = num * 100;
                        Console.WriteLine($"{num} metro/s = {centimetro} centimetro/s");
                        break ;
                    case "milimetro":
                        double milimetro = num * 1000;
                        Console.WriteLine($"{num} metro/s = {milimetro} milimetro/s");
                        break ;
                    case "pie":
                        double pie = num * 3.28084;
                        Console.WriteLine($"{num} metro/s = {pie} pie/s");
                        break ;
                    case "pulgada":
                        double pulgada = num * 39.3701;
                        Console.WriteLine($"{num} metro/s = {pulgada} pulgada/s");
                        break ;
                    default: 
                        Console.WriteLine($"{num} metro/s");
                        break ;
                }
            }
            else if(respuesta == "clima")
            {
                Console.Clear();
                Console.Write("Por default esta en Grados Celsius \nIngrese un número: ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el sistema de medida al que desea pasar {num}ºC fahrenheit (F)  / kelvin (K)");
                sistema = Console.ReadLine();
                sistema= sistema.ToUpper();
                switch (sistema)
                {
                    case "F":
                        double fahrenheit = (num * 1.8) + 32;
                        Console.WriteLine($"{num}ºC = {fahrenheit}ºF");
                        break;
                    case "K":
                        double kelvin = num + 273.15 ;
                        Console.WriteLine($"{num}ºC = {kelvin}ºK");
                        break ;
                    default:
                        Console.WriteLine($"{num}ºC");
                        break ;
                }
            }
            else if(respuesta == "tiempo")
            {
                Console.Clear();
                Console.Write("Por default esta en Minutos \nIngrese un número: ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Ingrese el sistema de medida al que desea pasar {num} minuto/s \nSegundo / Hora / Día / Semana / Mes / Año ");
                sistema = Console.ReadLine();
                sistema= sistema.ToLower();
                switch (sistema)
                {
                    case "segundo":
                        double segundo = num * 60;
                        Console.WriteLine($"{num} minuto/s = {segundo} segundo/s");
                        break;
                    case "hora":
                        double hora = num / 60;
                        Console.WriteLine($"{num} minuto/s = {hora} hora/s");
                        break ;
                    case "dia":
                        double dia = num / 1440;
                        Console.WriteLine($"{num} minuto/s = {dia} dia/s");
                        break;
                    case "semana":
                        double semana = num / 10080;
                        Console.WriteLine($"{num} minuto/s = {semana} semana/s");
                        break;
                    case "mes":
                        double mes = num / 43800;
                        Console.WriteLine($"{num} minuto/s = {mes} mes/es");
                        break;
                    case "año":
                        double ano = num / 525600;
                        Console.WriteLine($"{num} minuto/s = {ano} año/s");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
