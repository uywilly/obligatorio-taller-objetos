using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Internacional : Excurcion,IEntity
    {
        /* Completado: 
         *  - Propiedades automaticas
         *  - Constructor
         *  - Validaciones
         *  
         *  Falta:
         *  - Manejo de Id
         *  - ToString + Equals 
         */
        private static double seguro;

        #region Constructor
        public Internacional(string codigo, string descripcion, DateTime fechaComienzo, List<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, List<Pasajero> pasajeros)
            : base(codigo, descripcion, fechaComienzo, hojaRuta, diasTraslado, stock, puntos, pasajeros)
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
        public override string ToString()
        {
            return "";
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
    }
}
