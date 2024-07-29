using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que simule un juego de ahorcado, en el que el usuario debe adivinar una palabra oculta letra por letra.*/

namespace ejer05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> palabras = new List<string> { "programar", "nadar", "estudiar", "rapear" };
            Random random = new Random();
            int randomNum = random.Next(palabras.Count);
            char[] letras = palabras[randomNum].ToCharArray();
            int palabraLong = letras.Length;
            int[] LetrasB = new int[palabraLong];
            int intentos = 6;
            for (int i = 0; i < palabraLong; i++)
            {
                LetrasB[i] = 0;
            }

            bool game = true;
            do
            {
                int letrasActivas = 0;
                Console.WriteLine($"Intentos restantes: {intentos}");
                for (int j = 0; j < palabraLong; j++)
                {
                    if (LetrasB[j] == 0)
                    {
                        Console.Write(" _ ");
                    }
                    else
                    {
                        Console.Write($" {letras[j]} ");
                        letrasActivas++;
                    }
                }
                if(letrasActivas == palabraLong)
                {
                    game = false;
                    Console.WriteLine("\n¡Ganaste!");
                }
                else
                {
                    Console.Write("\nIngresar una letra: ");
                    char letraI = Convert.ToChar(Console.ReadLine());
                    bool comprobar = false;
                    for (int k = 0; k < palabraLong; k++)
                    {
                        if(letraI == letras[k])
                        {
                            LetrasB[k] = 1;
                            comprobar = true;
                        }
                    }

                    if(comprobar == false)
                    {
                        intentos--;
                    }

                    if(intentos == 0)
                    {
                        game = false;
                        Console.WriteLine("\nPerdiste...");
                    }
                }
            }while (game);

            Console.ReadKey();
        }
    }
}
