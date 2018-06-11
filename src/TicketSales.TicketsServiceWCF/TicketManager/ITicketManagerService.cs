using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TicketSales.DomainModel.Entities;

namespace TicketSales.TicketsServiceWCF.TicketManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITicketCrudService" in both code and config file together.
    [ServiceContract]
    public interface ITicketManagerService
    {
        [OperationContract]
        void AddTicket(Ticket ticket);
    }
}
