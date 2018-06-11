using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;

namespace TicketSales.Application.AppServices.Interfaces
{
    public interface ITicketCrudServiceApp
    {
        void AddTicket(Ticket ticket);
    }
}
