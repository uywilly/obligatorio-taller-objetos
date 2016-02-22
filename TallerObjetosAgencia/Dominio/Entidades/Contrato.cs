using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio
{
    public class Contrato:IEntity
    {
        /* Completado: 
         *  - Propiedades automaticas
         *  - Validaciones
         *  -Constructor
         *  
         *  Falta:
         *  - Manejo de Id
         *  - ToString + Equals 
         */
        #region Constructor 

        #endregion
        
        #region Properties
        public Excurcion Excurcion { get; set; }
        public List<Rol> ListaRoles { get; set; }
        public int Id { get; set; }
        #endregion
        
        #region ToString-Equals

        #endregion
        
        #region Validaciones
        public bool Validar()
        {
            return (this.Excurcion != null && this.ListaRoles.Count > 0);
        }
        public List<Contrato.ErroresAltaContrato> Validar2()
        {
            List<Contrato.ErroresAltaContrato> retorno = new List<Contrato.ErroresAltaContrato>();
            if (!this.Excurcion.Validar2().Contains(Excurcion.ErroresAltaExcurcion.EXITO)) retorno.Add(Contrato.ErroresAltaContrato.ERR_EXCURCION);
            if (this.ListaRoles.Count < 0) retorno.Add(ErroresAltaContrato.ERR_ROLES);
            if (retorno.Count == 0) retorno.Add(Contrato.ErroresAltaContrato.EXITO);
            return retorno;
        }
        public enum ErroresAltaContrato
        {
            EXITO,
            ERR_EXCURCION,
            ERR_ROLES

        }
        #endregion
    }
}
