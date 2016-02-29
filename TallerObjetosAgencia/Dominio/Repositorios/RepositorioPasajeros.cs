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
    public class RepositorioPasajeros : IRepositorio<Pasajero>
    {
        #region Listas
        private IList<Pasajero> listaPasajeros = new List<Pasajero>();

        public IList<Pasajero> ListaPasajeros
        {
            get { return listaPasajeros; }
            set { listaPasajeros = value; }
        }
        public IEnumerable<Pasajero> List
        {
            get { return this.listaPasajeros; }
        }
        #endregion

        #region Constructor
        public RepositorioPasajeros() { }
        #endregion
        
        #region Metodos
        public bool Add(Pasajero entity)
        {
            bool retorno = false;
            if (entity != null && !(this.ListaPasajeros.Contains(entity)) && entity.Validar())
            {
                this.ListaPasajeros.Add(entity);
                retorno = true;
            }

            return retorno;
        }

        public bool Delete(Pasajero entity)
        {
            //FALTA VALIDAR SI TIENE EXCURCIONES
            bool retorno = false;
            if (entity != null && (this.ListaPasajeros.Contains(entity)))
            {
                this.ListaPasajeros.Remove(entity);
                retorno = true;
            }
            return retorno;
        }

        public bool Update(Pasajero entity)
        {
            bool retorno = false;
            if (entity != null && this.ListaPasajeros.Contains(entity) && entity.Validar())
            {
                Pasajero unP = this.ListaPasajeros.ElementAt(this.ListaPasajeros.IndexOf(entity));
                unP.Id = entity.Id;
                unP.Persona = entity.Persona;
                unP.Puntos = entity.Puntos;
                retorno = true;

            }

            return retorno;
        }

        public int IndexOf(Pasajero entity)
        {
            int pos = -1;
            if (entity != null && this.ListaPasajeros.Contains(entity))
            {
                pos = this.ListaPasajeros.IndexOf(entity);
            }
            return pos;
        }

        public Pasajero FindById(string Id)
        {
            Pasajero unP = null;

            int i = 0;
            while (i < this.ListaPasajeros.Count && unP == null)
            {
                if (this.ListaPasajeros[i].Id == Id) unP = this.ListaPasajeros[i];
                i++;

            }

            return unP;
        }

        public IList<Persona> DatosPersonales
        {
            get
            {
                IList<Persona> datosPersonales = new List<Persona>();
                foreach (Pasajero unC in listaPasajeros)
                {
                    datosPersonales.Add(unC.Persona);
                }
                return datosPersonales;
            }
        }

        #endregion

        
    }
}
