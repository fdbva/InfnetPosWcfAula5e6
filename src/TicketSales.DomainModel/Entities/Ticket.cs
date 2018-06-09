using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSales.DomainModel.Entities
{
    public class Ticket : TEntity
    {
        public string Event { get; set; }
        public DateTime DateTime { get; set; }
        public string Local { get; set; }
    }
}
