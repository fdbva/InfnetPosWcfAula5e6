using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;

namespace TicketSales.DomainModel.Interfaces.Services
{
    public interface ITicketCrudService
    {
        void AddTicket(Ticket ticket);
    }
}
