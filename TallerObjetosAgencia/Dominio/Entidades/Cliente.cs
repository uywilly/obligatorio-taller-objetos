using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Rol, IEntity  
    {
        #region Properties
        public string DireccionFactura { get; set; }
        #endregion
        
        #region Constructor
        public Cliente():base()
        {
            this.DireccionFactura = "";
        }
        public Cliente(string nombre, string apellido, string ci, string direccionFactura):base(nombre, apellido, ci)
        {
            this.DireccionFactura = direccionFactura;
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
        public enum ErroresAltaCLiente
        { 
            EXITO,
            ERR_DIR
        }
        #endregion
    }
}
