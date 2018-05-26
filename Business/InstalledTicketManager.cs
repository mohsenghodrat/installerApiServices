using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Business
{
    public class InstalledTicketManager
    {
        BaseBUsiness<InstalledTicket> installedTicketManager = null;
        public InstalledTicketManager()
        {
            if(installedTicketManager == null)
            {
                installedTicketManager = new BaseBUsiness<InstalledTicket>();
            }
        }
        public void AddTicket(InstalledTicket ticket) { installedTicketManager.Add(ticket); }
        public void AddTicket(IEnumerable<InstalledTicket> tickets) { installedTicketManager.Add(tickets); }
        public void DeleteTicket(InstalledTicket ticket) { installedTicketManager.Delete(ticket); }
        public void UpdateTicket(InstalledTicket ticket)
        {
            var originalTicket = installedTicketManager.GetQuery().Where<InstalledTicket>(t=> t.TicketId == ticket.TicketId).FirstOrDefault() ?? null;
            installedTicketManager.Update(originalTicket, ticket);
        }
        public IQueryable<InstalledTicket> GetQuery() { return installedTicketManager.GetQuery(); }
        public void Save() { installedTicketManager.Save(); }
    }
}
