using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int opcion;
            do
            {
                Console.WriteLine("Opciones del programa");
                Console.WriteLine("1 Añadir Contacto");
                Console.WriteLine("2 Existe Contacto");
                Console.WriteLine("3 Listar Contactos");
                Console.WriteLine("4 Buscar Contactos");
                Console.WriteLine("5 Eliminar Contactos");
                Console.WriteLine("6 Agenda Llena");
                Console.WriteLine("7 Huecos Libres");
                Console.WriteLine("0 Salir");

                Console.WriteLine("\nIngresar opción (0-7)");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresar un nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingresar teléfono");
                        int telefono = int.Parse(Console.ReadLine());
                        agenda.AnadirContacto(new Contacto(nombre, telefono));
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresar un nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingresar teléfono");
                        telefono = int.Parse(Console.ReadLine());
                        if(agenda.ExisteContacto(new Contacto(nombre, telefono)))
                        {
                            Console.WriteLine($"{nombre} con el número {telefono} existe");
                        }
                        else
                        {
                            Console.WriteLine($"El nombre o número no existe");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        agenda.ListarContactos();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingresar un nombre");
                        nombre = Console.ReadLine();
                        agenda.BuscarContacto(nombre);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ingresar un nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingresar teléfono");
                        telefono = int.Parse(Console.ReadLine());
                        agenda.EliminarContacto(new Contacto(nombre, telefono));
                        break;
                    case 6:
                        Console.Clear();
                        if (agenda.AgendaLlena())
                        {
                            Console.WriteLine("La agenda está llena");
                        }
                        else
                        {
                            Console.WriteLine("La agenda NO está llena");
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine($"Espacio libre: {agenda.HuecosLibres()}");
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Programa terminado");
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
            } while (opcion != 0);

            Console.ReadKey();
        }
    }
}
