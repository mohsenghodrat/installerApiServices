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
        BaseBUsiness<Installer> installManagers = null;
        public InstallerManager()
        {
            if (installManagers == null)
            {
                installManagers = new BaseBUsiness<Installer>();
            }
        }
        public void AddTicket(Installer ticket) { installManagers.Add(ticket); }
        public void AddTicket(IEnumerable<Installer> tickets) { installManagers.Add(tickets) ; }
        public void DeleteTicket(Installer ticket) { installManagers.Delete(ticket); }
        public void UpdateTicket(Installer ticket)
        {
            var originalTicket = installManagers.GetQuery().Where<Installer>(t => t.UserId == ticket.UserId).FirstOrDefault() ?? null;
            installManagers.Update(originalTicket, ticket);
        }
        public IQueryable<Installer> GetQuery() { return installManagers.GetQuery(); }
    }
}
