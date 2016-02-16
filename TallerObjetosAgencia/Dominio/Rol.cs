using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Rol
    {

        #region Properties
        public Persona Persona { get; set; }
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
