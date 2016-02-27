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
            throw new NotImplementedException();
        }

        public bool Delete(Persona entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Persona entity)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Persona entity)
        {
            throw new NotImplementedException();
        }

        public Persona FindById(string Id)
        {
            throw new NotImplementedException();
        }
        #endregion

    }

}
