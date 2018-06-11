using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TicketSales.Application.AppServices.Interfaces;
using TicketSales.Data.Repositories;
using TicketSales.DomainModel.Entities;
using TicketSales.DomainModel.Interfaces.Repositories;
using TicketSales.DomainModel.Interfaces.Services;
using TicketSales.DomainService.Services;

namespace TicketSales.TicketsServiceWCF.TicketManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TicketManagerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TicketManagerService.svc or TicketManagerService.svc.cs at the Solution Explorer and start debugging.
    public class TicketManagerService : ITicketManagerService
    {
        public void AddTicket(Ticket ticket)
        {
            ITicketsRepository ticketRepository = new TicketsRepository();
            ITicketCrudService ticketManagerService = new TicketCrudService(ticketRepository);
            ITicketCrudServiceApp ticketManagerServiceApp = new TicketCrudServiceApp(ticketManagerService);
            ticketManagerServiceApp.AddTicket(ticket);
        }
    }
}
