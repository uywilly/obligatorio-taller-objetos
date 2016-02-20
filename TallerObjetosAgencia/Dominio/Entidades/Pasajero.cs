using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasajero : Rol
    {
        
        #region Properties
        public double Puntos { get; set; }
        #endregion

        #region Constructor
        public Pasajero():base()
        {
            this.Puntos = 0;
        }
        public Pasajero(string nombre, string apellido, string ci, double puntos):base(nombre, apellido, ci)
        {
            this.Puntos = puntos;
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
