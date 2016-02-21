using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
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
            return "";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion

        #region validaciones
        public override List<Rol.ErroresAltaRol> Validar()
        {
            List<Rol.ErroresAltaRol> retorno = new List<ErroresAltaRol>();
            if(!Double.IsNaN(this.Puntos)) 
                retorno.Add(Rol.ErroresAltaRol.ERR_PUNTOS);
            if (this.Persona.Validar2().Contains(Persona.ErroresAltaPersona.EXITO) && retorno.Count==0 )
            {
                retorno.Add(Rol.ErroresAltaRol.EXITO);
            }

            return retorno;
        }

        #endregion
    }
}
