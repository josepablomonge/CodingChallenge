using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectManagement.Common.Dto;
using ProjectManagement.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.BusinessLogic.Tests
{
    [TestClass]
    public class ProjectTests
    {
        [TestMethod]
        public void GetProjectsByUser()
        {
            var userProjectList = new List<UserProject>();
            var project1 = new Project()
            {
                Id = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddYears(1),
                Credits = 5
            };

            var project2 = new Project()
            {
                Id = 2,
                StartDate = DateTime.Now.AddDays(-1),
                EndDate = DateTime.Now.AddDays(-1).AddYears(1),
                Credits = 7
            };

            userProjectList.Add(new UserProject()
            {
                ProjectId = 1,
                UserId = 1,
                AssignedDate = DateTime.Now,
                IsActive = true,
                Project = project1
            });

            userProjectList.Add(new UserProject()
            {
                ProjectId = 2,
                UserId = 1,
                AssignedDate = DateTime.Now.AddDays(-1),
                IsActive = false,
                Project = project2
            });

            var repositoryMock = new Mock<IProjectRepository>();
            repositoryMock.Setup(x => x.Get(1)).Returns(userProjectList);
            var projectDomain = new ProjectDomain(repositoryMock.Object);

            var result = projectDomain.Get(1);
            Assert.AreEqual(2, result.Count());

            foreach(var item in result)
            {
                Assert.AreNotEqual(0, item.ProjectId);
                Assert.AreNotEqual(0, item.Credits);
                Assert.IsNotNull(item.StartDate);
                Assert.IsNotNull(item.EndDate);
                Assert.IsNotNull(item.Status);
                Assert.IsNotNull(item.TimeToStart);
            }
        }

        [TestMethod]
        public void TestActiveProject()
        {
            var repositoryMock = new Mock<IProjectRepository>();
            var projectDomain = new ProjectDomain(repositoryMock.Object);
            Assert.AreEqual("Active", projectDomain.CalculateStatus(true));
        }

        [TestMethod]
        public void TestInactiveProject()
        {
            var repositoryMock = new Mock<IProjectRepository>();
            var projectDomain = new ProjectDomain(repositoryMock.Object);
            Assert.AreEqual("Inactive", projectDomain.CalculateStatus(false));
        }

        [TestMethod]
        public void TestTimeToStartDays()
        {
            var startDate = new DateTime(2019, 1, 3);
            var assignedDate = new DateTime(2019, 1, 1);

            var repositoryMock = new Mock<IProjectRepository>();
            var projectDomain = new ProjectDomain(repositoryMock.Object);

            var result = projectDomain.CalculateTimeToStart(startDate, assignedDate);
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void TestStarted()
        {
            var startDate = new DateTime(2019, 1, 1);
            var assignedDate = new DateTime(2019, 1, 3);

            var repositoryMock = new Mock<IProjectRepository>();
            var projectDomain = new ProjectDomain(repositoryMock.Object);

            var result = projectDomain.CalculateTimeToStart(startDate, assignedDate);
            Assert.AreEqual("Started", result);
        }
    }
}
