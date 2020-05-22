using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MRGGameTekRegistrationApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MrGreenRegistrationDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PersonalNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MrGreenRegistrationDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RedBetRegistrationDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    FavouriteFootBallTeam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedBetRegistrationDbSet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MrGreenRegistrationDbSet");

            migrationBuilder.DropTable(
                name: "RedBetRegistrationDbSet");
        }
    }
}
