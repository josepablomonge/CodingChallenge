using System.Collections.Generic;

namespace ProjectManagement.Common.Dto
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<UserProject> UserProjects { get; set; }
    }
}