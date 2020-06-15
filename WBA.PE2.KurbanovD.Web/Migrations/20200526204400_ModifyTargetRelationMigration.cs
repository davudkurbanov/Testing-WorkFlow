using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class ModifyTargetRelationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EffectTargets");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "Reduce_Type",
                table: "Effects");

            migrationBuilder.RenameColumn(
                name: "Summon_Amount",
                table: "Effects",
                newName: "AmountToSummon");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Effects",
                newName: "StunDuration");

            migrationBuilder.RenameColumn(
                name: "Reduce_Amount",
                table: "Effects",
                newName: "ReduceAmount");

            migrationBuilder.RenameColumn(
                name: "Percentage",
                table: "Effects",
                newName: "LifeStealPercentage");

            migrationBuilder.RenameColumn(
                name: "Heal_Amount",
                table: "Effects",
                newName: "HealAmount");

            migrationBuilder.RenameColumn(
                name: "DealDamage_Amount",
                table: "Effects",
                newName: "DamageAmount");

            migrationBuilder.RenameColumn(
                name: "ProcChance",
                table: "Effects",
                newName: "CriticalProcChance");

            migrationBuilder.RenameColumn(
                name: "Multiplier",
                table: "Effects",
                newName: "CriticalMultiplier");

            migrationBuilder.AlterColumn<double>(
                name: "Manacost",
                table: "Skills",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TargetId",
                table: "SkillEffects",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "AmplifyType",
                table: "Effects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReduceType",
                table: "Effects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillEffects_TargetId",
                table: "SkillEffects",
                column: "TargetId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillEffects_Targets_TargetId",
                table: "SkillEffects",
                column: "TargetId",
                principalTable: "Targets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillEffects_Targets_TargetId",
                table: "SkillEffects");

            migrationBuilder.DropIndex(
                name: "IX_SkillEffects_TargetId",
                table: "SkillEffects");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "SkillEffects");

            migrationBuilder.DropColumn(
                name: "AmplifyType",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "ReduceType",
                table: "Effects");

            migrationBuilder.RenameColumn(
                name: "AmountToSummon",
                table: "Effects",
                newName: "Summon_Amount");

            migrationBuilder.RenameColumn(
                name: "StunDuration",
                table: "Effects",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "ReduceAmount",
                table: "Effects",
                newName: "Reduce_Amount");

            migrationBuilder.RenameColumn(
                name: "LifeStealPercentage",
                table: "Effects",
                newName: "Percentage");

            migrationBuilder.RenameColumn(
                name: "HealAmount",
                table: "Effects",
                newName: "Heal_Amount");

            migrationBuilder.RenameColumn(
                name: "DamageAmount",
                table: "Effects",
                newName: "DealDamage_Amount");

            migrationBuilder.RenameColumn(
                name: "CriticalProcChance",
                table: "Effects",
                newName: "ProcChance");

            migrationBuilder.RenameColumn(
                name: "CriticalMultiplier",
                table: "Effects",
                newName: "Multiplier");

            migrationBuilder.AlterColumn<int>(
                name: "Manacost",
                table: "Skills",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Effects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reduce_Type",
                table: "Effects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EffectTargets",
                columns: table => new
                {
                    EffectId = table.Column<Guid>(nullable: false),
                    TargetId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectTargets", x => new { x.EffectId, x.TargetId });
                    table.ForeignKey(
                        name: "FK_EffectTargets_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectTargets_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EffectTargets_TargetId",
                table: "EffectTargets",
                column: "TargetId");
        }
    }
}
