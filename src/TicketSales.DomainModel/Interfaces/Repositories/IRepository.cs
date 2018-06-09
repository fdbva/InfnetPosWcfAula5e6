using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;

namespace TicketSales.DomainModel.Interfaces.Repositories
{
    public interface IRepository<T> where T : TEntity
    {
        T Add(T entity);
        T Update(T entity);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        bool Remove(Guid id);
    }
}
