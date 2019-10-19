using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces;

namespace ProjectManagement.Controllers.API
{
    [Produces("application/json")]
    [Route("api/project")]
    public class ProjectController : Controller
    {
        private IProjectDomain _ProjectDomain;

        public ProjectController(IProjectDomain projectDomain)
        {
            _ProjectDomain = projectDomain;
        }

        [HttpGet]
        public IActionResult Get(int userId)
        {
            try
            {
                var projectList = _ProjectDomain.Get(userId);

                if (projectList == null || projectList.Count() == 0)
                {
                    return NotFound();
                }
                return Ok(projectList);
            }
            catch (Exception ex)
            {
                //Log Exception
                return StatusCode(500);
            }
        }
    }
}