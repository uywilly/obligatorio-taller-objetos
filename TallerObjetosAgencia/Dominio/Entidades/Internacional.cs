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
    public class Internacional : Excurcion,IEntity
    {
        private static decimal seguro;
        public string ParaListado { get { return this.ToString(); } }

        #region Constructor
        public Internacional(string codigo, string descripcion, DateTime fechaComienzo, IList<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, IList<Pasajero> pasajeros)
            : base(codigo, descripcion, fechaComienzo, hojaRuta, diasTraslado, stock, puntos, pasajeros)
        {

        }

        #endregion

        #region Properties
        public static decimal Seguro
        {
            get { return Internacional.seguro; }
            set { Internacional.seguro = value; }
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
            return (base.Validar() && Internacional.Seguro >= 0);
        }
        public override List<Excurcion.ErroresAltaExcurcion> Validar2()
        {
            List<Excurcion.ErroresAltaExcurcion> retorno = new List<Excurcion.ErroresAltaExcurcion>();
            if (base.Validar2().Contains(Excurcion.ErroresAltaExcurcion.EXITO) && Internacional.Seguro >= 0)
                return retorno;
            else retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_SEGURO);
            return retorno;
        }



        #endregion

        public override decimal CostoExcurcion()
        {
            return base.CostoExcurcion() + seguro;
        }
    }
}
