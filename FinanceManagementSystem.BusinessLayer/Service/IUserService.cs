using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManagementSystem.Entity;
using FinanceManagementSystem.Entity;

namespace FinanceManagementSystem.BusinessLayer.Service
{
    public interface IUserService
    {
        bool AddUser(User user);
        bool DeleteUser(int userId);
    }
}
