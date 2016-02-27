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
    public class Contrato:IEntity
    {
        #region Properties
        public Excurcion Excurcion { get; set; }
        public Cliente Cliente { get; set; }
        public List<Rol> ListaPasajeros { get; set; }
        public string Id { get; set; }
        #endregion

        #region Constructor 
        public Contrato()
        {
            this.Excurcion = null;
            this.Cliente = null;
            this.ListaPasajeros = null;
            this.Id = "";

        }
        public Contrato(Excurcion ex, Cliente cliente, List<Rol> listaPasajeros, string id)
        {
            this.Excurcion = ex;
            this.Cliente = cliente;
            this.ListaPasajeros = listaPasajeros;
            this.Id = id;

        }
        #endregion
        
        #region ToString-Equals
        public override string ToString()
        {
            return "Cliente: " + this.Cliente.ToString() + "Pasajeros: " + this.ListaPasajeros.ToString() ;
        }
        public override bool Equals(object obj)
        {
            Contrato unC = obj as Contrato;
            if (unC == null) return false;
            return unC.Id == this.Id;
        }
        #endregion
        
        #region Validaciones
        public bool Validar()
        {
            return (this.Excurcion != null && this.ListaRoles.Count > 0);
        }
        public List<Contrato.ErroresAltaContrato> Validar2()
        {
            List<Contrato.ErroresAltaContrato> retorno = new List<Contrato.ErroresAltaContrato>();
            if (!this.Excurcion.Validar2().Contains(Excurcion.ErroresAltaExcurcion.EXITO)) retorno.Add(Contrato.ErroresAltaContrato.ERR_EXCURCION);
            if (this.ListaRoles.Count < 0) retorno.Add(ErroresAltaContrato.ERR_ROLES);
            if (retorno.Count == 0) retorno.Add(Contrato.ErroresAltaContrato.EXITO);
            return retorno;
        }
        public enum ErroresAltaContrato
        {
            EXITO,
            ERR_EXCURCION,
            ERR_ROLES

        }
        #endregion
    }
}
