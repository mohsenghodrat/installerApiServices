using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.Entity;
using Common;

namespace DataAccess.DataContext
{
    public class RadioInstallerContext : DbContext
    {
        public DbSet<InstalledTicket> InstalledTickets { get; set; }
        public DbSet<Installer> Installers { get; set; }
        public DbSet<InstallList> InstallLists { get; set; }
        public DbSet<RepairTicket> RepairTickets { get; set; }
        public RadioInstallerContext()
        {
            System.Data.Entity.Database.SetInitializer<RadioInstallerContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InstalledTicket>().ToTable("InstalledTickets", "dbo");
            modelBuilder.Entity<Installer>().ToTable("Installers", "dbo");
            modelBuilder.Entity<InstallList>().ToTable("InstallLists", "dbo");
            modelBuilder.Entity<InstallList>().ToTable("RepairTickets", "dbo");
        }
    }
}
