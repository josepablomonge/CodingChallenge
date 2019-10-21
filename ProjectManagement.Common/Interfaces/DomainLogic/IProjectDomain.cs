using ProjectManagement.Common.Dto;
using System;
using System.Collections.Generic;

namespace ProjectManagement.Common.Interfaces.DomainLogic
{
    public interface IProjectDomain
    {
        /// <summary>
        /// Gets all projects for a user
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>Projects assigned to specified user</returns>
        List<UserProjectViewModel> Get(int userId);

        /// <summary>
        /// Calculate Time to Start Project
        /// </summary>
        /// <param name="startDate">Start Date</param>
        /// <param name="assignedDate">Assigned Date</param>
        /// <returns>Time to start. If negarive it returns "Started"</returns>
        string CalculateTimeToStart(DateTime startDate, DateTime assignedDate);

        /// <summary>
        /// Inidicates is active or Inactive
        /// </summary>
        /// <param name="isActive">boolean indicating if active or inactive</param>
        /// <returns>Returns Active or Inactive as Description</returns>
        string CalculateStatus(bool isActive);
    }
}