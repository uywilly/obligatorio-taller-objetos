using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Excurcion: IEntity
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
        #region Properties
        public string Codigo { get{return this.Id;}}
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaComienzo { get; set; }
        public List<Itinerario> HojaRuta { get; set; }
        public byte DiasTraslado { get; set; }
        public byte Stock { get; set; }
        public double Puntos { get; set; }
        public List<Pasajero> Pasajeros { get; set; }
        
        #endregion

        #region Constructor
        public Excurcion()
        {
            this.Id = "";
            this.Descripcion = "";
            this.FechaComienzo = System.DateTime.Today;
            this.HojaRuta = null;
            this.DiasTraslado = 0;
            this.Stock = 0;
            this.Puntos = 0;
            this.Pasajeros = null;
        }
        public Excurcion(string codigo, string descripcion, DateTime fechaComienzo, List<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, List<Pasajero> pasajeros)
        {
            this.Id = codigo;
            this.Descripcion = descripcion;
            this.FechaComienzo = fechaComienzo;
            this.HojaRuta = hojaRuta;
            this.DiasTraslado = diasTraslado;
            this.Stock = stock;
            this.Puntos = puntos;
            this.Pasajeros = pasajeros;
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
        public virtual bool Validar()
        {
            return (!string.IsNullOrEmpty(this.Codigo.Trim())
                && !string.IsNullOrEmpty(this.Descripcion.Trim())
                && DateTime.Compare(this.FechaComienzo, DateTime.Today) >= 0
                && this.HojaRuta != null
                && this.DiasTraslado >= 0
                && this.Stock > 0
                && this.Puntos > 0
                && this.Pasajeros != null);
        }
        public virtual List<Excurcion.ErroresAltaExcurcion> Validar2()
        {
            List<Excurcion.ErroresAltaExcurcion> retorno = new List<Excurcion.ErroresAltaExcurcion>();
            if(string.IsNullOrEmpty(this.Codigo.Trim())) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_CODIGO);
            if(string.IsNullOrEmpty(this.Descripcion.Trim())) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_DESCRIPCION);
            if( DateTime.Compare(FechaComienzo, DateTime.Today) < 0) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_FECHA);
            if(this.HojaRuta == null) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_RUTA);
            if(this.DiasTraslado < 0) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_DIAS_TRASLADO);
            if(this.Stock < 0) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_STOCK);
            if(this.Puntos < 0) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_PUNTOS);
            if(this.Pasajeros == null) retorno.Add(Excurcion.ErroresAltaExcurcion.ERR_PASAJEROS);
            if(retorno.Count == 0) retorno.Add(Excurcion.ErroresAltaExcurcion.EXITO);

            return retorno;
        }

        public enum ErroresAltaExcurcion
        {
            EXITO,
            ERR_CODIGO,
            ERR_DESCRIPCION,
            ERR_FECHA,
            ERR_RUTA,
            ERR_DIAS_TRASLADO,
            ERR_STOCK,
            ERR_PUNTOS,
            ERR_PASAJEROS,
            ERR_DESCUENTO,
            ERR_SEGURO
        }
        #endregion
    }
}
