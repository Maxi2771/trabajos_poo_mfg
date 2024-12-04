using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer005
{
    internal interface Entregable
    {
        void Entregar();
        void Devolver();
        bool IsEntregado();
        int CompareTo(object a);
    }
}
