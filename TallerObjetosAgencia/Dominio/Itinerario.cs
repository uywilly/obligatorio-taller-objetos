using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Itinerario
    {
        private byte diasEstadia;
        private decimal costoDiario;
        private Destino destino;

        #region Constructor 
        public Itinerario()
        {
            this.diasEstadia = 0;
            this.costoDiario = 0;
            this.destino = null;
        }
        #endregion
        
        #region Properties
        public byte DiasEstadia
        {
            get { return this.diasEstadia; }
            set { this.diasEstadia = value; }
        }
        public decimal CostoDiario
        {
            get { return this.costoDiario; }
            set { this.costoDiario = value; }
        }
        internal Destino Destino
        {
            get { return this.destino; }
            set { this.destino = value; }
        }
        #endregion
        
        #region ToString-Equals
        public override string ToString()
        {
            return "";
        }
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
        #endregion
        
        #region ENUM-ERRORES
        public enum ErroresAltaBandeja
        {
            EXITO,
            ERR_DIAS,
            ERR_COSTO,
            ERR_DESTINO,
        }
        #endregion
    }
}
