using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Destino:IEntity
    {

        #region Constructor 
        public Destino()
        {
            this.Nombre = "";
            this.Ciudad = "";
            this.Pais = "";

        }
        public Destino(string nombre, string ciudad, string pais)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Pais = pais;
        }
        #endregion
        
        #region Properties
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int Id { get; set; }

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
        public bool Validar()
        {
            return (!string.IsNullOrEmpty(this.Nombre.Trim())
                 && !string.IsNullOrEmpty(this.Ciudad.Trim())
                 && !string.IsNullOrEmpty(this.Pais.Trim())
                 );
        }
        public List<Destino.ErroresAltaDestino> Validar2()
        {
            List<Destino.ErroresAltaDestino> retorno = new List<Destino.ErroresAltaDestino>();
            if (string.IsNullOrEmpty(this.Nombre.Trim())) retorno.Add(Destino.ErroresAltaDestino.ERR_NOMBRE);
            if (string.IsNullOrEmpty(this.Ciudad.Trim())) retorno.Add(Destino.ErroresAltaDestino.ERR_CIUDAD);
            if (string.IsNullOrEmpty(this.Pais.Trim())) retorno.Add(Destino.ErroresAltaDestino.ERR_PAIS);
            if (retorno.Count == 0) retorno.Add(Destino.ErroresAltaDestino.EXITO);
            return retorno;
        }

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
