using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManagementSystem.BusinessLayer.Repository;
using FinanceManagementSystem.Entity;
using System.Collections.Generic;
using FinanceManagementSystem.BusinessLayer.Repository;
using FinanceManagementSystem.Entity;
using System.Collections.Generic;

namespace FinanceManagementSystem.BusinessLayer.Service
{
    public class ExpenseServiceImpl : IExpenseService
    {
        private readonly IFinanceRepository _repository;

        public ExpenseServiceImpl(IFinanceRepository repository)
        {
            _repository = repository;
        }

        public bool AddExpense(Expense expense)
        {
            return _repository.CreateExpense(expense);
        }

        public List<Expense> GetExpensesByUser(int userId)
        {
            return _repository.GetAllExpenses(userId);
        }

        public bool UpdateExpense(int userId, Expense expense)
        {
            return _repository.UpdateExpense(userId, expense);
        }

        public bool DeleteExpense(int expenseId)
        {
            return _repository.DeleteExpense(expenseId);
        }
    }
}

