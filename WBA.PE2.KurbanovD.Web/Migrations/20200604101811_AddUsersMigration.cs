using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class AddUsersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    AuthenticationToken = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserHeroCards",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    HeroId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHeroCards", x => new { x.UserId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_UserHeroCards_CardUnits_HeroId",
                        column: x => x.HeroId,
                        principalTable: "CardUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserHeroCards_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticationToken", "CreationDate", "FirstName", "LastName", "Password", "Role", "UserName" },
                values: new object[] { new Guid("caa41c5f-5325-40d0-984e-bb8a65603015"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 6, 4, 12, 18, 11, 196, DateTimeKind.Local), "Agent", "FourtySeven", "770150d66c470890da86f7fdf85af234", 0, "BaldnessIsGrace" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticationToken", "CreationDate", "FirstName", "LastName", "Password", "Role", "UserName" },
                values: new object[] { new Guid("39bddd9e-f602-4f6f-8f33-22c11f867ed1"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2020, 6, 4, 12, 18, 11, 197, DateTimeKind.Local), "Gaben", "Newell", "dc1d5ad33491a9aa8eae91c4f968ad24", 1, "AllHailTheKing" });

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroCards_HeroId",
                table: "UserHeroCards",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHeroCards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
