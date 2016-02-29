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
        private static string localidad = "Uruguay";
        public double Descuento { get; set; }
        public static string Localidad
        {
            get { return Nacional.localidad; }
            set { Nacional.localidad = value; }
        }
        #endregion

        #region Constructor
        public Nacional()
            : base()
        {
        }
        public Nacional(string codigo, string descripcion, DateTime fechaComienzo, IList<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, IList<Pasajero> pasajeros, double descuento)
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
            bool retorno = false;
            if(base.Validar() && !Double.IsNaN(this.Descuento) && this.Descuento > 0)
            {
                Destino unD = null;
                foreach (Itinerario unI in this.HojaRuta)
                {
                    if (unI.Destino.Pais == Nacional.localidad)
                        retorno = true;
                    else return false;
                }
            }

            return retorno; 
            
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
