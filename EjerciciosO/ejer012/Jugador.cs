using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer012
{
    internal class Jugador
    {
        private int id;
        private string nombre;
        private bool vivo;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Vivo
        {
            get { return vivo; }
            set { vivo = value; }
        }

        public Jugador(int id)
        {
            this.id = id;
            nombre = $"Jugador {id}";
            vivo = true;
        }

        public bool Disparar(Revolver revolver)
        {
            if (vivo)
            {
                Console.WriteLine($"{nombre} se prepara");
                if (revolver.Disparar())
                {
                    vivo = false;
                    Console.WriteLine($"{nombre} ha muerto");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{nombre} sigue vivo");
                }
            }
            return false;
        }
    }
}
