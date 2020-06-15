using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class AddSummonUnitToEffectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SummonUnitId1",
                table: "Effects",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Effects_SummonUnitId1",
                table: "Effects",
                column: "SummonUnitId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Effects_CardUnits_SummonUnitId1",
                table: "Effects",
                column: "SummonUnitId1",
                principalTable: "CardUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Effects_CardUnits_SummonUnitId1",
                table: "Effects");

            migrationBuilder.DropIndex(
                name: "IX_Effects_SummonUnitId1",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "SummonUnitId1",
                table: "Effects");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39bddd9e-f602-4f6f-8f33-22c11f867ed1"),
                column: "CreationDate",
                value: new DateTime(2020, 6, 4, 12, 18, 11, 197, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("caa41c5f-5325-40d0-984e-bb8a65603015"),
                column: "CreationDate",
                value: new DateTime(2020, 6, 4, 12, 18, 11, 196, DateTimeKind.Local));
        }
    }
}
