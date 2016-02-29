using Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
    public class Pasajero : Rol, IEntity
    {
        
        #region Properties
        public double Puntos { get; set; }
        public static int Ultimo { get; set; }
        public int codigo { get; set; }
        public string ParaListado { get { return base.ToString() + " Puntos " + this.Puntos; } }
        #endregion

        #region Constructor
        public Pasajero():base()
        {
            this.Puntos = 0;
            this.codigo = Pasajero.Ultimo;
            ++Pasajero.Ultimo;
        }
        public Pasajero(string nombre, string apellido, string ci, double puntos):base(nombre, apellido, ci)
        {
            this.Puntos = puntos;
            this.codigo = Pasajero.Ultimo;
            ++Pasajero.Ultimo;
        }
        #endregion   

        #region ToString-Equals-CompareTo
        public override string ToString()
        {
            return "Pasajero: " + base.ToString() +" Puntos " + this.Puntos;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public int CompareTo(Pasajero other)
        {
            return this.Puntos.CompareTo(other.Puntos);
        }
        #endregion

        #region Validaciones
        public override bool Validar()
        {
            return base.Validar() && !Double.IsNaN(this.Puntos);
        }
        public override List<ErroresAltaRol> Validar2()
        {
            List<Rol.ErroresAltaRol> retorno = new List<Rol.ErroresAltaRol>();
            if (Double.IsNaN(this.Puntos))
                retorno.Add(Rol.ErroresAltaRol.ERR_PUNTOS);
            if (base.Validar2().Contains(Rol.ErroresAltaRol.EXITO) && retorno.Count == 0)
            {
                retorno.Add(Rol.ErroresAltaRol.EXITO);
            }

            return retorno;
        }

        #endregion

        
    }
}
