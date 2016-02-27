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
    public class Pasajero : Rol,IEntity
    {
        
        #region Properties
        public double Puntos { get; set; }
        #endregion

        #region Constructor
        public Pasajero():base()
        {
            this.Puntos = 0;
        }
        public Pasajero(string nombre, string apellido, string ci, double puntos):base(nombre, apellido, ci)
        {
            this.Puntos = puntos;
        }
        #endregion   

        #region ToString-Equals
        public override string ToString()
        {
            return "Pasajero: " + base.ToString() +" Puntos " + this.Puntos;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
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
