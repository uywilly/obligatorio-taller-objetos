using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Repositorios;
using Dominio.Entidades;

namespace Fachadas
{
    class FachadaAgencia
    {

        #region Listados(Repositorios)

        public RepositorioClientes RepoClientes { get; set; }
        public RepositorioContratos RepoContratos { get; set; }
        public RepositorioDestinos RepoDestinos { get; set; }
        public RepositorioPasajeros RepoPasajeros { get; set; }

        #endregion

        #region Singleton

        private static FachadaAgencia instancia = null;

        internal FachadaAgencia Instancia
        {
            get { if (instancia == null) { FachadaAgencia.instancia = new FachadaAgencia(); } return instancia; }
        }

        private FachadaAgencia()
        {
            this.RepoClientes = new RepositorioClientes();
            this.RepoPasajeros = new RepositorioPasajeros();
            this.RepoContratos = new RepositorioContratos();
            this.RepoDestinos = new RepositorioDestinos();

        }
        #endregion



    }
}
