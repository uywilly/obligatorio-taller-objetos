using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        #region Properties

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci { get; set; }
        
        #endregion
        
        #region Constructor
        public Persona()
        {
            this.Nombre = "";
            this.Apellido = "";
            this.Ci = "";
        }
        public Persona(string nombre, string apellido, string ci)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Ci = ci;
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

        #region ENUM-ERRORES
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
