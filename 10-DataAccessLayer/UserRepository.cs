using _10_Models;
namespace _10_ThreeLayerProject.DAL
{
    public class UserRepository : IUserRepository /*IDisposable*/
    {

        private UsersContext context;

        public UserRepository(UsersContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> ReadAll()
        {
            return context.Users;
        }
        public User Read(int id)
        {
            return context.Users.Find(id);
        }
        public void Create(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void Update(User user)
        {
            context.Users.Update(user);
        }
        public void Delete(int id)
        {
            var user = context.Users.Find(id);
            if (user != null)
                context.Users.Remove(user);
        }
    }
}

