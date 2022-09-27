using _10_Models;
using System.Collections.Generic;

namespace _10_ThreeLayerProject.DAL
{
    public interface IUserRepository /*: IDisposable*/
    {
        public IEnumerable<User> ReadAll();
        public User Read(int id);
        public void Create(User user);
        public void Update(User user);
        public void Delete(int id);
    }
}
