using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer008
{
    internal class Aula
    {
        List<int> id = new List<int>();
        private int maxEstudiantes;
        private string materia, nombreP;
        private bool claseE;

        public List<int> ID { 
            get { return id; } 
            set { id = value; }
        }
        public int NumMaxEstudiantes { 
            get { return maxEstudiantes; } 
            set { maxEstudiantes = value; } 
        }
        public string Materia { 
            get { return materia; } 
            set { materia = value; } 
        }
        public string NombreProf { 
            get { return nombreP; } 
            set { nombreP = value; } 
        }
        public bool ClaseE { 
            get { return claseE; } 
            set { claseE = value; } 
        }

        public Aula(int id, int maxEstudiantes, string materia, string nombreP, bool claseE)
        {
            this.id.Add(id);
            this.maxEstudiantes = maxEstudiantes;
            this.materia = materia;
            this.nombreP = nombreP;
            this.claseE = claseE;
        }
    }
}
