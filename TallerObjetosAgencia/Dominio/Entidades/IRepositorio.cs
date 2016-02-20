using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public interface IRepositorio<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T FindById(int Id);
    }
}
