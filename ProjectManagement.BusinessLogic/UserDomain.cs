﻿using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces;
using System.Collections.Generic;

namespace ProjectManagement.BusinessLogic
{
    public class UserDomain : IUserDomain
    {
        private IUserRepository _UserRepository;

        public UserDomain(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public List<User> Get()
        {
            return _UserRepository.Get();
        }
    }
}