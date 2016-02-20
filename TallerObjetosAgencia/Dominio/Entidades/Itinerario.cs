using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Itinerario:IEntity
    {
        #region Properties
        public byte DiasEstadia { get; set; }
        public decimal CostoDiario { get; set; }
        public Destino Destino { get; set; }
        public int Id { get; set; }

        #endregion

        #region Constructor
        public Itinerario()
        {
            this.DiasEstadia = 0;
            this.CostoDiario = 0;
            this.Destino = null;
        }
        public Itinerario(byte diasEstadia, decimal costoDiario, Destino destino)
        {
            this.DiasEstadia = diasEstadia;
            this.CostoDiario = costoDiario;
            this.Destino = destino;

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
            ERR_DIAS,
            ERR_COSTO,
            ERR_DESTINO,
        }
        #endregion
    }
}
