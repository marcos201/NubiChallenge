using Microsoft.EntityFrameworkCore;
using NubiChallengeApi.Core.Shared;
using NubiChallengeApi.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NubiChallengeApi.Data
{
    public class NubiChallengeContext : DbContext
    {
        public NubiChallengeContext(DbContextOptions<NubiChallengeContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000001"),
                        "Luke",
                        "Skywalker",
                        "luke@mail.com",
                        "luke123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000002"),
                        "Anakin",
                        "Skywalker",
                        "anakin@mail.com",
                        "anakin123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000003"),
                        "Obi-Wan",
                        "Kenobi",
                        "obi-wan@mail.com",
                        "obi-wan123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000004"),
                        "Leia",
                        "Skywalker",
                        "leia@mail.com",
                        "leia123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000005"),
                        "Han",
                        "Solo",
                        "han@mail.com",
                        "han123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000006"),
                        "Kylo",
                        "Ren",
                        "kylo@mail.com",
                        "kylo123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000007"),
                        "Padme",
                        "Amidala",
                        "padme@mail.com",
                        "padme123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000008"),
                        "Qui-Gon",
                        "Jinn",
                        "qui-gon@mail.com",
                        "qui-gon123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000009"),
                        "Mace",
                        "Windu",
                        "mace@mail.com",
                        "mace123"
                    ),
                    new User
                    (
                        new Guid("A0000000-0000-0000-0000-000000000010"),
                        "Darth",
                        "Maul",
                        "darth@mail.com",
                        "darth123"
                    )
                );
        }

        public override int SaveChanges()
        {
            AddAuitInfo();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddAuitInfo();
            return await base.SaveChangesAsync();
        }

        private void AddAuitInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).Created = DateTime.UtcNow;
                }
                ((BaseEntity)entry.Entity).Modified = DateTime.UtcNow;
            }
        }
    }
}
