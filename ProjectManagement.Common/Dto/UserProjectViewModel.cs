using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagement.Common.Dto
{
    public class UserProjectViewModel
    {
        public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TimeToStart { get; set; }
        public int Credits { get; set; }
        public string Status { get; set; }
    }
}
