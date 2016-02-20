using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contrato:IEntity
    {
        #region Constructor 

        #endregion
        
        #region Properties
        public int Id { get; set; }
        #endregion
        
        #region ToString-Equals

        #endregion
        
        #region ENUM-ERRORES
        public enum ErroresAltaBandeja
        {
            EXITO,
            ERR_NOMBRE,
            ERR_CIUDAD,
            ERR_PAIS,
        }
        #endregion
    }
}
