using ProjectManagement.Common.Dto;
using System;
using System.Collections.Generic;

namespace ProjectManagement.Common.Interfaces
{
    public interface IProjectDomain
    {
        List<UserProjectViewModel> Get(int userId);

        string CalculateTimeToStart(DateTime startDate, DateTime assignedDate);

        string CalculateStatus(bool isActive);
    }
}