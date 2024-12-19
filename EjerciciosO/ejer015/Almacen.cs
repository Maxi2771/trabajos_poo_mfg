using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer015
{
    internal class Almacen
    {
        List<Bebidas>[] estanterias;
        private int cantEstanterias;

        public int CantEstanterias
        {
            get { return cantEstanterias; }
            set { cantEstanterias = value; }
        }

        public List<Bebidas>[] Estanterias
        {
            get { return estanterias; }
            set { estanterias = value; }
        }

        public Almacen(int cantEstanterias)
        {
            this.cantEstanterias = cantEstanterias;
            estanterias = new List<Bebidas>[cantEstanterias];
            for(int i = 0; i < cantEstanterias; i++)
            {
                estanterias[i] = new List<Bebidas>();
            }
        }

        public void AgregarProducto(Bebidas bebida, int estanteria)
        {
            if (estanteria < 0 || estanteria == cantEstanterias)
            {
                Console.WriteLine("La estanteria está llena");
                return;
            }
            else
            {
                for (int i = 0; i < estanterias[estanteria].Count; i++)
                {
                    if (estanterias[estanteria][i].ID == bebida.ID)
                    {
                        Console.WriteLine("El ID ya existe");
                        return;
                    }
                } 
            }
            estanterias[estanteria].Add(bebida);
            Console.WriteLine("Se ha agregado la bebida");
        }

        public void EliminarProducto(int id)
        {
            for(int i = 0; i < estanterias.Length; i++)
            {
                for (int  j = estanterias[i].Count -1; i > 0; j--)
                {
                    if (estanterias[i][j].ID == id)
                    {
                        estanterias[i].RemoveAt(j);
                        Console.WriteLine("La bebida fue eliminada");
                        return;
                    }
                }
            }
            Console.WriteLine("No se ha encontrado la bebida buscada");
        }

        public double CalcularPrecioTotal()
        {
            double total = 0;
            for (int i = 0; i < estanterias.Length; i++)
            {
                for (int j = 0; j < estanterias[i].Count; j++)
                {
                    total += estanterias[i][j].CalcularPrecio();
                }
            }
            return total;
        }

        public double CalcularPrecioPorMarca(string marca)
        {
            double total = 0;
            for (int i = 0; i < estanterias.Length; i++)
            {
                for (int j = 0; j < estanterias[i].Count; j++)
                {
                    if (estanterias[i][j].Marca.ToLower() == marca.ToLower())
                    {
                        total += estanterias[i][j].CalcularPrecio();
                    }
                }
            }
            return total;
        }

        public double CalcularPrecioEstanteria(int estanteria)
        {
            if(estanteria < 0 || estanteria >= cantEstanterias)
            {
                Console.WriteLine("No es valida");
                return 0;
            }

            double total = 0;
            for(int i = 0; i < estanterias[estanteria].Count;  i++)
            {
                total += estanterias[estanteria][i].CalcularPrecio();
            }
            return total;
        }

        public void MostrarInformacion()
        {
            for(int i = 0;i < estanterias.Length;i++)
            {
                Console.WriteLine($"Estantería: {i}");
                foreach(var bebida in estanterias[i])
                {
                    bebida.MostrarInformacion();
                }
            }
        }
    }
}
