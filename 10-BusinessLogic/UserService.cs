using _10_Models;
using _10_ThreeLayerProject.DAL;
using System;
using System.Collections.Generic;

namespace _10_ThreeLayerProject.BLL
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IEnumerable<User> ReadAll()
        {
            return userRepository.ReadAll();
        }
        public User Read(int id)
        {
            return userRepository.Read(id);
        }
        public void Create(User user)
        {
            userRepository.Create(user);
        }
        public void Update(User user)
        {
            userRepository.Update(user);
        }
        public void Delete(int id)
        {
            userRepository.Delete(id);
        }
        public void DeleteByName(string name)
        {
            var allUsers = userRepository.ReadAll();
            foreach (var user in allUsers)
            {
                if ((user.FirstName + " " + user.LastName) == name || (user.LastName + " " + user.FirstName) == name)
                {
                    userRepository.Delete(user.Id);
                }
            }
        }
    }
}
