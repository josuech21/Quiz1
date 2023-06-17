using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.Nodo
{
    public class NodoInt : Nodo<int,NodoInt>
    {
        public override int Valor { get; set; }
        public override NodoInt Siguiente { get; set; }

        public NodoInt(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
        }
    }
}
