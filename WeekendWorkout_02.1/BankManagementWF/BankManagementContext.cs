using BankManagementWF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementWF
{
    public class BankManagementContext : DbContext
    {
        public DbSet<Users> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Users());
        }
    }
}
