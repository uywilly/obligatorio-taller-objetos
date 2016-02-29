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
    public class RepositorioContratos : IRepositorio<Contrato>
    {
        #region Listas
        private IList<Contrato> listaContratos = new List<Contrato>();

        public IList<Contrato> ListaContratos
        {
            get { return listaContratos; }
            set { listaContratos = value; }
        }
        public IEnumerable<Contrato> List
        {
            get { return this.listaContratos; }
        }
        #endregion

        #region Constructor
        public RepositorioContratos()
        {
        }
        #endregion

        #region Metodos
        public bool Add(Contrato entity)
        {
            bool retorno = false;
            if (entity != null && !(this.ListaContratos.Contains(entity)) && entity.Validar())
            {
                Excurcion unaE = entity.Excurcion;
                if (unaE.Stock >= entity.ListaPasajeros.Count)
                {
                    this.ListaContratos.Add(entity);
                    unaE.AgregarPasajeros(entity.ListaPasajeros);
                    retorno = true;
                }
            }

            return retorno;
        }

        public bool Delete(Contrato entity)
        {
            bool retorno = false;
            if (entity != null && (this.ListaContratos.Contains(entity)))
            {
                this.ListaContratos.Remove(entity);
                retorno = true;
            }
            return retorno;
        }

        public bool Update(Contrato entity)
        {
            bool retorno = false;
            if (entity != null && this.ListaContratos.Contains(entity) && entity.Validar())
            {
                Contrato unC = this.ListaContratos.ElementAt(this.ListaContratos.IndexOf(entity));
                unC.Cliente = entity.Cliente;
                unC.Id = entity.Id;
                unC.ListaPasajeros = entity.ListaPasajeros;
                unC.FechaContrato = entity.FechaContrato;
                retorno = true;
            }

            return retorno;
        }

        public Contrato FindById(string Id)
        {
            Contrato unC = null;

            int i = 0;
            while (i < this.ListaContratos.Count && unC == null)
            {
                if (this.ListaContratos[i].Id == Id) unC = this.ListaContratos[i];
                i++;

            }

            return unC;
        }

        public int IndexOf(Contrato entity)
        {
            int pos = -1;
            if (entity != null && this.ListaContratos.Contains(entity))
            {
                pos = this.ListaContratos.IndexOf(entity);
            }
            return pos;
        }

        #endregion
        
    }
}
