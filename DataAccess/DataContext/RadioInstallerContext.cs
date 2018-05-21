using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.Entity;


namespace DataAccess.DataContext
{
    public class RadioInstallerContext : DbContext
    {

        public RadioInstallerContext()
        {
            System.Data.Entity.Database.SetInitializer<RadioInstallerContext>(null);
        }
    }
}
