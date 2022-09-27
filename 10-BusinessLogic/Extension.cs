using _10_ThreeLayerProject.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace _10_ThreeLayerProject.BLL
{
    public static class Extension
    {
        public static void AddRepositories(this IServiceCollection name)
        {
            name.AddTransient<IUserRepository, UserRepository>();
            name.AddDbContext<UsersContext>();
        }
    }
}
