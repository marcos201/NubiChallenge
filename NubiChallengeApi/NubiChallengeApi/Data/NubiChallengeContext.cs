using Microsoft.EntityFrameworkCore;
using System;

namespace NubiChallengeApi.Models
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
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Luke",
                        Apellido = "Skywalker",
                        Email = "luke@mail.com",
                        Password = "luke123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Anakin",
                        Apellido = "Skywalker",
                        Email = "anakin@mail.com",
                        Password = "anakin123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Obi-Wan",
                        Apellido = "Kenobi",
                        Email = "obi-wan@mail.com",
                        Password = "obi-wan123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Leia",
                        Apellido = "Skywalker",
                        Email = "leia@mail.com",
                        Password = "leia123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Han",
                        Apellido = "Solo",
                        Email = "han@mail.com",
                        Password = "han123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Kylo",
                        Apellido = "Ren",
                        Email = "kylo@mail.com",
                        Password = "kylo123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Padme",
                        Apellido = "Amidala",
                        Email = "padme@mail.com",
                        Password = "padme123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Qui-Gon",
                        Apellido = "Jinn",
                        Email = "qui-gon@mail.com",
                        Password = "qui-gon123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Mace",
                        Apellido = "Windu",
                        Email = "mace@mail.com",
                        Password = "mace123"
                    },
                    new User
                    {
                        Id = Guid.NewGuid(),
                        Nombre = "Darth",
                        Apellido = "Maul",
                        Email = "darth@mail.com",
                        Password = "darth123"
                    }
                );
        }
    }
}
