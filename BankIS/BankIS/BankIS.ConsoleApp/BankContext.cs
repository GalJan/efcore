using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class BankContext : DbContext 
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Address> Addresses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=bankdb01";
            options.UseSqlServer($"{connectionString}");
        }
    }
}
