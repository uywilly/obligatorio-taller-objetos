using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Repositorios
{
    public class RepositorioDestinos:IRepositorio<Destino>
    {
        private IList<Destino> listaDestinos = new List<Destino>();
        public RepositorioDestinos()
        { 
        }

        public IEnumerable<Destino> List
        {
            get { return this.listaDestinos; }
        }

        public bool Add(Destino entity)
        {
            bool retorno = false;
            if (!(this.listaDestinos.Contains(entity)))
            {
                if (entity.Validar())
                {
                    this.listaDestinos.Add(entity);
                }
            }
            return retorno;
        }

        public bool Delete(Destino entity)
        {
            bool retorno = false;
            return retorno; ;
        }

        public bool Update(Destino entity)
        {
            bool retorno = false;
            return retorno; 
        }

        public Destino FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
