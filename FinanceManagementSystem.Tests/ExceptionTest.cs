using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FinanceManagementSystem.BusinessLayer.Exception;
using NUnit.Framework;

namespace FinanceManagementSystem.Tests
{
    public class ExceptionTest
    {
        [Fact]
        public void UserNotFoundException_ShouldReturnCorrectMessage()
        {
            var message = "User not found";
            var exception = new UserNotFoundException(message);
            Assert.Equals(message, exception.Message);
        }

        [Fact]
        public void ExpenseNotFoundException_ShouldReturnCorrectMessage()
        {
            var message = "Expense not found";
            var exception = new ExpenseNotFoundException(message);
            Assert.Equals(message, exception.Message);
        }
    }
}
