using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class ComparadoraPuntaje:IComparer<Pasajero>
    {
        public int Compare(Pasajero x, Pasajero y)
        {
            return y.Puntos.CompareTo(x.Puntos);

        }
    }
}
