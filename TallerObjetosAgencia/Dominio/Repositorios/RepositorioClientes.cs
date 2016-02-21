using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Repositorios
{
    public class RepositorioClientes : IRepositorio<Cliente>
    {
        private IList<Cliente> listaClientes = new List<Cliente>();
        public IEnumerable<Cliente> List
        {
            get { return this.listaClientes; }
        }

        public bool Add(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Cliente FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
