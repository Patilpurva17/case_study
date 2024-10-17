using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using FinanceManagementSystem.Entity;
using FinanceManagementSystem.Entity;
using System.Collections.Generic;

namespace FinanceManagementSystem.BusinessLayer.Repository
{
    public interface IFinanceRepository
    {
        bool CreateUser(User user);
        bool CreateExpense(Expense expense);
        bool DeleteUser(int userId);
        bool DeleteExpense(int expenseId);
        List<Expense> GetAllExpenses(int userId);
        bool UpdateExpense(int userId, Expense expense);
    }
}


