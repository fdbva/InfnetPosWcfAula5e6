using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;
using TicketSales.DomainModel.Interfaces.Repositories;

namespace TicketSales.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : TEntity
    {
        private static readonly List<T> Entities = new List<T>();
        public virtual T Add(T entity)
        {
            Entities.Add(entity);
            return entity;
        }

        public virtual T Update(T entity)
        {
            Remove(entity.Id);
            return Add(entity);
        }

        public virtual T Get(Guid id)
        {
            return Entities.Find(e => e.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Entities;
        }

        public virtual bool Remove(Guid id)
        {
            return Entities.Remove(Get(id));
        }
    }
}
