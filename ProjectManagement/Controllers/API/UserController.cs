using System;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Common.Interfaces.DomainLogic;

namespace ProjectManagement.Controllers.API
{
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : Controller
    {
        private IUserDomain _UserDomain;

        public UserController(IUserDomain userDomain)
        {
            _UserDomain = userDomain;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                
                var userList = _UserDomain.Get();
                return Ok(userList);
            }
            catch(Exception ex)
            {
                //Log Exception
                return StatusCode(500);
            }
        }
    }
}