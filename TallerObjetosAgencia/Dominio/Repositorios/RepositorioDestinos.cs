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
    public class RepositorioDestinos:IRepositorio<Destino>
    {
        #region Listas
        private IList<Destino> listaDestinos = new List<Destino>();

        public IList<Destino> ListaDestinos
        {
            get { return listaDestinos; }
            set { listaDestinos = value; }
        }
        
        public IEnumerable<Destino> List
        {
            get { return this.listaDestinos; }
        }
        #endregion

        #region Constructor
        public RepositorioDestinos()
        {
        }
        #endregion

        #region Metodos
        public bool Add(Destino entity)
        {
            bool retorno = false;
            if (entity != null && !(this.ListaDestinos.Contains(entity)) && entity.Validar())
            {
                this.ListaDestinos.Add(entity);
                retorno = true;
            }

            return retorno;
        }

        public bool Delete(Destino entity)
        {
            //validar que el destino no este en una excurcion
            bool retorno = false;
            if (entity != null && (this.ListaDestinos.Contains(entity)))
            {
                this.ListaDestinos.Remove(entity);
                retorno = true;
            }
            return retorno;
        }

        public bool Update(Destino entity)
        {
            bool retorno = false;
            if (entity != null && this.ListaDestinos.Contains(entity) && entity.Validar())
            {
                Destino unD = this.ListaDestinos.ElementAt(this.ListaDestinos.IndexOf(entity));
                unD.Nombre = entity.Nombre;
                unD.Id = entity.Id;
                unD.Pais = entity.Pais;
                unD.Ciudad = entity.Ciudad;
            }

            return retorno;
        }

        public int IndexOf(Destino entity)
        {
            int pos = -1;
            if (entity != null && this.ListaDestinos.Contains(entity))
            {
                pos = this.ListaDestinos.IndexOf(entity);
            }
            return pos;
        }

        public Destino FindById(string Id)
        {
            Destino unD = null;

            int i = 0;
            while (i < this.ListaDestinos.Count && unD == null)
            {
                if (this.ListaDestinos[i].Id == Id) unD = this.ListaDestinos[i];
                i++;

            }

            return unD;
        }
        #endregion
        
    }
}
