using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer016
{
    internal class Agenda
    {
        private List<Contacto> contactos;
        private int tamano;
        private int tamanoDefecto = 10;


        public int Tamano
        {
            get { return tamano; }
            set { tamano = value; }
        }

        public Agenda(int tamano)
        {
            contactos = new List<Contacto>();
            this.tamano = tamano;
        }

        public Agenda()
        {
            contactos = new List<Contacto>();
            this.tamano = tamanoDefecto;
        }

        public void AnadirContacto(Contacto c)
        {
            if (!AgendaLlena())
            {
                foreach (Contacto contacto in contactos)
                {
                    if (contacto.Nombre == c.Nombre)
                    {
                        Console.WriteLine("El nombre es duplicado");
                    }
                }
            }
            else
            {
                Console.WriteLine("Agenda llena");
            }
            contactos.Add(c);
            Console.WriteLine("Se ha añadido un nuevo contacto");
        }

        public bool ExisteContacto(Contacto c)
        {
            foreach(Contacto contacto in contactos)
            {
                if(contacto.Telefono == c.Telefono)
                {
                    return true;
                }
            }
            return false;
        }

        public void ListarContactos()
        {
            foreach( Contacto contacto in contactos)
            {
                Console.WriteLine($"{contacto.Nombre} con el número: {contacto.Telefono}");
            }
        }

        public void BuscarContacto(string nombre)
        {
            foreach (Contacto c in contactos)
            {
                if(c.Nombre == nombre)
                {
                    Console.WriteLine($"Se ha encontrado un contacto con el nombre de {nombre} y este es su número {c.Telefono}");
                }
            }
            Console.WriteLine($"No existe el contacto {nombre}");
        }

        public void EliminarContacto(Contacto c)
        {
            for(int i = contactos.Count - 1; i > 0; i--)
            {
                if (contactos[i].Nombre == c.Nombre)
                {
                    contactos.RemoveAt(i);
                    Console.WriteLine($"Se ha eliminado el siguiente contacto {c.Nombre} y su número era {c.Telefono}");
                }
            }
        }

        public bool AgendaLlena()
        {
            bool llena = false;
            if (contactos.Count == tamano)
            {
                return llena = true;
            }
            else
            {
                return llena;
            }
        }

        public int HuecosLibres()
        {
            int sobrante = 0;
            if (AgendaLlena() == false)
            {
                return sobrante = tamano - contactos.Count;
            }
            else
            {
                return sobrante;
            }
        }
    }
}
