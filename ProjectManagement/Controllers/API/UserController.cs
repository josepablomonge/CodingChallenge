using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces;

namespace ProjectManagement.Controllers.API
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UserController : Controller
    {
        private IUserDomain _UserDomain;

        public UserController(IUserDomain userDomain)
        {
            _UserDomain = userDomain;
        }

        [HttpGet]
        public List<User> Get()
        {
            try
            {
                return _UserDomain.Get();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}