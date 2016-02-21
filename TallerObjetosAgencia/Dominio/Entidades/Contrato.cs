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
        #region Constructor 

        #endregion
        
        #region Properties
        public Excurcion Excurcion { get; set; }
        public List<Rol> ListaRoles { get; set; }
        public int Id { get; set; }
        #endregion
        
        #region ToString-Equals

        #endregion
        
        #region ENUM-ERRORES
        public bool Validar()
        {
            bool retorno = false;
            return retorno;
        }

        public enum ErroresAltaBandeja
        {
            EXITO,
            ERR_EXCURCION,

        }
        #endregion
    }
}
