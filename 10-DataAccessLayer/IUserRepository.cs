using _10_ThreeLayerProject.DAL.Entities;
using System.Collections.Generic;

namespace _10_ThreeLayerProject.DAL
{
    public interface IUserRepository
    {
        public IEnumerable<User> ReadAll();
        public User Read(int id);
        public void Create(User user);
        public void Update(User user);
        public void Delete(int id);
    }
}
