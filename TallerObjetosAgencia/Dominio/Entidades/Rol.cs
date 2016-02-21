using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Rol:IEntity
    {

        #region Properties
        public Persona Persona { get; set; }
        public int Id { get; set; }
        #endregion

        #region Validaciones
        public abstract List<Rol.ErroresAltaRol> Validar();
        
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
        }
        public Rol(Persona persona)
        {
            this.Persona = persona;
        }
        public Rol(string nombre, string apellido, string ci)
        {
            this.Persona = new Persona(nombre, apellido, ci);
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
        
    }
}
