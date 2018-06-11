using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;
using TicketSales.DomainModel.Interfaces.Services;

namespace TicketSales.Application.AppServices.Interfaces
{
    public class TicketCrudServiceApp : ITicketCrudServiceApp
    {
        private readonly ITicketCrudService _ticketCrudService;

        public TicketCrudServiceApp(
            ITicketCrudService ticketCrudService)
        {
            _ticketCrudService = ticketCrudService;
        }

        public void AddTicket(Ticket ticket)
        {
            _ticketCrudService.AddTicket(ticket);
        }
    }
}
