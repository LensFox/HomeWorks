using _10_ThreeLayerProject.BLL.Entitites;
using _10_ThreeLayerProject.DAL;
using AutoMapper;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace _10_ThreeLayerProject.BLL.Tests
{
    public class UserServiceTests
    {
        [Test]
        public void ReadAll_ThereAreUsers_ReturnsUsers()
        {
            // Arrange
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userEntities = new List<DAL.Entities.User>
            {
                new DAL.Entities.User
                {
                    Age = 11,
                    FirstName = "F",
                    Id = 0,
                    LastName = "L"
                }
            };
            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(q => q.ReadAll())
                .Returns(userEntities);

            var sut = new UserService(userRepositoryMock.Object, mapper);

            var expectedResult = new List<User>
            {
                new User
                {
                    Age = 11,
                    FirstName = "F",
                    Id = 0,
                    LastName = "L"
                }
            };

            // Act
            var actualResult = sut.ReadAll();

            // Assert
            Assert.AreEqual(actualResult.Count(), expectedResult.Count);
            Assert.AreEqual(actualResult.First().Age, expectedResult.First().Age);
            Assert.AreEqual(actualResult.First().FirstName, expectedResult.First().FirstName);
            Assert.AreEqual(actualResult.First().Id, expectedResult.First().Id);
            Assert.AreEqual(actualResult.First().LastName, expectedResult.First().LastName);
        }

        [Test]
        public void ReadAll_NoUsers_ReturnsEmptyList()
        {
            // Arrange
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(q => q.ReadAll())
                .Returns(new List<DAL.Entities.User>());

            var sut = new UserService(userRepositoryMock.Object, mapper);

            // Act
            var actualResult = sut.ReadAll();

            // Assert
            Assert.IsEmpty(actualResult);

            userRepositoryMock.Verify(q => q.ReadAll());
        }
    }
}