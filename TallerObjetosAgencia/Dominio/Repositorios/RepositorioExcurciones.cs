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
    public class RepositorioExcurciones:IRepositorio<Excurcion>
    {
        #region Listas
        private IList<Excurcion> listaExcurciones = new List<Excurcion>();

        public IList<Excurcion> ListaExcurciones
        {
            get { return listaExcurciones; }
            set { listaExcurciones = value; }
        }

        public IEnumerable<Excurcion> List
        {
            get { return this.listaExcurciones; }
        }
        #endregion

        #region Constructor
        public RepositorioExcurciones()
        { }
        #endregion

        #region Metodos
        public bool Add(Excurcion entity)
        {
            bool retorno = false;
            if (entity != null && !(this.ListaExcurciones.Contains(entity)) && entity.Validar())
            {
                this.ListaExcurciones.Add(entity);
                retorno = true;
            }

            return retorno;
        }

        public bool Delete(Excurcion entity)
        {
            //validar que la excurcion no este en un contrato
            bool retorno = false;
            if (entity != null && (this.ListaExcurciones.Contains(entity)))
            {
                this.ListaExcurciones.Remove(entity);
                retorno = true;
            }
            return retorno;
        }

        public bool Update(Excurcion entity)
        {
            bool retorno = false;
            if (entity != null && this.ListaExcurciones.Contains(entity) && entity.Validar())
            {
                Excurcion unaE = this.ListaExcurciones.ElementAt(this.ListaExcurciones.IndexOf(entity));
                unaE.Descripcion = entity.Descripcion;
                unaE.DiasTraslado = entity.DiasTraslado;
                unaE.FechaComienzo = entity.FechaComienzo;
                unaE.HojaRuta = entity.HojaRuta;
                unaE.Id = entity.Id;
                unaE.Pasajeros = entity.Pasajeros;
                unaE.Puntos = entity.Puntos;
                unaE.Stock = entity.Stock;
                retorno = true;
               
            }

            return retorno;
        }

        public int IndexOf(Excurcion entity)
        {
            int pos = -1;
            if (entity != null && this.ListaExcurciones.Contains(entity))
            {
                pos = this.ListaExcurciones.IndexOf(entity);
            }
            return pos;
        }

        public Excurcion FindById(string Id)
        {
            Excurcion unaE = null;

            int i = 0;
            while (i < this.ListaExcurciones.Count && unaE == null)
            {
                if (this.ListaExcurciones[i].Id == Id) unaE = this.ListaExcurciones[i];
                i++;

            }

            return unaE;
        }
        #endregion
        
    }
}
