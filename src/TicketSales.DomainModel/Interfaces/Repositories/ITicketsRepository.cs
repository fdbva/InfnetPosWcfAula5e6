using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;

namespace TicketSales.DomainModel.Interfaces.Repositories
{
    public interface ITicketsRepository : IRepository<Ticket>
    {
        void Enqueue(Ticket ticket);
        Ticket Dequeue();
    }
}
