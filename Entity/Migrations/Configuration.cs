using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Migrations
{
    using Entity.Repositorios;
    using System.Data.Entity.Migrations;
   

        internal sealed class Configuration : DbMigrationsConfiguration<POSDbContext>
        {
            public Configuration()
            {
                AutomaticMigrationsEnabled = false;
            }

            protected override void Seed(POSDbContext context)
            {

            }
        }
    
}
