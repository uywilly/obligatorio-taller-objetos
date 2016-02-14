using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string ci;       

        #region Constructor
        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.ci = "";
        }
        public Cliente(string nombre, string apellido, string ci)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
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
