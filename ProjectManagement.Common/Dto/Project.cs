using System;
using System.Collections.Generic;

namespace ProjectManagement.Common.Dto
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }

        public List<UserProject> UserProjects { get; set; }
    }
}