using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Repositorios
{
    class RepositorioContrato : IRepositorio<Contrato>
    {
        public IEnumerable<Contrato> List
        {
            get { throw new NotImplementedException(); }
        }

        public bool Add(Contrato entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Contrato entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contrato entity)
        {
            throw new NotImplementedException();
        }

        public Contrato FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
