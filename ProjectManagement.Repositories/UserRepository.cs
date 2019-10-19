using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DatabaseContext _DBContext;

        public UserRepository(DatabaseContext dbContext)
        {
            _DBContext = dbContext;
        }

        public List<User> Get()
        {
            var userList = _DBContext.Users.ToList();
            return userList;
        }
    }
}
