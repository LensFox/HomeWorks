using _10_ThreeLayerProject.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace _10_ThreeLayerProject.DAL
{
    public class UsersContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UsersDb;Trusted_Connection=True;");
        }
    }
}
