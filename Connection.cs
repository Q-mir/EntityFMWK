using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFMWK
{
    public class Connection : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"Data Source = qmir-main;
                        Initial Catalog = EntityTest;
                        Integrated Security = true;
                        TrustServerCertificate = Yes;";

            optionsBuilder.UseSqlServer(path);

        }
    }
}
