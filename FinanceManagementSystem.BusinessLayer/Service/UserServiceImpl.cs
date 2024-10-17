using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceManagementSystem.BusinessLayer.Repository;
using FinanceManagementSystem.Entity;
using FinanceManagementSystem.BusinessLayer.Repository;
using FinanceManagementSystem.Entity;

namespace FinanceManagementSystem.BusinessLayer.Service
{
    public class UserServiceImpl : IUserService
    {
        private readonly IFinanceRepository _repository;

        public UserServiceImpl(IFinanceRepository repository)
        {
            _repository = repository;
        }

        public bool AddUser(User user)
        {
            return _repository.CreateUser(user);
        }

        public bool DeleteUser(int userId)
        {
            return _repository.DeleteUser(userId);
        }
    }
}
 

