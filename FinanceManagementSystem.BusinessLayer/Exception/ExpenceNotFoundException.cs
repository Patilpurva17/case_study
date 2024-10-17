using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace FinanceManagementSystem.BusinessLayer
{
    public class ExpenseNotFoundException : ApplicationException
    {
        public ExpenseNotFoundException(string message) : base(message) { }
    }
}
