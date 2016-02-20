using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Excurcion
    {
        private string codigo;
        private string descripcion;
        private DateTime fechaComienzo;
        private List<Itinerario> hojaRuta;
        private byte diasTraslado;
        private byte stock;
        private double puntos;
        private List<Pasajero> pasajeros;
       
        #region Constructor
        public Excurcion()
        {
            this.codigo = "";
            this.descripcion = "";
            this.fechaComienzo = System.DateTime.Today;
            this.hojaRuta = null;
            this.diasTraslado = 0;
            this.stock = 0;
            this.puntos = 0;
            this.pasajeros = null;
        }
        public Excurcion(string codigo, string descripcion, DateTime fechaComienzo, List<Itinerario> hojaRuta, byte diasTraslado, byte stock, double puntos, List<Pasajero> pasajeros)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.fechaComienzo = fechaComienzo;
            this.hojaRuta = hojaRuta;
            this.diasTraslado = diasTraslado;
            this.stock = stock;
            this.puntos = puntos;
            this.pasajeros = pasajeros;
        }

       

        #endregion

        #region Properties
        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public DateTime FechaComienzo
        {
            get { return this.fechaComienzo; }
            set { this.fechaComienzo = value; }
        }
        public List<Itinerario> HojaRuta
        {
            get { return this.hojaRuta; }
            set { this.hojaRuta = value; }
        }
        public byte DiasTraslado
        {
            get { return this.diasTraslado; }
            set { this.diasTraslado = value; }
        }
        public byte Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }
        public double Puntos
        {
            get { return this.puntos; }
            set { this.puntos = value; }
        }
        public List<Pasajero> Pasajeros
        {
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
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
