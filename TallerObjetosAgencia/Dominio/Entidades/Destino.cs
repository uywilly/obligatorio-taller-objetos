using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Destino
    {
        private string nombre;
        private string ciudad;
        private string pais;

        #region Constructor 
        public Destino()
        {
            this.nombre = "";
            this.ciudad = "";
            this.pais = "";

        }
        public Destino(string nombre, string ciudad, string pais)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.pais = pais;
        }
        #endregion
        
        #region Properties
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public string Ciudad
        {
            set { this.ciudad = value; }
            get { return this.ciudad; }
        }
        public string Pais
        {
            set { this.pais = value; }
            get { return this.pais; }
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
        public enum ErroresAltaDestino
        {
            EXITO,
            ERR_NOMBRE,
            ERR_CIUDAD,
            ERR_PAIS,
        }
        #endregion
    }
}
