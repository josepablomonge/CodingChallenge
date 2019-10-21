using ProjectManagement.Common.Dto;
using System.Collections.Generic;

namespace ProjectManagement.Common.Interfaces.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns>Returns the list of all users</returns>
        List<User> Get();
    }
}
