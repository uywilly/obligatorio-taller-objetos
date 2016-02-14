using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasajero
    {
        private string nombre;
        private string apellido;
        private string ci;
        private double puntos;

        #region Constructor
        public Pasajero()
        {
            this.nombre = "";
            this.apellido = "";
            this.ci = "";
            this.puntos = 0;
        }
        public Pasajero(string nombre, string apellido, string ci, double puntos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
            this.puntos = puntos;
        }
        #endregion

        #region Properties
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Ci
        {
            get { return this.ci; }
            set { this.ci = value; }
        }
        public double Puntos
        {
            get { return this.puntos; }
            set { this.puntos = value; }
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
            ERR_NOMBRE,
            ERR_APELLIDO,
            ERR_CI,
        }
        #endregion
    }
}
