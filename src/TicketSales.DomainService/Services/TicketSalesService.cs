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
    public class TicketSalesService : ITicketSalesService
    {
        private readonly ITicketsRepository _ticketsRepository;

        public TicketSalesService(
            ITicketsRepository ticketsRepository)
        {
            _ticketsRepository = ticketsRepository;
        }
        public Ticket BuyTicket()
        {
            return _ticketsRepository.Dequeue();
        }
    }
}
