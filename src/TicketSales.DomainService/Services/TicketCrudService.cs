using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;
using TicketSales.DomainModel.Interfaces.Repositories;
using TicketSales.DomainModel.Interfaces.Services;

namespace TicketSales.DomainService.Services
{
    public class TicketCrudService : ITicketCrudService
    {
        private readonly ITicketsRepository _ticketsRepository;

        public TicketCrudService(
            ITicketsRepository ticketsRepository)
        {
            _ticketsRepository = ticketsRepository;
        }
        public void AddTicket(Ticket ticket)
        {
            _ticketsRepository.Add(ticket);
        }
    }
}
