using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Excurcion
    {
       
       


        #region Properties
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaComienzo { get; set; }
        public List<Itinerario> HojaRuta { get; set; }
        public byte DiasTraslado { get; set; }
        public byte Stock { get; set; }
        public double Puntos { get; set; }
        public List<Pasajero> Pasajeros { get; set; }
        public int Id { get; set; }
        #endregion

        #region Constructor
        public Excurcion()
        {
            this.Codigo = "";
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
            this.Codigo = codigo;
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

        #region ENUM-ERRORES
        public enum ErroresAltaBandeja
        {
            EXITO,
            ERR_CODIGO,
            ERR_DESCRIPCION,
            ERR_FECHA,
            ERR_RUTA,
            ERR_DIAS_TRASLADO,
            ERR_STOCK,
            ERR_PUNTOS,
            ERR_PASAJEROS
        }
        #endregion
    }
}
