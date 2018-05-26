using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Business
{
    public class InstallerManager
    {
        BaseBUsiness<Installer> installManager = null;
        public InstallerManager()
        {
            if (installManager == null)
            {
                installManager = new BaseBUsiness<Installer>();
            }
        }
        public void AddTicket(Installer ticket) { installManager.Add(ticket); }
        public void AddTicket(IEnumerable<Installer> tickets) { installManager.Add(tickets) ; }
        public void DeleteTicket(Installer ticket) { installManager.Delete(ticket); }
        public void UpdateTicket(Installer ticket)
        {
            var originalTicket = installManager.GetQuery().Where<Installer>(t => t.UserId == ticket.UserId).FirstOrDefault() ?? null;
            installManager.Update(originalTicket, ticket);
        }
        public IQueryable<Installer> GetQuery() { return installManager.GetQuery(); }
        public void Save() { installManager.Save(); }
    }
}
