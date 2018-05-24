using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Business
{
    public class RepairTicketManager
    {
        BaseBUsiness<RepairTicket> repairTicketManager = null;
        public RepairTicketManager()
        {
            if( repairTicketManager == null )
            {
                repairTicketManager = new BaseBUsiness<RepairTicket>();
            }
        }
        public void AddTicket(RepairTicket ticket)
        {
            repairTicketManager.Add(ticket);
        }
        public void AddTicket(IEnumerable<RepairTicket> tickets)
        {
            repairTicketManager.Add(tickets);
        }
        public void DeleteTicket(RepairTicket ticket)
        {
            repairTicketManager.Delete(ticket);
        }
        public void UpdateTicket(RepairTicket ticket)
        {
            var originalTicket = repairTicketManager.GetQuery().Where(t => t.TicketId == ticket.TicketId).LastOrDefault() ?? null;
            repairTicketManager.Update(originalTicket, ticket);
        }
        public IQueryable<RepairTicket> GetAllQuery()
        {
            return repairTicketManager.GetQuery();
        }
    }
}
