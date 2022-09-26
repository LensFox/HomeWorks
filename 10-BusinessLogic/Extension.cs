using _10_ThreeLayerProject.DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
