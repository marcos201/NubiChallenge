using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NubiChallengeApi.Migrations
{
    public partial class UserHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Apellido", "Email", "Nombre", "Password" },
                values: new object[,]
                {
                    { new Guid("a2543202-d8b2-4d6f-8e6b-58f0c220a3b1"), "Skywalker", "luke@mail.com", "Luke", "luke123" },
                    { new Guid("4463f3fa-a7e7-494d-9776-5fab840d3b74"), "Skywalker", "anakin@mail.com", "Anakin", "anakin123" },
                    { new Guid("166f126b-e2ac-4300-bade-d7180892dab6"), "Kenobi", "obi-wan@mail.com", "Obi-Wan", "obi-wan123" },
                    { new Guid("500ffd38-06f1-480a-b1bd-2db1e3f86db5"), "Skywalker", "leia@mail.com", "Leia", "leia123" },
                    { new Guid("ae9d76ed-93e9-4cac-8f3b-e75212d94814"), "Solo", "han@mail.com", "Han", "han123" },
                    { new Guid("1fe84305-c256-4d8c-a620-d8e8cc2a694a"), "Ren", "kylo@mail.com", "Kylo", "kylo123" },
                    { new Guid("ab95cfab-60b1-484f-ad95-84ac0e40cf54"), "Amidala", "padme@mail.com", "Padme", "padme123" },
                    { new Guid("6822f2e1-ff0f-4b5b-baba-3c03f75fe294"), "Jinn", "qui-gon@mail.com", "Qui-Gon", "qui-gon123" },
                    { new Guid("9c6d9809-4c4c-4227-bd68-3a26a4a78d19"), "Windu", "mace@mail.com", "Mace", "mace123" },
                    { new Guid("59640b60-8966-42ea-b8f2-95cf1a92de38"), "Maul", "darth@mail.com", "Darth", "darth123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("166f126b-e2ac-4300-bade-d7180892dab6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1fe84305-c256-4d8c-a620-d8e8cc2a694a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4463f3fa-a7e7-494d-9776-5fab840d3b74"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("500ffd38-06f1-480a-b1bd-2db1e3f86db5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59640b60-8966-42ea-b8f2-95cf1a92de38"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6822f2e1-ff0f-4b5b-baba-3c03f75fe294"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9c6d9809-4c4c-4227-bd68-3a26a4a78d19"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a2543202-d8b2-4d6f-8e6b-58f0c220a3b1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ab95cfab-60b1-484f-ad95-84ac0e40cf54"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ae9d76ed-93e9-4cac-8f3b-e75212d94814"));
        }
    }
}
