using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Business
{
    public class TicketManager
    {
        BaseBUsiness<Ticket> ticketManager = null;

        public TicketManager()
        {
            if (ticketManager == null)
            {
                ticketManager = new BaseBUsiness<Ticket>();
            }
        }
        public void AddTicket(Ticket ticket) { ticketManager.Add(ticket); }
        public void AddTicket(IEnumerable<Ticket> tickets) { ticketManager.Add(tickets); }
        public void DeleteTicket(Ticket ticket) { ticketManager.Delete(ticket); }
        public void UpdateTicket(Ticket ticket)
        {
            var originalTicket = ticketManager.GetQuery().Where<Ticket>(t => t.TicketId == ticket.TicketId).FirstOrDefault() ?? null;
            ticketManager.Update(originalTicket, ticket);
        }
        public IQueryable<Ticket> GetQuery() { return ticketManager.GetQuery(); }
        public void Save() { ticketManager.Save(); }
    }
}
