using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementWF
{
    public class BankManagementContext:DbContext
    {
        public DbSet<dataBase> dataBases { get; set; }
    }
}
