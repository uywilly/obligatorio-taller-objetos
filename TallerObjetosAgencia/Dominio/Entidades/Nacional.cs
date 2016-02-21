using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Nacional : Excurcion, IEntity
    {

        #region Properties
        public double Descuento { get; set; }
       
        #endregion

        #region Constructor
        public Nacional()
            : base()
        {
        }
        public Nacional(string codigo, string descripcion, DateTime fechaComienzo, List<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, List<Pasajero> pasajeros, double descuento)
            : base(codigo, descripcion, fechaComienzo, hojaRuta, diasTraslado, stock, puntos, pasajeros)
        {
            this.Descuento = descuento;
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
