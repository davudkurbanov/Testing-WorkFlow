using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class InitialiseDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Mana = table.Column<double>(nullable: false),
                    Manaregen = table.Column<double>(nullable: false),
                    Health = table.Column<double>(nullable: false),
                    Damage = table.Column<double>(nullable: false),
                    DamageType = table.Column<int>(nullable: false),
                    Armor = table.Column<double>(nullable: false),
                    HealthRegen = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Race = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ActionPoints = table.Column<int>(nullable: true),
                    HeroClass = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Skillsort = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Manacost = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TargetType = table.Column<int>(nullable: false),
                    HeroTargetType = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    AmountOfTargets = table.Column<int>(nullable: true),
                    AreaOfEffect = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EffectType = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: true),
                    EffectState = table.Column<int>(nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    ProcChance = table.Column<double>(nullable: true),
                    Multiplier = table.Column<double>(nullable: true),
                    DamageType = table.Column<int>(nullable: true),
                    DealDamage_Amount = table.Column<double>(nullable: true),
                    DealDamage_DamageType = table.Column<int>(nullable: true),
                    Heal_Amount = table.Column<double>(nullable: true),
                    Percentage = table.Column<double>(nullable: true),
                    Reduce_Type = table.Column<int>(nullable: true),
                    Reduce_EffectState = table.Column<int>(nullable: true),
                    Reduce_Amount = table.Column<double>(nullable: true),
                    SilenceDuration = table.Column<double>(nullable: true),
                    Silence_EffectState = table.Column<int>(nullable: true),
                    Duration = table.Column<double>(nullable: true),
                    Stun_EffectState = table.Column<int>(nullable: true),
                    Summon_Amount = table.Column<int>(nullable: true),
                    SummonUnitId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Effects_CardUnits_SummonUnitId",
                        column: x => x.SummonUnitId,
                        principalTable: "CardUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeroItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Img = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SkillId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroItems_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillSets",
                columns: table => new
                {
                    CardUnitId = table.Column<Guid>(nullable: false),
                    SkillId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSets", x => new { x.CardUnitId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_SkillSets_CardUnits_CardUnitId",
                        column: x => x.CardUnitId,
                        principalTable: "CardUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillSets_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "SkillEffects",
                columns: table => new
                {
                    SkillId = table.Column<Guid>(nullable: false),
                    EffectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillEffects", x => new { x.SkillId, x.EffectId });
                    table.ForeignKey(
                        name: "FK_SkillEffects_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillEffects_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Effects_SummonUnitId",
                table: "Effects",
                column: "SummonUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectTargets_TargetId",
                table: "EffectTargets",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroItems_SkillId",
                table: "HeroItems",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillEffects_EffectId",
                table: "SkillEffects",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_SkillId",
                table: "SkillSets",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EffectTargets");

            migrationBuilder.DropTable(
                name: "HeroItems");

            migrationBuilder.DropTable(
                name: "SkillEffects");

            migrationBuilder.DropTable(
                name: "SkillSets");

            migrationBuilder.DropTable(
                name: "Targets");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "CardUnits");
        }
    }
}
