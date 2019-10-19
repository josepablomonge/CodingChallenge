using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces;
using System.Collections.Generic;

namespace ProjectManagement.BusinessLogic.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void GetAllUsers()
        {
            var userList = new List<User>();
            userList.Add(new User() { Id = 1, FirstName = "John", LastName = "Lennon" });

            var repositoryMock = new Mock<IUserRepository>();
            repositoryMock.Setup(x => x.Get()).Returns(userList);

            var userDomain = new UserDomain(repositoryMock.Object);
            var result = userDomain.Get();
            Assert.AreEqual(1, result.Count);
        }
    }
}
