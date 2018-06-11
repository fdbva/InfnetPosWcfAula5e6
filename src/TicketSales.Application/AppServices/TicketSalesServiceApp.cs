using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;
using TicketSales.DomainModel.Interfaces.Services;

namespace TicketSales.Application.AppServices
{
    public class TicketSalesServiceApp
    {
        private readonly ITicketSalesService _ticketSalesService;

        public TicketSalesServiceApp(
            ITicketSalesService ticketSalesService)
        {
            _ticketSalesService = ticketSalesService;
        }

        public Ticket BuyTicket()
        {
            return _ticketSalesService.BuyTicket();
        }
    }
}
