using DogBNB.Models;
using Microsoft.EntityFrameworkCore;

namespace DogBNB_Db
{
    public class DogBNBDbContext : DbContext
    {
        public DogBNBDbContext(DbContextOptions<DogBNBDbContext> options) : base(options)
        {

        }

        public DbSet<Dog> Dogs { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
