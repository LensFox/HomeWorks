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

        [Test]
        public void Read_UserFound_ReturnsUser()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            var userEntity = new DAL.Entities.User()
            {
                Age = 11,
                FirstName = "F",
                Id = 0,
                LastName = "L"
            };
            userRepositoryMock.Setup(q => q.Read(It.IsAny<int>()))
                .Returns(userEntity);
            var sut = new UserService(userRepositoryMock.Object, mapper);
            var expectedResult = new DAL.Entities.User
            {
                Age = 11,
                FirstName = "F",
                Id = 0,
                LastName = "L"
            };

            var actualResult = sut.Read(1);

            Assert.AreEqual(actualResult.Age, expectedResult.Age);
            Assert.AreEqual(actualResult.FirstName, expectedResult.FirstName);
            Assert.AreEqual(actualResult.Id, expectedResult.Id);
            Assert.AreEqual(actualResult.LastName, expectedResult.LastName);
            userRepositoryMock.Verify(q => q.Read(1));
        }

        [Test]
        public void Read_UserNotFound_ReturnsNull()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            DAL.Entities.User userEntity = null;

            userRepositoryMock.Setup(q => q.Read(It.IsAny<int>()))
                .Returns(userEntity);
            var sut = new UserService(userRepositoryMock.Object, mapper);

            var actualResult = sut.Read(1);
            Assert.IsNull(actualResult);
            userRepositoryMock.Verify(q => q.Read(1));
        }

        [Test]
        public void DeleteByName_UsersNotFound_NoDelete()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            var userEntities = new List<DAL.Entities.User>();
            userRepositoryMock.Setup(q => q.ReadAll())
                .Returns(userEntities);
            userRepositoryMock.Setup(q => q.Delete(It.IsAny<int>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.DeleteByName("Timosha Rubanov");

            userRepositoryMock.Verify(q => q.ReadAll());
            userRepositoryMock.VerifyNoOtherCalls();
        }

        [Test]
        public void DeleteByName_UsersDontMatch_NoDelete()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
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
            userRepositoryMock.Setup(q => q.ReadAll())
                .Returns(userEntities);
            userRepositoryMock.Setup(q => q.Delete(It.IsAny<int>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.DeleteByName("Timosha Rubanov");

            userRepositoryMock.Verify(q => q.ReadAll());
            userRepositoryMock.VerifyNoOtherCalls();
        }
        [Test]
        public void DeleteByName_UserFoundFNameFirst_DeleteUser()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
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
            userRepositoryMock.Setup(q => q.ReadAll())
                .Returns(userEntities);
            userRepositoryMock.Setup(q => q.Delete(It.IsAny<int>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.DeleteByName("F L");

            userRepositoryMock.Verify(q => q.ReadAll());
            userRepositoryMock.Verify(q => q.Delete(userEntities.First().Id));
        }

        [Test]
        public void DeleteByName_UserFoundLNameFirst_DeleteUser()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
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
            userRepositoryMock.Setup(q => q.ReadAll())
                .Returns(userEntities);
            userRepositoryMock.Setup(q => q.Delete(It.IsAny<int>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.DeleteByName("L F");

            userRepositoryMock.Verify(q => q.ReadAll());
            userRepositoryMock.Verify(q => q.Delete(userEntities.First().Id));
        }

        [Test]
        public void UpdateById_InputParameterIsNull_NoUpdate()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            var userEntity = new DAL.Entities.User
            {
                Age = 11,
                FirstName = "F",
                Id = 0,
                LastName = "L"
            };
            User inputUser = null;
            userRepositoryMock.Setup(q => q.Read(It.IsAny<int>()))
                .Returns(userEntity);
            userRepositoryMock.Setup(q => q.Update(It.IsAny<DAL.Entities.User>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.UpdateById(inputUser);

            userRepositoryMock.VerifyNoOtherCalls();
        }
        [Test]
        public void UpdateById_NoUserMatch_NoUpdate()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            DAL.Entities.User userEntity = null;
            var inputUser = new User
            {
                Age = 11,
                FirstName = "First",
                Id = 2,
                LastName = "Last"
            };
            userRepositoryMock.Setup(q => q.Read(It.IsAny<int>()))
                .Returns(userEntity);
            userRepositoryMock.Setup(q => q.Update(It.IsAny<DAL.Entities.User>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.UpdateById(inputUser);

            userRepositoryMock.Verify(q => q.Read(inputUser.Id));
            userRepositoryMock.VerifyNoOtherCalls();
        }
        [Test]
        public void UpdateById_UsersMatch_Update()
        {
            var mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile());
            }).CreateMapper();

            var userRepositoryMock = new Mock<IUserRepository>();
            var inputUser = new User
            {
                Age = 11,
                FirstName = "First",
                Id = 2,
                LastName = "Last"
            };
            var userEntity = new DAL.Entities.User()
            {
                Age = 12,
                FirstName = "First",
                Id = 2,
                LastName = "Last"
            };
            var userEntityToUpdate = new DAL.Entities.User()
            {
                Age = 11,
                FirstName = "First",
                Id = 2,
                LastName = "Last"
            };
            userRepositoryMock.Setup(q => q.Read(It.IsAny<int>()))
                .Returns(userEntity);
            //userRepositoryMock.Setup(q => q.Update(It.IsAny<DAL.Entities.User>()));
            var sut = new UserService(userRepositoryMock.Object, mapper);

            sut.UpdateById(inputUser);

            userRepositoryMock.Verify(q => q.Read(inputUser.Id));
            userRepositoryMock.Verify(q => q.Update(userEntityToUpdate));
        }
    }
}