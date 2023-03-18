using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementWF.Entities
{
    public class Users:EntityTypeConfiguration<Users>
    {
        
        public string userId { get; set; }
        public int userPass { get; set; }
        public string userName { get; set; }
        public string accountType { get; set; }
        public string accountNumber { get; set; }
        public string cardNumber { get; set; }
        public int balance { get; set; }
        public virtual Users user { get; set; }
    }
}
