using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona:IEntity
    {
        /* Completado: 
         *  - Propiedades automaticas
         *  - Constructor
         *  - Validaciones
         *  
         *  Falta:
         *  - Manejo de Id
         *  - ToString + Equals 
         */
        #region Properties

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get { return this.Id; } }
        public string Id { get; set; }
        
        #endregion
        
        #region Constructor
        public Persona()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Id = "";
        }
        public Persona(string nombre, string apellido, string ci)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id = ci;
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

        #region Validaciones
        
        
        public virtual bool Validar()
        {
            bool retorno = false;

            if (!string.IsNullOrEmpty(this.Nombre.Trim()) && !string.IsNullOrEmpty(this.Apellido.Trim())
                && !string.IsNullOrEmpty(this.Ci.Trim()))
            {
                retorno = true;
            }

            return retorno;
        }
        //de otra forma puede retornar una list de enum de acuerdo al error
        public virtual List<Persona.ErroresAltaPersona> Validar2()
        {
            List<Persona.ErroresAltaPersona> retorno = new List<Persona.ErroresAltaPersona>();

            if (!string.IsNullOrEmpty(this.Nombre.Trim())) retorno.Add(ErroresAltaPersona.ERR_NOMBRE);
            if (!string.IsNullOrEmpty(this.Apellido.Trim())) retorno.Add(ErroresAltaPersona.ERR_APELLIDO);    
            if (!string.IsNullOrEmpty(this.Ci.Trim())) retorno.Add(ErroresAltaPersona.ERR_CI);
            if (retorno.Count == 0) retorno.Add(ErroresAltaPersona.EXITO);

            return retorno;
        }
        public enum ErroresAltaPersona
        {
            EXITO,
            ERR_NOMBRE,
            ERR_APELLIDO,
            ERR_CI
        }
        #endregion
    }
}
