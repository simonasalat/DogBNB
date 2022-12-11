
using DogBNB_Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DogBNB_Db
{
    public class DogBNBDbContext : DbContext
    {
        public DogBNBDbContext(DbContextOptions<DogBNBDbContext> options) : base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Address> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Sitter> Sitters { get; set; }
        public DbSet<Callendar> Callendars { get; set; }
        public DbSet<Review> Reviews { get; set; }



    }
}
