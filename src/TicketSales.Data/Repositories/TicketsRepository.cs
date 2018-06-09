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
    public class TicketsRepository : Repository<Ticket>, ITicketsRepository
    {
        //Pseudo Banco de Dados concorrente
        private static readonly ConcurrentQueue<Ticket> Tickets = new ConcurrentQueue<Ticket>();
        public void Enqueue(Ticket ticket)
        {
            Tickets.Enqueue(ticket);
        }

        public Ticket Dequeue()
        {
            return Tickets.TryDequeue(out var ticket) ? ticket : null;
        }
    }
}
