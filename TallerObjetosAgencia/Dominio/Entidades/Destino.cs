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
    public class Destino:IEntity
    {
        #region Properties
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Id { get; set; }

        #endregion

        #region Constructor 
        public Destino()
        {
            this.Nombre = "";
            this.Ciudad = "";
            this.Pais = "";
            this.Id = "";

        }
        public Destino(string nombre, string ciudad, string pais, string id)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Pais = pais;
            this.Id = id;
        }
        #endregion
            
        #region ToString-Equals
        public override string ToString()
        {
            return "Destino: " + this.Nombre + " " + this.Ciudad +" , " + this.Pais;
        }
        public override bool Equals(object obj)
        {
            Destino unD = obj as Destino;
            if(unD == null) return false;
            return unD.Id == this.Id;
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
