using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Common.Interfaces;

namespace ProjectManagement.Controllers.API
{
    [Produces("application/json")]
    [Route("api/Project")]
    public class ProjectController : Controller
    {
        private IProjectDomain _ProjectDomain;

        public ProjectController(IProjectDomain projectDomain)
        {
            _ProjectDomain = projectDomain;
        }
    }
}