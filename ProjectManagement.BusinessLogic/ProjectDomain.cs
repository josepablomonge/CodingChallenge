using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces.DomainLogic;
using ProjectManagement.Common.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.BusinessLogic
{
    public class ProjectDomain : IProjectDomain
    {
        private IProjectRepository _ProjectRepository;

        public ProjectDomain(IProjectRepository projectRepository)
        {
            _ProjectRepository = projectRepository;
        }

        public List<UserProjectViewModel> Get(int userId)
        {
            var userProjects = _ProjectRepository.Get(userId);

            var result = userProjects.Select(x => new UserProjectViewModel()
            {
                ProjectId = x.ProjectId,
                StartDate = x.Project.StartDate,
                EndDate = x.Project.EndDate,
                Credits = x.Project.Credits,
                TimeToStart = CalculateTimeToStart(x.Project.StartDate, x.AssignedDate),
                Status = CalculateStatus(x.IsActive)
            }).ToList();

            return result;
        }

        public string CalculateTimeToStart(DateTime startDate, DateTime assignedDate)
        {
            var days = (startDate - assignedDate).Days;

            if (days < 0)
            {
                return "Started";
            }
            else
            {
                return days.ToString();
            }
        }

        public string CalculateStatus(bool isActive)
        {
            return isActive ? "Active" : "Inactive";
        }
    }
}
