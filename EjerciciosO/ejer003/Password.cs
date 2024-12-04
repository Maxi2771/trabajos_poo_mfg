using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer003
{
    internal class Password
    {
        private int longitud;
        private string contrasena;
        private static Random r = new Random();

        public string obtenerPassword()
        {
            return contrasena;
        }

        public Password()
        {
            longitud = 8;
        }

        public Password(int longitud)
        {
            this.longitud = longitud;
        }

        public bool esFuerte()
        {
            int mayus = 0, minus = 0, numeros = 0;
            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) mayus++;
                else if (char.IsLower(c)) minus++;
                else if (char.IsDigit(c)) numeros++;
            }
            return (mayus > 2 && minus > 1 && numeros > 5);
        }

        public void generarPassword()
        {
            string carecteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder pb = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int num = r.Next(carecteres.Length);
                pb.Append(carecteres[num]);
            }
            contrasena = pb.ToString();
        }
    }
}
