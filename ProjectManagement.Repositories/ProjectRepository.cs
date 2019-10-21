using Microsoft.EntityFrameworkCore;
using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private DatabaseContext _DBContext;

        public ProjectRepository(DatabaseContext dbContext)
        {
            _DBContext = dbContext;
        }

        public List<UserProject> Get(int userId)
        {
            var userProjectList = _DBContext.UserProjects.Include(x => x.Project).Where(x => x.UserId.Equals(userId)).ToList();
            return userProjectList;
        }
    }
}