using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManagementSystem.Entity;
using System.Collections.Generic;
using FinanceManagementSystem.Entity;
using System.Collections.Generic;

namespace FinanceManagementSystem.BusinessLayer.Service
{
    public interface IExpenseService
    {
        bool AddExpense(Expense expense);
        List<Expense> GetExpensesByUser(int userId);
        bool UpdateExpense(int userId, Expense expense);
        bool DeleteExpense(int expenseId);
    }
}


