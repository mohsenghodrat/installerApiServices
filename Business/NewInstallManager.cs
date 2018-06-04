using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Business
{
    public class NewInstallManager
    {
        BaseBUsiness<NewInstall> installedTicketManager = null;
        public NewInstallManager()
        {
            if(installedTicketManager == null)
            {
                installedTicketManager = new BaseBUsiness<NewInstall>();
            }
        }
        public void AddTicket(NewInstall ticket) { installedTicketManager.Add(ticket); }
        public void AddTicket(IEnumerable<NewInstall> tickets) { installedTicketManager.Add(tickets); }
        public void DeleteTicket(NewInstall ticket) { installedTicketManager.Delete(ticket); }
        public void UpdateTicket(NewInstall ticket)
        {
            var originalTicket = installedTicketManager.GetQuery().Where<NewInstall>(t=> t.TicketId == ticket.TicketId).FirstOrDefault() ?? null;
            installedTicketManager.Update(originalTicket, ticket);
        }
        public IQueryable<NewInstall> GetQuery() { return installedTicketManager.GetQuery(); }
        public void Save() { installedTicketManager.Save(); }
    }
}
