using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementWF.Entities
{
    public class Users
    {
        
        public string userId { get; set; }
        public int userPass { get; set; }
        public string userName { get; set; }
        public string accountType { get; set; }
        public string accountNumber { get; set; }
        public string cardNumber { get; set; }
        public int balance { get; set; }
    }
}
