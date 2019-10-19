using ProjectManagement.Common.Dto;
using System.Collections.Generic;

namespace ProjectManagement.Common.Interfaces
{
    public interface IUserDomain
    {
        List<User> Get();
    }
}