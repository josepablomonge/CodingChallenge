using System;

namespace ProjectManagement.Common.Dto
{
    public class UserProject
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public bool IsActive { get; set; }
        public DateTime AssignedDate { get; set; }

        public User User { get; set; }
        public Project Project { get; set; }
    }
}