using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class AddUsersHeroCardsRelationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SummonUnitId",
                table: "UserHeroCards",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39bddd9e-f602-4f6f-8f33-22c11f867ed1"),
                column: "CreationDate",
                value: new DateTime(2020, 6, 5, 23, 34, 26, 242, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caa41c5f-5325-40d0-984e-bb8a65603015"),
                column: "CreationDate",
                value: new DateTime(2020, 6, 5, 23, 34, 26, 241, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_UserHeroCards_SummonUnitId",
                table: "UserHeroCards",
                column: "SummonUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserHeroCards_CardUnits_SummonUnitId",
                table: "UserHeroCards",
                column: "SummonUnitId",
                principalTable: "CardUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserHeroCards_CardUnits_SummonUnitId",
                table: "UserHeroCards");

            migrationBuilder.DropIndex(
                name: "IX_UserHeroCards_SummonUnitId",
                table: "UserHeroCards");

            migrationBuilder.DropColumn(
                name: "SummonUnitId",
                table: "UserHeroCards");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39bddd9e-f602-4f6f-8f33-22c11f867ed1"),
                column: "CreationDate",
                value: new DateTime(2020, 6, 5, 20, 4, 30, 118, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caa41c5f-5325-40d0-984e-bb8a65603015"),
                column: "CreationDate",
                value: new DateTime(2020, 6, 5, 20, 4, 30, 116, DateTimeKind.Local));
        }
    }
}
