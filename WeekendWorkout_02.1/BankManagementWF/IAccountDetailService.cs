using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementWF
{
    public interface IAccountDetailService
    {
        List<dataBase> GetAll();
    }
}
