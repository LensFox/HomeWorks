using _10_ThreeLayerProject.BLL.Entitites;
using _10_ThreeLayerProject.DAL;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace _10_ThreeLayerProject.BLL
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public IEnumerable<User> ReadAll()
        {
            var userEntities = userRepository.ReadAll();
            var users = mapper.Map<List<User>>(userEntities);

            return users;
        }

        public User Read(int id)
        {
            return mapper.Map<User>(userRepository.Read(id));
        }

        public void Create(User user)
        {
            userRepository.Create(mapper.Map<DAL.Entities.User>(user));
        }

        public void Update(User user)
        {
            userRepository.Update(mapper.Map<DAL.Entities.User>(user));
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

        public void UpdateById(User user)
        {
            var userToUpdate = userRepository.Read(user.Id);
            if (userToUpdate != null)
            {
                if (user.FirstName != null)
                {
                    userToUpdate.FirstName = user.FirstName;
                }
                if (user.LastName != null)
                {
                    userToUpdate.FirstName = user.LastName;
                }
                if (user.Age >= 0)
                {
                    userToUpdate.Age = user.Age;
                }
                userRepository.Update(userToUpdate);
            }
        }
    }
}
