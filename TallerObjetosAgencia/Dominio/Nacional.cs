using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Nacional : Excurcion
    {
        private double descuento;

        #region Constructor

        #endregion

        #region Properties
        public double Descuento
        {
            get { return this.descuento; }
            set { this.descuento = value; }
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
        public enum ErroresAltaBandeja
        {
            EXITO,
            ERR_DESCUENTO,
        }
        #endregion
    }
}
