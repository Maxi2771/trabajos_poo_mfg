using System.Collections.Generic;
using System;
//Crear un programa que permita al usuario ingresar una lista de tareas y organizarlas por orden de prioridad.

class Tarea
{
    private string tarea;
    private int prioridad;

    public Tarea(string tareas, int prioridades)
    {
        this.tarea = tareas;
        this.prioridad = prioridades;
    }

    public string Descripcion
    {
        get { return tarea; }
        set { tarea = value; }
    }

    public int Prioridad
    {
        get { return prioridad; }
        set { prioridad = value; }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        List<Tarea> lista = new List<Tarea>();
        bool pregunta = true;
        string tarea, respuesta, respuesta2, respuesta3;
        int prioridad;

        while (pregunta)
        {
            Console.Clear();
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("Agregar tareas (at) / Eliminar tareas (ea) / Ordenar tareas (oa) / Salir (s)");
            respuesta = Console.ReadLine();
            respuesta = respuesta.ToLower();

            switch (respuesta)
            {
                case "at":
                    bool agregarMasTareas = true;
                    while (agregarMasTareas)
                    {
                        Console.Clear();
                        Console.Write("Ingrese la nueva tarea: ");
                        tarea = Console.ReadLine();
                        Console.Write("Ingrese el nivel de prioridad de la tarea \n Nivel 1 (1) / Nivel 2 (2) / Nivel 3 (3): ");
                        prioridad = int.Parse(Console.ReadLine());
                        tarea = tarea.ToLower();
                        if (prioridad >= 1 && prioridad <= 3)
                        {
                            lista.Add(new Tarea(tarea, prioridad));
                            foreach (var tareas in lista)
                            {
                                Console.WriteLine($"Tarea: {tareas.Descripcion}, Nivel: {tareas.Prioridad}");
                            }
                            Console.Write("¿Desea agregar otra tarea? (sí/no): ");
                            respuesta2 = Console.ReadLine();
                            respuesta2 = respuesta2.ToLower();
                            if (respuesta2 == "no")
                            {
                                agregarMasTareas = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Prioridad no valida");
                        }
                    }
                    break;
                case "ea":
                    bool eliminarMasTareas = true;
                    while (eliminarMasTareas)
                    {
                        Console.Clear();
                        Console.Write("Ingrese la tarea a eliminar: ");
                        tarea = Console.ReadLine();

                        for (int i = lista.Count - 1; i >= 0; i--)
                        {
                            if (tarea == lista[i].Descripcion)
                            {
                                lista.RemoveAt(i);
                            }
                        }

                        Console.WriteLine("Lista de tareas actualizada:");
                        foreach (Tarea tareas in lista)
                        {
                            Console.WriteLine($"Tarea: {tareas.Descripcion}, Nivel: {tareas.Prioridad}");
                        }

                        Console.Write("¿Desea eliminar otra tarea? (sí/no): ");
                        respuesta2 = Console.ReadLine();
                        respuesta2 = respuesta2.ToLower();
                        if (respuesta2 == "no")
                        {
                            eliminarMasTareas = false;
                        }
                    }
                    break;
                case "oa":
                    Console.Clear();
                    Console.WriteLine("¿Cómo quiere ordenar la lista?");
                    Console.WriteLine("Ascendente (a) / Descendente (d)");
                    respuesta3 = Console.ReadLine().ToLower();

                    if (respuesta3 == "a")
                    {
                        lista.Sort((descripcion, nivel) => descripcion.Prioridad.CompareTo(nivel.Prioridad));
                        Console.WriteLine("Lista ordenada en orden ascendente por prioridad:");
                    }
                    else if (respuesta3 == "d")
                    {
                        lista.Sort((descripcion, nivel) => nivel.Prioridad.CompareTo(descripcion.Prioridad));
                        Console.WriteLine("Lista ordenada en orden descendente por prioridad:");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida.");
                    }

                    foreach (var tareas in lista)
                    {
                        Console.WriteLine($"Tarea: {tareas.Descripcion}, Nivel: {tareas.Prioridad}");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "s":
                    pregunta = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
        Console.WriteLine("Terminó el programa :(");
        Console.ReadKey();
    }
}