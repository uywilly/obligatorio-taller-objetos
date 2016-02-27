using Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Dominio
{
    [Serializable]
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
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion

        #region Validaciones
        public override bool Validar()
        {
            return (base.Validar() && !Double.IsNaN(this.Descuento) && this.Descuento > 0);
        }
        public override List<Excurcion.ErroresAltaExcurcion> Validar2()
        {
            List<Excurcion.ErroresAltaExcurcion> retorno = new List<Excurcion.ErroresAltaExcurcion>();
            if (base.Validar2().Contains(Excurcion.ErroresAltaExcurcion.EXITO) && !Double.IsNaN(this.Descuento) && this.Descuento > 0)
            {
                retorno.Add(ErroresAltaExcurcion.EXITO);
                return retorno; 
            }
            else retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_DESCUENTO);
            return retorno;
        }



        #endregion
    }
}
