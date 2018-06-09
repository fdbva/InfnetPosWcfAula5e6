using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSales.DomainModel.Entities;

namespace TicketSales.DomainModel.Interfaces.Services
{
    public interface ITicketSalesService
    {
        /// <summary>
        /// Função que retorna um ticket.
        /// </summary>
        /// <returns>Retorna o Ticket ou null</returns>
        Ticket BuyTicket();
    }
}
