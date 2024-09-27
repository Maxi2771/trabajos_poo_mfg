using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que simule una biblioteca, permitiendo al usuario buscar y prestar libros, y llevando un registro de los préstamos y devoluciones.*/

namespace ejer08
{
    public class Libro
    {
        public string Titulo { get; set; }
        public bool Prestado { get; set; }

        public Libro(string titulo)
        {
            Titulo = titulo;
            Prestado = false;
        }

        public override string ToString()
        {
            return $"{Titulo} - {(Prestado ? "Prestado" : "Disponible")}";
        }
    }

    public class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();

        public Biblioteca()
        {
            libros.Add(new Libro("Las mil y una noches"));
            libros.Add(new Libro("El Quijote"));
            libros.Add(new Libro("El Principito"));
            libros.Add(new Libro("1984"));
        }

        public void MostrarLibros()
        {
            Console.WriteLine("Libros en la biblioteca:");
            foreach (var libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        public Libro BuscarLibro(string titulo)
        {
            foreach (Libro libro in libros)
            {
                if (libro.Titulo.ToLower() == titulo.ToLower())
                {
                    return libro;
                }
            }
            return null;
        }

        public void PrestarLibro(string titulo)
        {
            var libro = BuscarLibro(titulo);
            if (libro == null)
            {
                Console.WriteLine("\nEl libro no está disponible en la biblioteca.");
            }
            else if (libro.Prestado)
            {
                Console.WriteLine($"\nEl libro '{titulo}' ya está prestado.");
            }
            else
            {
                libro.Prestado = true;
                Console.WriteLine($"\nHas prestado el libro '{titulo}'.");
            }
        }

        public void DevolverLibro(string titulo)
        {
            var libro = BuscarLibro(titulo);
            if (libro == null)
            {
                Console.WriteLine("\nEl libro no está disponible en la biblioteca.");
            }
            else if (!libro.Prestado)
            {
                Console.WriteLine($"\nEl libro '{titulo}' no está prestado.");
            }
            else
            {
                libro.Prestado = false;
                Console.WriteLine($"\nHas devuelto el libro '{titulo}'.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            string opcion;

            do
            {
                Console.WriteLine("--- Opciones ---");
                Console.WriteLine("1. Mostrar todos los libros");
                Console.WriteLine("2. Buscar libro");
                Console.WriteLine("3. Prestar libro");
                Console.WriteLine("4. Devolver libro");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        biblioteca.MostrarLibros();
                        break;

                    case "2":
                        Console.Clear();
                        biblioteca.MostrarLibros();
                        Console.Write("\nIngresa el título del libro que deseas buscar: ");
                        string tituloBuscar = Console.ReadLine();
                        var libroEncontrado = biblioteca.BuscarLibro(tituloBuscar);
                        if (libroEncontrado != null)
                        {
                            Console.WriteLine($"\nLibro encontrado: {libroEncontrado}");
                        }
                        else
                        {
                            Console.WriteLine("\nLibro no encontrado.");
                        }
                        break;

                    case "3":
                        Console.Clear();
                        biblioteca.MostrarLibros();
                        Console.Write("\nIngresa el título del libro que deseas prestar: ");
                        string tituloPrestar = Console.ReadLine();
                        biblioteca.PrestarLibro(tituloPrestar);
                        break;

                    case "4":
                        Console.Clear();
                        biblioteca.MostrarLibros();
                        Console.Write("\nIngresa el título del libro que deseas devolver: ");
                        string tituloDevolver = Console.ReadLine();
                        biblioteca.DevolverLibro(tituloDevolver);
                        break;

                    case "5":
                        Console.WriteLine("\nSaliendo...");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }

            } while (opcion != "5");
        }
    }
}
