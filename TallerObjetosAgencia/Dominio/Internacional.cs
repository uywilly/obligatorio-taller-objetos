using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Internacional : Excurcion
    {
        private static double seguro;
        
        #region Constructor
            public Internacional()
            : base()
        {

        }

        #endregion
        
        #region Properties
            public static double Seguro
            {
                get { return Internacional.seguro; }
                set { Internacional.seguro = value; }
            }
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
