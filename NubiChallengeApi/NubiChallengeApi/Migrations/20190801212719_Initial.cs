using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NubiChallengeApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Apellido", "Created", "Email", "Modified", "Nombre", "Password" },
                values: new object[,]
                {
                    { new Guid("a0000000-0000-0000-0000-000000000001"), "Skywalker", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "luke@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luke", "luke123" },
                    { new Guid("a0000000-0000-0000-0000-000000000002"), "Skywalker", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "anakin@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anakin", "anakin123" },
                    { new Guid("a0000000-0000-0000-0000-000000000003"), "Kenobi", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "obi-wan@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Obi-Wan", "obi-wan123" },
                    { new Guid("a0000000-0000-0000-0000-000000000004"), "Skywalker", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "leia@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leia", "leia123" },
                    { new Guid("a0000000-0000-0000-0000-000000000005"), "Solo", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "han@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Han", "han123" },
                    { new Guid("a0000000-0000-0000-0000-000000000006"), "Ren", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "kylo@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kylo", "kylo123" },
                    { new Guid("a0000000-0000-0000-0000-000000000007"), "Amidala", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "padme@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Padme", "padme123" },
                    { new Guid("a0000000-0000-0000-0000-000000000008"), "Jinn", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "qui-gon@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qui-Gon", "qui-gon123" },
                    { new Guid("a0000000-0000-0000-0000-000000000009"), "Windu", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "mace@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mace", "mace123" },
                    { new Guid("a0000000-0000-0000-0000-000000000010"), "Maul", new DateTime(2019, 8, 1, 18, 27, 19, 365, DateTimeKind.Local), "darth@mail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darth", "darth123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
