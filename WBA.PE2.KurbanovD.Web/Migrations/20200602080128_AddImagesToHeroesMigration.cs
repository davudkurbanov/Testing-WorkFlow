using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class AddImagesToHeroesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"),
                column: "Img",
                value: "ChaosKnight.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"),
                column: "Img",
                value: "Juggernaut.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"),
                column: "Img",
                value: "Dazzle.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"),
                column: "Img",
                value: "BountyHunter.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("7129011f-bca0-4449-9629-3a46198267a1"),
                column: "Img",
                value: "DrowRanger.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"),
                column: "Img",
                value: "Tusk.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"),
                column: "Img",
                value: "QueenOfPain.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"),
                column: "Img",
                value: "ShadowFiend.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"),
                column: "Img",
                value: "Lich.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("e618edeb-ba86-449a-9602-896adb2db850"),
                column: "Img",
                value: "Enchantress.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("f6620430-3d02-4bae-9802-066434d03668"),
                column: "Img",
                value: "CrystalMaiden.jpg");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"),
                column: "Img",
                value: "TrollWarlord.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"),
                column: "Img",
                value: "ChaosKnight");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"),
                column: "Img",
                value: "Juggernaut");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"),
                column: "Img",
                value: "Dazzle");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"),
                column: "Img",
                value: "BountyHunter");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("7129011f-bca0-4449-9629-3a46198267a1"),
                column: "Img",
                value: "DrowRanger");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"),
                column: "Img",
                value: "Tusk");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"),
                column: "Img",
                value: "QueenOfPain");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"),
                column: "Img",
                value: "ShadowFiend");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"),
                column: "Img",
                value: "Lich");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("e618edeb-ba86-449a-9602-896adb2db850"),
                column: "Img",
                value: "Enchantress");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("f6620430-3d02-4bae-9802-066434d03668"),
                column: "Img",
                value: "CrystalMaiden");

            migrationBuilder.UpdateData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"),
                column: "Img",
                value: "TrollWarlord");
        }
    }
}
