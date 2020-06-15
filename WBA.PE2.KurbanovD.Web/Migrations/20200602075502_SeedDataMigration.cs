using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WBA.PE2.KurbanovD.Web.Migrations
{
    public partial class SeedDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillEffects",
                table: "SkillEffects");

            migrationBuilder.DropIndex(
                name: "IX_SkillEffects_TargetId",
                table: "SkillEffects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillEffects",
                table: "SkillEffects",
                columns: new[] { "SkillId", "EffectId", "TargetId" });

            migrationBuilder.InsertData(
                table: "CardUnits",
                columns: new[] { "Id", "Armor", "Damage", "DamageType", "Description", "Discriminator", "Health", "HealthRegen", "Img", "Mana", "Manaregen", "Name", "Race" },
                values: new object[,]
                {
                    { new Guid("dedb8175-0d78-4644-9ec9-eb0a7b8315a4"), 5.0, 1.0, 0, "", "SummonUnit", 100.0, 25.0, "Nature'sAttendant.jpg", 1.0, 1.0, "Nature's Attendant", 6 },
                    { new Guid("27f53ca1-3a40-4462-961d-d860547d8417"), 5.0, 1.0, 0, "", "SummonUnit", 100.0, 25.0, "FearfulSigil.jpg", 1.0, 1.0, "Fearful Sigil", 7 }
                });

            migrationBuilder.InsertData(
                table: "CardUnits",
                columns: new[] { "Id", "Armor", "Damage", "DamageType", "Description", "Discriminator", "Health", "HealthRegen", "Img", "Mana", "Manaregen", "Name", "Race", "ActionPoints", "HeroClass" },
                values: new object[,]
                {
                    { new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"), 5.0, 95.0, 0, "", "Hero", 300.0, 25.0, "BountyHunter", 3.0, 0.5, "Bounty Hunter", 3, 2, 4 },
                    { new Guid("f6620430-3d02-4bae-9802-066434d03668"), 3.0, 35.0, 1, "", "Hero", 300.0, 15.0, "CrystalMaiden", 5.0, 1.0, "Crystal Maiden", 0, 1, 6 },
                    { new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"), 5.0, 45.0, 0, "", "Hero", 450.0, 50.0, "Dazzle", 3.0, 1.0, "Dazzle", 5, 3, 7 },
                    { new Guid("7129011f-bca0-4449-9629-3a46198267a1"), 2.0, 75.0, 0, "", "Hero", 300.0, 20.0, "DrowRanger", 3.0, 0.5, "Drow Ranger", 4, 1, 0 },
                    { new Guid("e618edeb-ba86-449a-9602-896adb2db850"), 4.0, 55.0, 0, "", "Hero", 300.0, 15.0, "Enchantress", 5.0, 1.0, "Enchantress", 3, 1, 7 },
                    { new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"), 8.0, 75.0, 2, "", "Hero", 600.0, 35.0, "ChaosKnight", 3.0, 0.5, "Chaos Knight", 1, 4, 5 },
                    { new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"), 3.0, 45.0, 1, "", "Hero", 450.0, 25.0, "Lich", 6.0, 2.0, "Lich", 4, 2, 6 },
                    { new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"), 1.0, 60.0, 2, "", "Hero", 400.0, 10.0, "QueenOfPain", 3.0, 0.5, "Queen Of Pain", 1, 3, 4 },
                    { new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"), 3.0, 65.0, 2, "", "Hero", 400.0, 10.0, "ShadowFiend", 5.0, 0.5, "Shadow Fiend", 1, 5, 2 },
                    { new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"), 12.0, 85.0, 0, "", "Hero", 650.0, 50.0, "TrollWarlord", 3.0, 0.5, "Troll Warlord", 5, 4, 1 },
                    { new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"), 6.0, 75.0, 0, "", "Hero", 550.0, 45.0, "Tusk", 3.0, 0.5, "Tusk", 3, 2, 1 },
                    { new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"), 5.0, 60.0, 0, "", "Hero", 600.0, 25.0, "Juggernaut", 4.0, 0.5, "Juggernaut", 0, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Reduce_EffectState", "ReduceAmount", "ReduceType" },
                values: new object[] { new Guid("fddacf94-fb30-4476-be90-6c9ecd14c9c2"), "", "Reduce", 8, 1, 50.0, 2 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "LifeStealPercentage" },
                values: new object[] { new Guid("72ef6e9f-23a9-41c5-817d-3ba44b6ffc5f"), "", "Lifesteal", 6, 3.0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Reduce_EffectState", "ReduceAmount", "ReduceType" },
                values: new object[,]
                {
                    { new Guid("16b9e7ba-239d-4c5b-a337-f3f78fff8065"), "", "Reduce", 8, 1, 5.0, 5 },
                    { new Guid("04b17411-2761-465b-84cf-ac0e3589073d"), "", "Reduce", 8, 1, 10.0, 5 },
                    { new Guid("6634567a-136f-4c81-af40-7b08aba8e5f4"), "", "Reduce", 8, 1, 15.0, 5 },
                    { new Guid("ecaee0cf-bafa-4f21-8e6d-2e5fbd3cfe87"), "", "Reduce", 8, 1, 50.0, 0 },
                    { new Guid("9faee829-0506-4e85-9892-decee6915dba"), "", "Reduce", 8, 1, 200.0, 1 },
                    { new Guid("b0c0f122-5310-4e9d-b809-c5727a6a11b0"), "", "Reduce", 8, 1, 400.0, 1 },
                    { new Guid("16bde603-b191-4d96-a7fd-f5fb4609e357"), "", "Reduce", 8, 1, 100.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Stun_EffectState", "StunDuration" },
                values: new object[] { new Guid("a0c92644-5852-4a0d-884f-f27ca162fa0e"), "", "Stun", 7, 1, 3.0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Reduce_EffectState", "ReduceAmount", "ReduceType" },
                values: new object[] { new Guid("8ed07187-66df-4d46-b1a0-1bdeb8dbacc8"), "", "Reduce", 8, 1, 1.5, 4 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Silence_EffectState", "SilenceDuration" },
                values: new object[,]
                {
                    { new Guid("c650314d-e527-43ce-9932-5a6b01e7e309"), "", "Silence", 4, 1, 2.0 },
                    { new Guid("0025b00d-bbae-47ea-9d0d-e47f5c72ff3d"), "", "Silence", 4, 1, 4.0 },
                    { new Guid("f44a84c3-c6eb-42ec-9bb7-c69d9b6abdc0"), "", "Silence", 4, 1, 6.0 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Stun_EffectState", "StunDuration" },
                values: new object[] { new Guid("0feb5631-dd56-44b2-a207-00ee33551f09"), "", "Stun", 7, 1, 2.0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "LifeStealPercentage" },
                values: new object[] { new Guid("1c021dbd-16a9-4146-b810-ff1d36211599"), "", "Lifesteal", 6, 1.0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Stun_EffectState", "StunDuration" },
                values: new object[,]
                {
                    { new Guid("f7a3978f-30de-4d76-b087-e5146c788b6b"), "", "Stun", 7, 1, 4.0 },
                    { new Guid("4c7c8b0a-5409-41f9-a97d-00f3c7abc45b"), "", "Stun", 7, 1, 6.0 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Reduce_EffectState", "ReduceAmount", "ReduceType" },
                values: new object[] { new Guid("3fff91e9-8452-488f-bd23-26d3d308ab14"), "", "Reduce", 8, 1, 5.0, 3 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "LifeStealPercentage" },
                values: new object[] { new Guid("55301e2e-9fb6-42cb-9973-498dc910fab1"), "", "Lifesteal", 6, 0.5 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Amount", "AmplifyType", "EffectState" },
                values: new object[] { new Guid("44c83bc1-ecf8-4d19-b2cf-c608dcb4fe6a"), "", "Amplify", 0, 5.0, 5, 0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "HealAmount" },
                values: new object[] { new Guid("2d81259f-a7eb-4fa8-bfdb-613f93e6a9a4"), "", "Heal", 1, 300.0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Amount", "AmplifyType", "EffectState" },
                values: new object[,]
                {
                    { new Guid("d818f097-d830-4b3b-aaec-5abc73d5be59"), "", "Amplify", 0, 1.0, 4, 0 },
                    { new Guid("b12bbe16-3e81-4500-abb9-625f88e384f5"), "", "Amplify", 0, 10.0, 5, 0 },
                    { new Guid("85c2344e-22d7-42e2-aced-84c35c8eb13c"), "", "Amplify", 0, 15.0, 0, 0 },
                    { new Guid("df2f81c9-54cc-4ddf-ae55-eb59a664aa30"), "", "Amplify", 0, 10.0, 3, 0 },
                    { new Guid("783a580c-8153-457c-847f-4e137c7e9b44"), "", "Amplify", 0, 25.0, 0, 0 },
                    { new Guid("a4d29024-307a-4a9b-8fe1-8db09421d73a"), "", "Amplify", 0, 50.0, 0, 0 },
                    { new Guid("eebe8f58-962c-4a81-8d9a-ea9c0b63d9d7"), "", "Amplify", 0, 1.5, 4, 0 },
                    { new Guid("715f2754-f78d-441f-9b94-4bc0946b1e67"), "", "Amplify", 0, 100.0, 0, 0 },
                    { new Guid("0079b4f4-a17b-4326-ba40-f2e9753f0b23"), "", "Amplify", 0, 500.0, 1, 0 },
                    { new Guid("874a9cf7-9719-4bbf-8e7f-30b4c77712e4"), "", "Amplify", 0, 25.0, 2, 0 },
                    { new Guid("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"), "", "Amplify", 0, 50.0, 2, 0 },
                    { new Guid("f7f13521-0089-4759-9873-ebe96c46b4ca"), "", "Amplify", 0, 100.0, 2, 0 },
                    { new Guid("03f7e71e-1729-4b24-a192-90c0470d83ed"), "", "Amplify", 0, 5.0, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "LifeStealPercentage" },
                values: new object[] { new Guid("ec381dc9-c1e5-47fb-8c57-51678224f07f"), "", "Lifesteal", 6, 0.25 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "Amount", "AmplifyType", "EffectState" },
                values: new object[,]
                {
                    { new Guid("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"), "", "Amplify", 0, 250.0, 1, 0 },
                    { new Guid("efbbfc8a-6bd7-46a8-8587-455005778bb4"), "", "Amplify", 0, 3.0, 4, 0 },
                    { new Guid("265e0345-f383-4ac8-b33c-a4e20ee05faa"), "", "Amplify", 0, 20.0, 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "CriticalMultiplier", "CriticalProcChance", "DamageType" },
                values: new object[] { new Guid("b5c330f2-23b4-4bf2-9481-55099367269c"), "", "CriticalHit", 3, 4.0, 0.2, 0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "HealAmount" },
                values: new object[,]
                {
                    { new Guid("1a78deb7-c5d1-43de-be46-5945153a6aca"), "", "Heal", 1, 150.0 },
                    { new Guid("460be20d-f644-4bc2-9286-7ead03b64e9c"), "", "Heal", 1, 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "DamageAmount", "DealDamage_DamageType" },
                values: new object[] { new Guid("3e8534bc-9679-4380-9034-1b9d62d6b8f5"), "", "DealDamage", 2, 300.0, 0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "CriticalMultiplier", "CriticalProcChance", "DamageType" },
                values: new object[] { new Guid("aba933fd-0da7-41aa-a4fb-19e9f6a4e86e"), "", "CriticalHit", 3, 2.0, 0.2, 0 });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "DamageAmount", "DealDamage_DamageType" },
                values: new object[,]
                {
                    { new Guid("915f8f7d-2a9d-4995-ae89-9d6f6e7bb40d"), "", "DealDamage", 2, 300.0, 1 },
                    { new Guid("1dacb3a7-21f4-4439-b23d-c1e693084ee4"), "", "DealDamage", 2, 200.0, 1 },
                    { new Guid("80e4330a-1ec5-498d-b3b9-eb74cef24775"), "", "DealDamage", 2, 200.0, 2 },
                    { new Guid("e5af0d52-5663-44f2-b537-dace6d117229"), "", "DealDamage", 2, 300.0, 2 },
                    { new Guid("b1c4dd1a-d2cc-4f16-842e-c5b99bfcb4bd"), "", "DealDamage", 2, 150.0, 1 },
                    { new Guid("64e1a36b-d705-468f-8bfd-58d60d01a9a8"), "", "DealDamage", 2, 100.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "CriticalMultiplier", "CriticalProcChance", "DamageType" },
                values: new object[,]
                {
                    { new Guid("25b2142f-ad42-4f4c-9c3e-855e465b28a6"), "", "CriticalHit", 3, 2.5, 1.0, 0 },
                    { new Guid("d436f5e5-d729-4d24-be7b-52e235b3bda8"), "", "CriticalHit", 3, 2.0, 0.3, 0 },
                    { new Guid("d5bd4c65-41a0-4bdc-a155-30d3d343b774"), "", "CriticalHit", 3, 2.5, 0.25, 0 },
                    { new Guid("10076a8f-db65-4226-b910-cf6059cbe8d1"), "", "CriticalHit", 3, 4.0, 0.2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "DamageAmount", "DealDamage_DamageType" },
                values: new object[] { new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), "", "DealDamage", 2, 150.0, 2 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Discriminator", "Img", "Name", "Skillsort" },
                values: new object[,]
                {
                    { new Guid("85d9908a-f79d-4586-9637-91c9de70983c"), "PassiveSkill", "FearfulAura.jpg", "Fearful Aura", 1 },
                    { new Guid("18ef20f2-b94d-4a3f-b38e-60d247a4c627"), "PassiveSkill", "SharpPaw.jpg", "Sharp Paw", 1 },
                    { new Guid("7e4656e2-1440-46ee-a5e9-2438e359f33b"), "PassiveSkill", "PresenceOfTheDarkLord.jpg", "Presence Of The Dark Lord", 1 },
                    { new Guid("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"), "PassiveSkill", "Orc'sFlesh.jpg", "Orc's Flesh", 1 },
                    { new Guid("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39"), "PassiveSkill", "Marksmanship.jpg", "Marksmanship", 1 },
                    { new Guid("35c69f01-7c39-4324-aa6f-d550676229ad"), "PassiveSkill", "Jinada.jpg", "Jinada", 1 },
                    { new Guid("f50ade16-3b0e-4de4-af15-f268f075dd78"), "PassiveSkill", "HumanMind.jpg", "Human Mind", 1 },
                    { new Guid("dd027abc-a8b9-4d89-b582-41c480c4fb45"), "PassiveSkill", "HealingAttendant.jpg", "Healing Attendant", 1 },
                    { new Guid("69bfd9cd-6c36-4637-8f17-6951cacb1204"), "PassiveSkill", "DemonicAttack.jpg", "Demonic Attack", 1 },
                    { new Guid("36478d6b-ac61-4c5a-af51-c649ff8851d2"), "PassiveSkill", "BladeDance.jpg", "Blade Dance", 1 },
                    { new Guid("87e38d0b-af62-439a-8cfa-febc53ac1b01"), "PassiveSkill", "BonAppetit.jpg", "Bon Appetit", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Discriminator", "Img", "Name", "Skillsort", "Manacost" },
                values: new object[,]
                {
                    { new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98"), "ActiveSkill", "BattleTrance.jpg", "Battle Trance", 0, 3.0 },
                    { new Guid("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf"), "ActiveSkill", "ChainFrost.jpg", "Chain Frost", 0, 5.0 },
                    { new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b"), "ActiveSkill", "ChaosBolt.jpg", "Chaos Bolt", 0, 2.5 },
                    { new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a"), "ActiveSkill", "FearfulSigil.jpg", "Fearful Sigil", 0, 2.5 },
                    { new Guid("c3414818-5b50-4da6-94e4-129339ccc21b"), "ActiveSkill", "FrostArmor.jpg", "Frost Armor", 0, 2.0 },
                    { new Guid("c68ed6dd-0479-47cb-810c-03e897990665"), "ActiveSkill", "Frostbite.jpg", "Frostbite", 0, 3.0 },
                    { new Guid("147c6bc2-4e9b-4afc-b422-e0130252b1e0"), "ActiveSkill", "Nature'sAttendants.jpg", "Nature's Attendants", 0, 3.0 },
                    { new Guid("9572a874-9e78-4f3d-9964-5a25daf101d3"), "ActiveSkill", "Omnislash.jpg", "Omnislash", 0, 4.5 },
                    { new Guid("c03d9352-b51b-4d56-afe4-dfb2a32158a2"), "ActiveSkill", "PrecisionAura.jpg", "Precision Aura", 0, 2.0 },
                    { new Guid("c6be27f6-3217-400f-9427-499d5719a5b6"), "ActiveSkill", "RequiemOfSouls.jpg", "Requiem Of Souls", 0, 5.0 },
                    { new Guid("00f75578-175e-40be-82b3-71e558041981"), "ActiveSkill", "ScreamOfPain.jpg", "Scream Of Pain", 0, 2.5 },
                    { new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd"), "ActiveSkill", "ShadowStrike.jpg", "Shadow Strike", 0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Discriminator", "Img", "Name", "Skillsort" },
                values: new object[] { new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"), "PassiveSkill", "ChaosStrike.jpg", "Chaos Strike", 1 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Discriminator", "Img", "Name", "Skillsort", "Manacost" },
                values: new object[] { new Guid("cc4610f6-4f20-41d1-a529-522636674ff6"), "ActiveSkill", "Enchant.jpg", "Enchant", 0, 2.0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Discriminator", "Img", "Name", "Skillsort" },
                values: new object[,]
                {
                    { new Guid("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"), "PassiveSkill", "BeautifulInside.jpg", "Beautiful Inside", 1 },
                    { new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c"), "PassiveSkill", "BadJuju.jpg", "Bad Juju", 1 },
                    { new Guid("f600f388-352a-4674-a533-1cc1347b7d61"), "PassiveSkill", "ArcaneAura.jpg", "Arcane Aura", 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Discriminator", "Img", "Name", "Skillsort", "Manacost" },
                values: new object[,]
                {
                    { new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85"), "ActiveSkill", "WhirlingAxes.jpg", "Whirling Axes", 0, 2.5 },
                    { new Guid("4db2ba57-6f02-4c95-bf0a-f59af269fd3f"), "ActiveSkill", "WalrusPunch.jpg", "Walrus Punch", 0, 2.0 },
                    { new Guid("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3"), "ActiveSkill", "ShurikenToss.jpg", "Shuriken Toss", 0, 2.5 },
                    { new Guid("6d241033-20da-4d9d-88db-d38551007304"), "ActiveSkill", "ShadowWave.jpg", "Shadow Wave", 0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Targets",
                columns: new[] { "Id", "Discriminator", "HeroTargetType", "TargetType", "AmountOfTargets", "AreaOfEffect" },
                values: new object[,]
                {
                    { new Guid("11c5b5e5-60a7-4093-9c45-d3bb0acdb1df"), "MultipleTarget", 1, 0, 3, 1 },
                    { new Guid("646aa733-f4cf-4392-a339-2a067044d787"), "MultipleTarget", 2, 0, 2, 1 },
                    { new Guid("907b6938-1c4c-45dd-aa5c-c6be1c6965de"), "MultipleTarget", 2, 0, 3, 1 },
                    { new Guid("13d0b53a-c6ad-425c-a8c1-be7ae118e78a"), "MultipleTarget", 2, 0, 99, 99 },
                    { new Guid("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e"), "MultipleTarget", 2, 0, 3, 3 },
                    { new Guid("952d3a54-9c70-4c2b-a657-20d077a62238"), "MultipleTarget", 2, 0, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Targets",
                columns: new[] { "Id", "Discriminator", "HeroTargetType", "TargetType" },
                values: new object[,]
                {
                    { new Guid("375b43ef-65db-4b38-9708-66977db44e87"), "SingleTarget", 0, 1 },
                    { new Guid("636e0bb8-2876-4072-814f-1ab11e732e6c"), "SingleTarget", 1, 1 },
                    { new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9"), "SingleTarget", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Targets",
                columns: new[] { "Id", "Discriminator", "HeroTargetType", "TargetType", "AmountOfTargets", "AreaOfEffect" },
                values: new object[,]
                {
                    { new Guid("a73a283d-a5fd-46cf-a95f-c03b05473295"), "MultipleTarget", 1, 0, 99, 99 },
                    { new Guid("0faafc79-6a2c-4506-b68a-d5c9ce226bdc"), "MultipleTarget", 1, 0, 5, 1 },
                    { new Guid("799d2e51-f05c-4975-8a2b-99ddfeb8d9ca"), "MultipleTarget", 2, 0, 5, 1 },
                    { new Guid("253acb52-d5c6-4cd6-a8f8-974be5b6a91d"), "MultipleTarget", 1, 0, 5, 4 },
                    { new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3"), "MultipleTarget", 1, 0, 3, 3 },
                    { new Guid("7f0c2aa1-42ca-4b97-8371-7e7821a4a745"), "MultipleTarget", 2, 0, 3, 5 },
                    { new Guid("46e167dc-52ad-4fbe-9950-967f55dc19c8"), "MultipleTarget", 1, 0, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "Description", "Discriminator", "EffectType", "AmountToSummon", "SummonUnitId" },
                values: new object[,]
                {
                    { new Guid("15332b71-72f5-45b8-9027-263ce0328067"), "", "Summon", 5, 7, new Guid("dedb8175-0d78-4644-9ec9-eb0a7b8315a4") },
                    { new Guid("826bcba5-228b-4685-b454-5b233e2cd036"), "", "Summon", 5, 1, new Guid("27f53ca1-3a40-4462-961d-d860547d8417") }
                });

            migrationBuilder.InsertData(
                table: "SkillEffects",
                columns: new[] { "SkillId", "EffectId", "TargetId" },
                values: new object[,]
                {
                    { new Guid("c68ed6dd-0479-47cb-810c-03e897990665"), new Guid("b1c4dd1a-d2cc-4f16-842e-c5b99bfcb4bd"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("35c69f01-7c39-4324-aa6f-d550676229ad"), new Guid("d5bd4c65-41a0-4bdc-a155-30d3d343b774"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd"), new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("18ef20f2-b94d-4a3f-b38e-60d247a4c627"), new Guid("aba933fd-0da7-41aa-a4fb-19e9f6a4e86e"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3"), new Guid("3e8534bc-9679-4380-9034-1b9d62d6b8f5"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("4db2ba57-6f02-4c95-bf0a-f59af269fd3f"), new Guid("25b2142f-ad42-4f4c-9c3e-855e465b28a6"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("c3414818-5b50-4da6-94e4-129339ccc21b"), new Guid("b12bbe16-3e81-4500-abb9-625f88e384f5"), new Guid("636e0bb8-2876-4072-814f-1ab11e732e6c") },
                    { new Guid("dd027abc-a8b9-4d89-b582-41c480c4fb45"), new Guid("460be20d-f644-4bc2-9286-7ead03b64e9c"), new Guid("636e0bb8-2876-4072-814f-1ab11e732e6c") },
                    { new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98"), new Guid("a4d29024-307a-4a9b-8fe1-8db09421d73a"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98"), new Guid("1c021dbd-16a9-4146-b810-ff1d36211599"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"), new Guid("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("87e38d0b-af62-439a-8cfa-febc53ac1b01"), new Guid("ec381dc9-c1e5-47fb-8c57-51678224f07f"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("87e38d0b-af62-439a-8cfa-febc53ac1b01"), new Guid("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"), new Guid("ec381dc9-c1e5-47fb-8c57-51678224f07f"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("69bfd9cd-6c36-4637-8f17-6951cacb1204"), new Guid("a4d29024-307a-4a9b-8fe1-8db09421d73a"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("f50ade16-3b0e-4de4-af15-f268f075dd78"), new Guid("874a9cf7-9719-4bbf-8e7f-30b4c77712e4"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"), new Guid("265e0345-f383-4ac8-b33c-a4e20ee05faa"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("c68ed6dd-0479-47cb-810c-03e897990665"), new Guid("0feb5631-dd56-44b2-a207-00ee33551f09"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("cc4610f6-4f20-41d1-a529-522636674ff6"), new Guid("a0c92644-5852-4a0d-884f-f27ca162fa0e"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"), new Guid("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") },
                    { new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b"), new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c"), new Guid("16b9e7ba-239d-4c5b-a337-f3f78fff8065"), new Guid("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e") },
                    { new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"), new Guid("10076a8f-db65-4226-b910-cf6059cbe8d1"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("9572a874-9e78-4f3d-9964-5a25daf101d3"), new Guid("3e8534bc-9679-4380-9034-1b9d62d6b8f5"), new Guid("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e") },
                    { new Guid("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf"), new Guid("915f8f7d-2a9d-4995-ae89-9d6f6e7bb40d"), new Guid("7f0c2aa1-42ca-4b97-8371-7e7821a4a745") },
                    { new Guid("00f75578-175e-40be-82b3-71e558041981"), new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), new Guid("952d3a54-9c70-4c2b-a657-20d077a62238") },
                    { new Guid("85d9908a-f79d-4586-9637-91c9de70983c"), new Guid("ecaee0cf-bafa-4f21-8e6d-2e5fbd3cfe87"), new Guid("799d2e51-f05c-4975-8a2b-99ddfeb8d9ca") },
                    { new Guid("7e4656e2-1440-46ee-a5e9-2438e359f33b"), new Guid("16b9e7ba-239d-4c5b-a337-f3f78fff8065"), new Guid("13d0b53a-c6ad-425c-a8c1-be7ae118e78a") },
                    { new Guid("c6be27f6-3217-400f-9427-499d5719a5b6"), new Guid("80e4330a-1ec5-498d-b3b9-eb74cef24775"), new Guid("13d0b53a-c6ad-425c-a8c1-be7ae118e78a") },
                    { new Guid("f600f388-352a-4674-a533-1cc1347b7d61"), new Guid("03f7e71e-1729-4b24-a192-90c0470d83ed"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") },
                    { new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c"), new Guid("44c83bc1-ecf8-4d19-b2cf-c608dcb4fe6a"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") },
                    { new Guid("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39"), new Guid("64e1a36b-d705-468f-8bfd-58d60d01a9a8"), new Guid("646aa733-f4cf-4392-a339-2a067044d787") },
                    { new Guid("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"), new Guid("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") },
                    { new Guid("6d241033-20da-4d9d-88db-d38551007304"), new Guid("1a78deb7-c5d1-43de-be46-5945153a6aca"), new Guid("253acb52-d5c6-4cd6-a8f8-974be5b6a91d") },
                    { new Guid("f600f388-352a-4674-a533-1cc1347b7d61"), new Guid("eebe8f58-962c-4a81-8d9a-ea9c0b63d9d7"), new Guid("46e167dc-52ad-4fbe-9950-967f55dc19c8") },
                    { new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85"), new Guid("64e1a36b-d705-468f-8bfd-58d60d01a9a8"), new Guid("0faafc79-6a2c-4506-b68a-d5c9ce226bdc") },
                    { new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85"), new Guid("04b17411-2761-465b-84cf-ac0e3589073d"), new Guid("0faafc79-6a2c-4506-b68a-d5c9ce226bdc") },
                    { new Guid("c03d9352-b51b-4d56-afe4-dfb2a32158a2"), new Guid("85c2344e-22d7-42e2-aced-84c35c8eb13c"), new Guid("a73a283d-a5fd-46cf-a95f-c03b05473295") },
                    { new Guid("18ef20f2-b94d-4a3f-b38e-60d247a4c627"), new Guid("783a580c-8153-457c-847f-4e137c7e9b44"), new Guid("a73a283d-a5fd-46cf-a95f-c03b05473295") },
                    { new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b"), new Guid("0feb5631-dd56-44b2-a207-00ee33551f09"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") },
                    { new Guid("f50ade16-3b0e-4de4-af15-f268f075dd78"), new Guid("d818f097-d830-4b3b-aaec-5abc73d5be59"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") },
                    { new Guid("36478d6b-ac61-4c5a-af51-c649ff8851d2"), new Guid("d436f5e5-d729-4d24-be7b-52e235b3bda8"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") }
                });

            migrationBuilder.InsertData(
                table: "SkillSets",
                columns: new[] { "CardUnitId", "SkillId" },
                values: new object[,]
                {
                    { new Guid("27f53ca1-3a40-4462-961d-d860547d8417"), new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a") },
                    { new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"), new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd") },
                    { new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"), new Guid("00f75578-175e-40be-82b3-71e558041981") },
                    { new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"), new Guid("c6be27f6-3217-400f-9427-499d5719a5b6") },
                    { new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"), new Guid("4db2ba57-6f02-4c95-bf0a-f59af269fd3f") },
                    { new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"), new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85") },
                    { new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"), new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98") },
                    { new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"), new Guid("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf") },
                    { new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"), new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a") },
                    { new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"), new Guid("7e4656e2-1440-46ee-a5e9-2438e359f33b") },
                    { new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"), new Guid("c3414818-5b50-4da6-94e4-129339ccc21b") },
                    { new Guid("7129011f-bca0-4449-9629-3a46198267a1"), new Guid("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39") },
                    { new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"), new Guid("36478d6b-ac61-4c5a-af51-c649ff8851d2") },
                    { new Guid("e618edeb-ba86-449a-9602-896adb2db850"), new Guid("cc4610f6-4f20-41d1-a529-522636674ff6") },
                    { new Guid("e618edeb-ba86-449a-9602-896adb2db850"), new Guid("147c6bc2-4e9b-4afc-b422-e0130252b1e0") },
                    { new Guid("7129011f-bca0-4449-9629-3a46198267a1"), new Guid("c03d9352-b51b-4d56-afe4-dfb2a32158a2") },
                    { new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"), new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c") },
                    { new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"), new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd") },
                    { new Guid("f6620430-3d02-4bae-9802-066434d03668"), new Guid("c68ed6dd-0479-47cb-810c-03e897990665") },
                    { new Guid("f6620430-3d02-4bae-9802-066434d03668"), new Guid("f600f388-352a-4674-a533-1cc1347b7d61") },
                    { new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"), new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b") },
                    { new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"), new Guid("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3") },
                    { new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"), new Guid("dd027abc-a8b9-4d89-b582-41c480c4fb45") },
                    { new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"), new Guid("9572a874-9e78-4f3d-9964-5a25daf101d3") },
                    { new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"), new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b") }
                });

            migrationBuilder.InsertData(
                table: "SkillEffects",
                columns: new[] { "SkillId", "EffectId", "TargetId" },
                values: new object[] { new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a"), new Guid("826bcba5-228b-4685-b454-5b233e2cd036"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.InsertData(
                table: "SkillEffects",
                columns: new[] { "SkillId", "EffectId", "TargetId" },
                values: new object[] { new Guid("147c6bc2-4e9b-4afc-b422-e0130252b1e0"), new Guid("15332b71-72f5-45b8-9027-263ce0328067"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.CreateIndex(
                name: "IX_SkillEffects_TargetId",
                table: "SkillEffects",
                column: "TargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillEffects",
                table: "SkillEffects");

            migrationBuilder.DropIndex(
                name: "IX_SkillEffects_TargetId",
                table: "SkillEffects");

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("0079b4f4-a17b-4326-ba40-f2e9753f0b23"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("715f2754-f78d-441f-9b94-4bc0946b1e67"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("df2f81c9-54cc-4ddf-ae55-eb59a664aa30"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("efbbfc8a-6bd7-46a8-8587-455005778bb4"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("f7f13521-0089-4759-9873-ebe96c46b4ca"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("b5c330f2-23b4-4bf2-9481-55099367269c"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("1dacb3a7-21f4-4439-b23d-c1e693084ee4"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("e5af0d52-5663-44f2-b537-dace6d117229"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("2d81259f-a7eb-4fa8-bfdb-613f93e6a9a4"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("55301e2e-9fb6-42cb-9973-498dc910fab1"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("72ef6e9f-23a9-41c5-817d-3ba44b6ffc5f"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("16bde603-b191-4d96-a7fd-f5fb4609e357"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("3fff91e9-8452-488f-bd23-26d3d308ab14"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("6634567a-136f-4c81-af40-7b08aba8e5f4"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("8ed07187-66df-4d46-b1a0-1bdeb8dbacc8"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("9faee829-0506-4e85-9892-decee6915dba"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("b0c0f122-5310-4e9d-b809-c5727a6a11b0"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("fddacf94-fb30-4476-be90-6c9ecd14c9c2"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("0025b00d-bbae-47ea-9d0d-e47f5c72ff3d"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("c650314d-e527-43ce-9932-5a6b01e7e309"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("f44a84c3-c6eb-42ec-9bb7-c69d9b6abdc0"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("4c7c8b0a-5409-41f9-a97d-00f3c7abc45b"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("f7a3978f-30de-4d76-b087-e5146c788b6b"));

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("00f75578-175e-40be-82b3-71e558041981"), new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), new Guid("952d3a54-9c70-4c2b-a657-20d077a62238") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("147c6bc2-4e9b-4afc-b422-e0130252b1e0"), new Guid("15332b71-72f5-45b8-9027-263ce0328067"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("18ef20f2-b94d-4a3f-b38e-60d247a4c627"), new Guid("783a580c-8153-457c-847f-4e137c7e9b44"), new Guid("a73a283d-a5fd-46cf-a95f-c03b05473295") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("18ef20f2-b94d-4a3f-b38e-60d247a4c627"), new Guid("aba933fd-0da7-41aa-a4fb-19e9f6a4e86e"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"), new Guid("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"), new Guid("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("35c69f01-7c39-4324-aa6f-d550676229ad"), new Guid("d5bd4c65-41a0-4bdc-a155-30d3d343b774"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("36478d6b-ac61-4c5a-af51-c649ff8851d2"), new Guid("d436f5e5-d729-4d24-be7b-52e235b3bda8"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85"), new Guid("04b17411-2761-465b-84cf-ac0e3589073d"), new Guid("0faafc79-6a2c-4506-b68a-d5c9ce226bdc") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85"), new Guid("64e1a36b-d705-468f-8bfd-58d60d01a9a8"), new Guid("0faafc79-6a2c-4506-b68a-d5c9ce226bdc") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("4db2ba57-6f02-4c95-bf0a-f59af269fd3f"), new Guid("25b2142f-ad42-4f4c-9c3e-855e465b28a6"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98"), new Guid("1c021dbd-16a9-4146-b810-ff1d36211599"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98"), new Guid("a4d29024-307a-4a9b-8fe1-8db09421d73a"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b"), new Guid("0feb5631-dd56-44b2-a207-00ee33551f09"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b"), new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("69bfd9cd-6c36-4637-8f17-6951cacb1204"), new Guid("a4d29024-307a-4a9b-8fe1-8db09421d73a"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c"), new Guid("16b9e7ba-239d-4c5b-a337-f3f78fff8065"), new Guid("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c"), new Guid("44c83bc1-ecf8-4d19-b2cf-c608dcb4fe6a"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("6d241033-20da-4d9d-88db-d38551007304"), new Guid("1a78deb7-c5d1-43de-be46-5945153a6aca"), new Guid("253acb52-d5c6-4cd6-a8f8-974be5b6a91d") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("7e4656e2-1440-46ee-a5e9-2438e359f33b"), new Guid("16b9e7ba-239d-4c5b-a337-f3f78fff8065"), new Guid("13d0b53a-c6ad-425c-a8c1-be7ae118e78a") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39"), new Guid("64e1a36b-d705-468f-8bfd-58d60d01a9a8"), new Guid("646aa733-f4cf-4392-a339-2a067044d787") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("85d9908a-f79d-4586-9637-91c9de70983c"), new Guid("ecaee0cf-bafa-4f21-8e6d-2e5fbd3cfe87"), new Guid("799d2e51-f05c-4975-8a2b-99ddfeb8d9ca") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("87e38d0b-af62-439a-8cfa-febc53ac1b01"), new Guid("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("87e38d0b-af62-439a-8cfa-febc53ac1b01"), new Guid("ec381dc9-c1e5-47fb-8c57-51678224f07f"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a"), new Guid("826bcba5-228b-4685-b454-5b233e2cd036"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("9572a874-9e78-4f3d-9964-5a25daf101d3"), new Guid("3e8534bc-9679-4380-9034-1b9d62d6b8f5"), new Guid("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"), new Guid("10076a8f-db65-4226-b910-cf6059cbe8d1"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"), new Guid("ec381dc9-c1e5-47fb-8c57-51678224f07f"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf"), new Guid("915f8f7d-2a9d-4995-ae89-9d6f6e7bb40d"), new Guid("7f0c2aa1-42ca-4b97-8371-7e7821a4a745") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("c03d9352-b51b-4d56-afe4-dfb2a32158a2"), new Guid("85c2344e-22d7-42e2-aced-84c35c8eb13c"), new Guid("a73a283d-a5fd-46cf-a95f-c03b05473295") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("c3414818-5b50-4da6-94e4-129339ccc21b"), new Guid("b12bbe16-3e81-4500-abb9-625f88e384f5"), new Guid("636e0bb8-2876-4072-814f-1ab11e732e6c") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("c68ed6dd-0479-47cb-810c-03e897990665"), new Guid("0feb5631-dd56-44b2-a207-00ee33551f09"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("c68ed6dd-0479-47cb-810c-03e897990665"), new Guid("b1c4dd1a-d2cc-4f16-842e-c5b99bfcb4bd"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("c6be27f6-3217-400f-9427-499d5719a5b6"), new Guid("80e4330a-1ec5-498d-b3b9-eb74cef24775"), new Guid("13d0b53a-c6ad-425c-a8c1-be7ae118e78a") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("cc4610f6-4f20-41d1-a529-522636674ff6"), new Guid("a0c92644-5852-4a0d-884f-f27ca162fa0e"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("dd027abc-a8b9-4d89-b582-41c480c4fb45"), new Guid("460be20d-f644-4bc2-9286-7ead03b64e9c"), new Guid("636e0bb8-2876-4072-814f-1ab11e732e6c") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3"), new Guid("3e8534bc-9679-4380-9034-1b9d62d6b8f5"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd"), new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"), new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("f50ade16-3b0e-4de4-af15-f268f075dd78"), new Guid("874a9cf7-9719-4bbf-8e7f-30b4c77712e4"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("f50ade16-3b0e-4de4-af15-f268f075dd78"), new Guid("d818f097-d830-4b3b-aaec-5abc73d5be59"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("f600f388-352a-4674-a533-1cc1347b7d61"), new Guid("03f7e71e-1729-4b24-a192-90c0470d83ed"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("f600f388-352a-4674-a533-1cc1347b7d61"), new Guid("eebe8f58-962c-4a81-8d9a-ea9c0b63d9d7"), new Guid("46e167dc-52ad-4fbe-9950-967f55dc19c8") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"), new Guid("265e0345-f383-4ac8-b33c-a4e20ee05faa"), new Guid("375b43ef-65db-4b38-9708-66977db44e87") });

            migrationBuilder.DeleteData(
                table: "SkillEffects",
                keyColumns: new[] { "SkillId", "EffectId", "TargetId" },
                keyValues: new object[] { new Guid("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"), new Guid("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"), new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"), new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"), new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("27f53ca1-3a40-4462-961d-d860547d8417"), new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"), new Guid("36478d6b-ac61-4c5a-af51-c649ff8851d2") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"), new Guid("9572a874-9e78-4f3d-9964-5a25daf101d3") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"), new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"), new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"), new Guid("dd027abc-a8b9-4d89-b582-41c480c4fb45") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"), new Guid("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("7129011f-bca0-4449-9629-3a46198267a1"), new Guid("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("7129011f-bca0-4449-9629-3a46198267a1"), new Guid("c03d9352-b51b-4d56-afe4-dfb2a32158a2") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"), new Guid("4db2ba57-6f02-4c95-bf0a-f59af269fd3f") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"), new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"), new Guid("00f75578-175e-40be-82b3-71e558041981") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"), new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"), new Guid("7e4656e2-1440-46ee-a5e9-2438e359f33b") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"), new Guid("c6be27f6-3217-400f-9427-499d5719a5b6") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"), new Guid("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"), new Guid("c3414818-5b50-4da6-94e4-129339ccc21b") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("e618edeb-ba86-449a-9602-896adb2db850"), new Guid("147c6bc2-4e9b-4afc-b422-e0130252b1e0") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("e618edeb-ba86-449a-9602-896adb2db850"), new Guid("cc4610f6-4f20-41d1-a529-522636674ff6") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("f6620430-3d02-4bae-9802-066434d03668"), new Guid("c68ed6dd-0479-47cb-810c-03e897990665") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("f6620430-3d02-4bae-9802-066434d03668"), new Guid("f600f388-352a-4674-a533-1cc1347b7d61") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"), new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85") });

            migrationBuilder.DeleteData(
                table: "SkillSets",
                keyColumns: new[] { "CardUnitId", "SkillId" },
                keyValues: new object[] { new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"), new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98") });

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("11c5b5e5-60a7-4093-9c45-d3bb0acdb1df"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("907b6938-1c4c-45dd-aa5c-c6be1c6965de"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("038a0497-bf84-45cd-8fcc-22fd78bcafe1"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("484c6ca0-42c8-42ec-80ed-c919ef6f186c"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("66e9be55-ffef-438a-9203-64a7a3062af7"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("7129011f-bca0-4449-9629-3a46198267a1"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("9cae91c6-5213-4447-a4b3-458c2e4dd944"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("b3c06915-0178-42de-a9bb-4369a41acfac"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("deb26782-8dd4-4d8e-9016-1202138b7b59"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("e618edeb-ba86-449a-9602-896adb2db850"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("f6620430-3d02-4bae-9802-066434d03668"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("03f7e71e-1729-4b24-a192-90c0470d83ed"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("265e0345-f383-4ac8-b33c-a4e20ee05faa"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("44c83bc1-ecf8-4d19-b2cf-c608dcb4fe6a"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("783a580c-8153-457c-847f-4e137c7e9b44"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("85c2344e-22d7-42e2-aced-84c35c8eb13c"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("874a9cf7-9719-4bbf-8e7f-30b4c77712e4"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("a4d29024-307a-4a9b-8fe1-8db09421d73a"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("b12bbe16-3e81-4500-abb9-625f88e384f5"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("d818f097-d830-4b3b-aaec-5abc73d5be59"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("eebe8f58-962c-4a81-8d9a-ea9c0b63d9d7"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("10076a8f-db65-4226-b910-cf6059cbe8d1"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("25b2142f-ad42-4f4c-9c3e-855e465b28a6"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("aba933fd-0da7-41aa-a4fb-19e9f6a4e86e"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("d436f5e5-d729-4d24-be7b-52e235b3bda8"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("d5bd4c65-41a0-4bdc-a155-30d3d343b774"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("3e8534bc-9679-4380-9034-1b9d62d6b8f5"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("64e1a36b-d705-468f-8bfd-58d60d01a9a8"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("80e4330a-1ec5-498d-b3b9-eb74cef24775"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("915f8f7d-2a9d-4995-ae89-9d6f6e7bb40d"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("b1c4dd1a-d2cc-4f16-842e-c5b99bfcb4bd"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("1a78deb7-c5d1-43de-be46-5945153a6aca"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("460be20d-f644-4bc2-9286-7ead03b64e9c"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("1c021dbd-16a9-4146-b810-ff1d36211599"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("ec381dc9-c1e5-47fb-8c57-51678224f07f"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("04b17411-2761-465b-84cf-ac0e3589073d"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("16b9e7ba-239d-4c5b-a337-f3f78fff8065"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("ecaee0cf-bafa-4f21-8e6d-2e5fbd3cfe87"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("0feb5631-dd56-44b2-a207-00ee33551f09"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("a0c92644-5852-4a0d-884f-f27ca162fa0e"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("15332b71-72f5-45b8-9027-263ce0328067"));

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: new Guid("826bcba5-228b-4685-b454-5b233e2cd036"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("00f75578-175e-40be-82b3-71e558041981"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("147c6bc2-4e9b-4afc-b422-e0130252b1e0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3a1a8de1-43b7-4dbe-861d-9c635e83df85"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4db2ba57-6f02-4c95-bf0a-f59af269fd3f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("50fe62bf-979a-4ee7-9f12-b5313e00de98"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("62ea4143-f6f3-4390-ac72-3e23561ed06b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6d241033-20da-4d9d-88db-d38551007304"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("8fb27632-30c5-4e4b-9925-c3594fe55c5a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9572a874-9e78-4f3d-9964-5a25daf101d3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c03d9352-b51b-4d56-afe4-dfb2a32158a2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c3414818-5b50-4da6-94e4-129339ccc21b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c68ed6dd-0479-47cb-810c-03e897990665"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c6be27f6-3217-400f-9427-499d5719a5b6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cc4610f6-4f20-41d1-a529-522636674ff6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eb1d8e33-1cad-4f14-98c3-72938bad25fd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("18ef20f2-b94d-4a3f-b38e-60d247a4c627"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("35c69f01-7c39-4324-aa6f-d550676229ad"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("36478d6b-ac61-4c5a-af51-c649ff8851d2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("69bfd9cd-6c36-4637-8f17-6951cacb1204"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6ac2049f-151e-40bb-899e-0e836e0b6f5c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7e4656e2-1440-46ee-a5e9-2438e359f33b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("85d9908a-f79d-4586-9637-91c9de70983c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("87e38d0b-af62-439a-8cfa-febc53ac1b01"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("dd027abc-a8b9-4d89-b582-41c480c4fb45"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f50ade16-3b0e-4de4-af15-f268f075dd78"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f600f388-352a-4674-a533-1cc1347b7d61"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("08bf6141-fb84-47d1-a8e1-99b227c67ed3"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("0faafc79-6a2c-4506-b68a-d5c9ce226bdc"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("13d0b53a-c6ad-425c-a8c1-be7ae118e78a"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("253acb52-d5c6-4cd6-a8f8-974be5b6a91d"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("46e167dc-52ad-4fbe-9950-967f55dc19c8"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("646aa733-f4cf-4392-a339-2a067044d787"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("799d2e51-f05c-4975-8a2b-99ddfeb8d9ca"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("7f0c2aa1-42ca-4b97-8371-7e7821a4a745"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("952d3a54-9c70-4c2b-a657-20d077a62238"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("a73a283d-a5fd-46cf-a95f-c03b05473295"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("375b43ef-65db-4b38-9708-66977db44e87"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("636e0bb8-2876-4072-814f-1ab11e732e6c"));

            migrationBuilder.DeleteData(
                table: "Targets",
                keyColumn: "Id",
                keyValue: new Guid("e21f9012-3037-4385-b0af-2d2eec3245b9"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("27f53ca1-3a40-4462-961d-d860547d8417"));

            migrationBuilder.DeleteData(
                table: "CardUnits",
                keyColumn: "Id",
                keyValue: new Guid("dedb8175-0d78-4644-9ec9-eb0a7b8315a4"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillEffects",
                table: "SkillEffects",
                columns: new[] { "SkillId", "EffectId" });

            migrationBuilder.CreateIndex(
                name: "IX_SkillEffects_TargetId",
                table: "SkillEffects",
                column: "TargetId",
                unique: true);
        }
    }
}
