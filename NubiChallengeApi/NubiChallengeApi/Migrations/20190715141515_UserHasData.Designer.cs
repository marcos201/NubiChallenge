﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NubiChallengeApi.Models;

namespace NubiChallengeApi.Migrations
{
    [DbContext(typeof(NubiChallengeContext))]
    [Migration("20190715141515_UserHasData")]
    partial class UserHasData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NubiChallengeApi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = new Guid("a2543202-d8b2-4d6f-8e6b-58f0c220a3b1"), Apellido = "Skywalker", Email = "luke@mail.com", Nombre = "Luke", Password = "luke123" },
                        new { Id = new Guid("4463f3fa-a7e7-494d-9776-5fab840d3b74"), Apellido = "Skywalker", Email = "anakin@mail.com", Nombre = "Anakin", Password = "anakin123" },
                        new { Id = new Guid("166f126b-e2ac-4300-bade-d7180892dab6"), Apellido = "Kenobi", Email = "obi-wan@mail.com", Nombre = "Obi-Wan", Password = "obi-wan123" },
                        new { Id = new Guid("500ffd38-06f1-480a-b1bd-2db1e3f86db5"), Apellido = "Skywalker", Email = "leia@mail.com", Nombre = "Leia", Password = "leia123" },
                        new { Id = new Guid("ae9d76ed-93e9-4cac-8f3b-e75212d94814"), Apellido = "Solo", Email = "han@mail.com", Nombre = "Han", Password = "han123" },
                        new { Id = new Guid("1fe84305-c256-4d8c-a620-d8e8cc2a694a"), Apellido = "Ren", Email = "kylo@mail.com", Nombre = "Kylo", Password = "kylo123" },
                        new { Id = new Guid("ab95cfab-60b1-484f-ad95-84ac0e40cf54"), Apellido = "Amidala", Email = "padme@mail.com", Nombre = "Padme", Password = "padme123" },
                        new { Id = new Guid("6822f2e1-ff0f-4b5b-baba-3c03f75fe294"), Apellido = "Jinn", Email = "qui-gon@mail.com", Nombre = "Qui-Gon", Password = "qui-gon123" },
                        new { Id = new Guid("9c6d9809-4c4c-4227-bd68-3a26a4a78d19"), Apellido = "Windu", Email = "mace@mail.com", Nombre = "Mace", Password = "mace123" },
                        new { Id = new Guid("59640b60-8966-42ea-b8f2-95cf1a92de38"), Apellido = "Maul", Email = "darth@mail.com", Nombre = "Darth", Password = "darth123" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
