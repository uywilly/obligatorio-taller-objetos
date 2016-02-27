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
    public class RepositorioPersonas : IRepositorio<Persona>
    {
        #region Listas
        private IList<Persona> listaPersonas = new List<Persona>();

        public IList<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; }
        }
        public IEnumerable<Persona> List
        {
            get { return this.listaPersonas; }
        }
        #endregion

        #region Constructor
        public RepositorioPersonas()
        {
        }
        #endregion

        #region Metodos
        public bool Add(Persona entity)
        {
            bool retorno = false;
            if (entity != null && !(this.ListaPersonas.Contains(entity)) && entity.Validar())
            {
                this.ListaPersonas.Add(entity);
                retorno = true;
            }

            return retorno;
        }

        public bool Delete(Persona entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Persona entity)
        {
            bool retorno = false;
            if (entity != null && this.ListaPersonas.Contains(entity) && entity.Validar())
            {
                Persona unaP = this.ListaPersonas.ElementAt(this.ListaPersonas.IndexOf(entity));
                unaP.Nombre = entity.Nombre;
                unaP.Apellido = entity.Apellido;
                unaP.Id = entity.Id;
                
                retorno = true;

            }

            return retorno;
        }

        public int IndexOf(Persona entity)
        {
            int pos = -1;
            if (entity != null && this.ListaPersonas.Contains(entity))
            {
                pos = this.ListaPersonas.IndexOf(entity);
            }
            return pos;
        }

        public Persona FindById(string Id)
        {
            Persona unaP = null;

            int i = 0;
            while (i < this.ListaPersonas.Count && unaP == null)
            {
                if (this.ListaPersonas[i].Id == Id) unaP = this.ListaPersonas[i];
                i++;

            }

            return unaP;
        }

        #endregion

    }

}
