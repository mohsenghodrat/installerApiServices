using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Business
{
    public class InstallListManager
    {
        BaseBUsiness<InstallList> installListManager = null;
        public InstallListManager()
        {
            if (installListManager == null)
            {
                installListManager = new BaseBUsiness<InstallList>();
            }
        }
        public void AddTicket(InstallList ticket) { installListManager.Add(ticket); }
        public void AddTicket(IEnumerable<InstallList> tickets) { installListManager.Add(tickets); }
        public void DeleteTicket(InstallList ticket) { installListManager.Delete(ticket); }
        public void UpdateTicket(InstallList ticket)
        {
            var originalTicket = installListManager.GetQuery().Where<InstallList>(t=> t.TicketId == ticket.TicketId).FirstOrDefault() ?? null;
            installListManager.Update(originalTicket,ticket);
        }
        public IQueryable<InstallList> GetQuery() { return installListManager.GetQuery(); }
        public void Save() { installListManager.Save(); }
    }
}
