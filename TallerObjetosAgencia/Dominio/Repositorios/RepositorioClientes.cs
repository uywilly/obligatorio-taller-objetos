using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Runtime.Serialization;

namespace Dominio.Repositorios
{
    [Serializable]
    public class RepositorioClientes : IRepositorio<Cliente>
    {
        #region Listas
        private IList<Cliente> listaClientes = new List<Cliente>();
        public IList<Cliente> ListaClientes
        {
            get { return this.listaClientes; }
            set { this.listaClientes = value; }
        }
        public IEnumerable<Cliente> List
        {
            get { return this.listaClientes; }
        }        
        #endregion
        
        
        #region Contrstuctor
        public RepositorioClientes()
        {
        }
        #endregion

        #region Metodos
        public bool Add(Cliente entity)
        {
            bool retorno = false;
            if (entity!=null && !(this.ListaClientes.Contains(entity)) && entity.Validar())
            {
                this.ListaClientes.Add(entity);
                retorno = true;
            }

            return retorno;
        }

        public bool Delete(Cliente entity)
        {
            //FALTA VALIDAR SI TIENE CONTRATOS O EXCURCIONES
            bool retorno = false;
            if (entity != null && (this.ListaClientes.Contains(entity)))
            {
                this.ListaClientes.Remove(entity);
                retorno = true;
            }
            return retorno;
        }

        public bool Update(Cliente entity)
        {
            bool retorno = false;
            if (entity != null && this.ListaClientes.Contains(entity))
            {
                this.ListaClientes.RemoveAt(this.ListaClientes.IndexOf(entity));
                this.ListaClientes.Add(entity);
            }

            return retorno;
        }

        public int IndexOf(Cliente entity)
        {
            int pos = -1;
            if (entity != null && this.ListaClientes.Contains(entity)) 
            {
                pos = this.ListaClientes.IndexOf(entity);
            }
            return pos;
        }

        public Cliente FindById(string Id)
        {
            Cliente unC = null;

            int i = 0;
            while (i < this.ListaClientes.Count && unC == null)
            {
                if (this.ListaClientes[i].Id == Id) unC = this.ListaClientes[i];
                i++;
                
            }

            return unC;
        }
        
        public void Persistir() { }

        #endregion




        
    }
}
