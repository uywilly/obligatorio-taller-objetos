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
        public Nacional()
            : base()
        {
        }
        public Nacional(string codigo, string descripcion, DateTime fechaComienzo, List<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, List<Pasajero> pasajeros, double descuento)
                : base( codigo,  descripcion,  fechaComienzo,  hojaRuta,  diasTraslado,  stock,  puntos,  pasajeros)
            {
                this.descuento = descuento;
            }
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
