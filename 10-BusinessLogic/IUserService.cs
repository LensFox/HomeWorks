using _10_ThreeLayerProject.BLL.Entitites;
using System.Collections.Generic;

namespace _10_ThreeLayerProject.BLL
{
    public interface IUserService
    {
        public IEnumerable<User> ReadAll();
        public User Read(int id);
        public void Create(User user);
        public void Update(User user);
        public void Delete(int id);
        public void DeleteByName(string name);
        public void UpdateById(User user);
    }
}

