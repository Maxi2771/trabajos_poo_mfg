using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer011
{
    internal class Partido : IResultado
    {
        private string[] equipos;

        public Partido(string[] equipos)
        {
            this.equipos = equipos;
        }

        public string Enfrentamiento(Random r)
        {
            return $"{equipos[r.Next(0, equipos.Length)]} VS {equipos[r.Next(0,equipos.Length)]}";
        }

        public string Resultado(Random r)
        {
            return $"{r.Next(0, 6)}-{r.Next(0, 6)}";
        }
    }
}
