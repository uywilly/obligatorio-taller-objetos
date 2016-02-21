using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Repositorios
{
    public class RepositorioContratos : IRepositorio<Contrato>
    {
        private IList<Contrato> listaContratos = new List<Contrato>();
        public IEnumerable<Contrato> List
        {
            get { return this.listaContratos; }
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
