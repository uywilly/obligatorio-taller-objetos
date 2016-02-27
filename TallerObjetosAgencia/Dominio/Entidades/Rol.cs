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
    public abstract class Rol : IEntity
    {

        #region Properties
        public Persona Persona { get; set; }
        public string Id { get; set; }
        #endregion

        #region Validaciones
        public virtual bool Validar()
        {
            return (this.Persona.Validar2().Contains(Persona.ErroresAltaPersona.EXITO));
        }
        public virtual List<Rol.ErroresAltaRol> Validar2()
        {
            List<Rol.ErroresAltaRol> retorno = new List<ErroresAltaRol>();
            if (this.Persona.Validar2().Contains(Persona.ErroresAltaPersona.EXITO))
                retorno.Add(Rol.ErroresAltaRol.EXITO);
            else retorno.Add(Rol.ErroresAltaRol.ERR_PERSONA);
            
            return retorno;
        }
        
        public enum ErroresAltaRol
        {
            EXITO,
            ERR_PERSONA,
            ERR_PUNTOS,
            ERR_DIR_ENVIO
        }
        #endregion
        
        #region Constructor
        public Rol()
        {
            this.Persona = null;
            this.Id = "";
        }
        public Rol(Persona persona)
        {
            this.Persona = persona;
            this.Id = "";
        }
        public Rol(string nombre, string apellido, string ci)
        {
            this.Persona = new Persona(nombre, apellido, ci);
        }
        #endregion

        #region ToString-Equals
        public override string ToString()
        {
            return this.Persona.ToString();
        }
        public override bool Equals(object obj)
        {
            Rol unR = obj as Rol;
            if (unR == null) return false;
            return unR.Id == this.Id;
        }
        #endregion
        
    }
}
