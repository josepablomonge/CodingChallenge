using ProjectManagement.Common.Dto;
using System.Collections.Generic;

namespace ProjectManagement.Common.Interfaces
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Gets all projects for a user
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>Projects assigned to specified user</returns>
        List<UserProject> Get(int userId); 
    }
}
