
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

        public DbSet<Sitter> Sitters { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<Dog>().Property<DateTime?>("DeletedAt");
        //    builder.Entity<Dog>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
        //    builder.Entity<Order>().Property<DateTime?>("DeletedAt");
        //    builder.Entity<Order>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
        //    builder.Entity<Location>().Property<DateTime?>("DeletedAt");
        //    builder.Entity<Location>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
        //    builder.Entity<User>().Property<DateTime?>("DeletedAt");
        //    builder.Entity<User>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);

        //}
        //public override int SaveChanges()
        //{
        //    UpdateSoftDeleteStatuses();
        //    return base.SaveChanges();
        //}

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateSoftDeleteStatuses();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void UpdateSoftDeleteStatuses()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["DeletedAt"] = null;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["DeletedAt"] = DateTime.UtcNow;
                        break;
                }
            }
        }

    }
}
