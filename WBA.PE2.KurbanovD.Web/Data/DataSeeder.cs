using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Repositories;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Base.Effects;
using WBA.PE2.KurbanovD.Domain.Base.Skills;
using WBA.PE2.KurbanovD.Domain.Base.Targets;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Services;

namespace WBA.PE2.KurbanovD.Web.Data
{
    public class DataSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            #region ActiveSkill
            modelBuilder.Entity<ActiveSkill>().HasData(
                //ActiveSkill Battle Trance
                new ActiveSkill
                {
                    Id = Guid.Parse("50fe62bf-979a-4ee7-9f12-b5313e00de98"),
                    Img = "BattleTrance.jpg",
                    Name = "Battle Trance",
                    Skillsort = SkillSort.Active,
                    Manacost = 3D
                },
                //ActiveSkill Chain Frost
                new ActiveSkill
                {
                    Id = Guid.Parse("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf"),
                    Img = "ChainFrost.jpg",
                    Name = "Chain Frost",
                    Skillsort = SkillSort.Active,
                    Manacost = 5D
                },
                //ActiveSkill Chaos Bolt
                new ActiveSkill
                {
                    Id = Guid.Parse("62ea4143-f6f3-4390-ac72-3e23561ed06b"),
                    Img = "ChaosBolt.jpg",
                    Name = "Chaos Bolt",
                    Skillsort = SkillSort.Active,
                    Manacost = 2.5D
                },
                //ActiveSkill Enchant
                new ActiveSkill
                {
                    Id = Guid.Parse("cc4610f6-4f20-41d1-a529-522636674ff6"),
                    Img = "Enchant.jpg",
                    Name = "Enchant",
                    Skillsort = SkillSort.Active,
                    Manacost = 2D
                },
                //ActiveSkill Fearful Sigil
                new ActiveSkill
                {
                    Id = Guid.Parse("8fb27632-30c5-4e4b-9925-c3594fe55c5a"),
                    Img = "FearfulSigil.jpg",
                    Name = "Fearful Sigil",
                    Skillsort = SkillSort.Active,
                    Manacost = 2.5D
                },
                //ActiveSkill Frost Armor
                new ActiveSkill
                {
                    Id = Guid.Parse("c3414818-5b50-4da6-94e4-129339ccc21b"),
                    Img = "FrostArmor.jpg",
                    Name = "Frost Armor",
                    Skillsort = SkillSort.Active,
                    Manacost = 2D
                },
                //ActiveSkill Frostbite 
                new ActiveSkill
                {
                    Id = Guid.Parse("c68ed6dd-0479-47cb-810c-03e897990665"),
                    Img = "Frostbite.jpg",
                    Name = "Frostbite",
                    Skillsort = SkillSort.Active,
                    Manacost = 3D
                },
                //ActiveSkill Nature's Attendants
                new ActiveSkill
                {
                    Id = Guid.Parse("147c6bc2-4e9b-4afc-b422-e0130252b1e0"),
                    Img = "Nature'sAttendants.jpg",
                    Name = "Nature's Attendants",
                    Skillsort = SkillSort.Active,
                    Manacost = 3D
                },
                //ActiveSkill Omnislash
                new ActiveSkill
                {
                    Id = Guid.Parse("9572a874-9e78-4f3d-9964-5a25daf101d3"),
                    Img = "Omnislash.jpg",
                    Name = "Omnislash",
                    Skillsort = SkillSort.Active,
                    Manacost = 4.5D
                },
                //ActiveSkill Precision Aura
                new ActiveSkill
                {
                    Id = Guid.Parse("c03d9352-b51b-4d56-afe4-dfb2a32158a2"),
                    Img = "PrecisionAura.jpg",
                    Name = "Precision Aura",
                    Skillsort = SkillSort.Active,
                    Manacost = 2D
                },
                //ActiveSkill Requiem Of Souls
                new ActiveSkill
                {
                    Id = Guid.Parse("c6be27f6-3217-400f-9427-499d5719a5b6"),
                    Img = "RequiemOfSouls.jpg",
                    Name = "Requiem Of Souls",
                    Skillsort = SkillSort.Active,
                    Manacost = 5D
                },
                //ActiveSkill Scream Of Pain
                new ActiveSkill
                {
                    Id = Guid.Parse("00f75578-175e-40be-82b3-71e558041981"),
                    Img = "ScreamOfPain.jpg",
                    Name = "Scream Of Pain",
                    Skillsort = SkillSort.Active,
                    Manacost = 2.5D
                },
                //ActiveSkill Shadow Strike
                new ActiveSkill
                {
                    Id = Guid.Parse("eb1d8e33-1cad-4f14-98c3-72938bad25fd"),
                    Img = "ShadowStrike.jpg",
                    Name = "Shadow Strike",
                    Skillsort = SkillSort.Active,
                    Manacost = 1.5D
                },
                //ActiveSkill Shadow Wave
                new ActiveSkill
                {
                    Id = Guid.Parse("6d241033-20da-4d9d-88db-d38551007304"),
                    Img = "ShadowWave.jpg",
                    Name = "Shadow Wave",
                    Skillsort = SkillSort.Active,
                    Manacost = 3.5D
                },
                //ActiveSkill Shuriken Toss
                new ActiveSkill
                {
                    Id = Guid.Parse("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3"),
                    Img = "ShurikenToss.jpg",
                    Name = "Shuriken Toss",
                    Skillsort = SkillSort.Active,
                    Manacost = 2.5D
                },
                //ActiveSkill Walrus Punch
                new ActiveSkill
                {
                    Id = Guid.Parse("4db2ba57-6f02-4c95-bf0a-f59af269fd3f"),
                    Img = "WalrusPunch.jpg",
                    Name = "Walrus Punch",
                    Skillsort = SkillSort.Active,
                    Manacost = 2D
                },
                //Active Skill Whirling Axes
                new ActiveSkill
                {
                    Id = Guid.Parse("3a1a8de1-43b7-4dbe-861d-9c635e83df85"),
                    Img = "WhirlingAxes.jpg",
                    Name = "Whirling Axes",
                    Skillsort = SkillSort.Active,
                    Manacost = 2.5D
                }
                );
            #endregion

            #region Amplify
            modelBuilder.Entity<Amplify>().HasData(
                //Amplify Armor 5
                new Amplify
                {
                    Id = Guid.Parse("44c83bc1-ecf8-4d19-b2cf-c608dcb4fe6a"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 5D,
                    AmplifyType = AmplifyType.Armor,
                    EffectState = EffectState.Buff
                },
                //Amplify 1 Armor 10
                new Amplify
                {
                    Id = Guid.Parse("b12bbe16-3e81-4500-abb9-625f88e384f5"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 10D,
                    AmplifyType = AmplifyType.Armor,
                    EffectState = EffectState.Buff
                },
                //Amplify 2 Armor 20
                new Amplify
                {
                    Id = Guid.Parse("265e0345-f383-4ac8-b33c-a4e20ee05faa"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 20D,
                    AmplifyType = AmplifyType.Armor,
                    EffectState = EffectState.Buff
                },
                //Amplify Damage 15
                new Amplify
                {
                    Id = Guid.Parse("85c2344e-22d7-42e2-aced-84c35c8eb13c"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 15D,
                    AmplifyType = AmplifyType.Damage,
                    EffectState = EffectState.Buff
                },
                //Amplify Damage 25
                new Amplify
                {
                    Id = Guid.Parse("783a580c-8153-457c-847f-4e137c7e9b44"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 25D,
                    AmplifyType = AmplifyType.Damage,
                    EffectState = EffectState.Buff
                },
                //Amplify 3 Damage 50
                new Amplify
                {
                    Id = Guid.Parse("a4d29024-307a-4a9b-8fe1-8db09421d73a"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 50D,
                    AmplifyType = AmplifyType.Damage,
                    EffectState = EffectState.Buff
                },
                //Amplify 4 Damage 100
                new Amplify
                {
                    Id = Guid.Parse("715f2754-f78d-441f-9b94-4bc0946b1e67"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 100D,
                    AmplifyType = AmplifyType.Damage,
                    EffectState = EffectState.Buff
                },
                //Amplify 5 Health 250
                new Amplify
                {
                    Id = Guid.Parse("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 250D,
                    AmplifyType = AmplifyType.Health,
                    EffectState = EffectState.Buff
                },
                //Amplify 6 Health 500
                new Amplify
                {
                    Id = Guid.Parse("0079b4f4-a17b-4326-ba40-f2e9753f0b23"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 500D,
                    AmplifyType = AmplifyType.Health,
                    EffectState = EffectState.Buff
                },
                //Amplify Health Regeneration 25
                new Amplify
                {
                    Id = Guid.Parse("874a9cf7-9719-4bbf-8e7f-30b4c77712e4"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 25D,
                    AmplifyType = AmplifyType.HealthRegen,
                    EffectState = EffectState.Buff
                },
                //Amplify 7 HealthRegen 50
                new Amplify
                {
                    Id = Guid.Parse("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 50D,
                    AmplifyType = AmplifyType.HealthRegen,
                    EffectState = EffectState.Buff
                },
                //Amplify 8 HealthRegen 100
                new Amplify
                {
                    Id = Guid.Parse("f7f13521-0089-4759-9873-ebe96c46b4ca"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 100D,
                    AmplifyType = AmplifyType.HealthRegen,
                    EffectState = EffectState.Buff
                },
                //Amplify 9 Mana 5
                new Amplify
                {
                    Id = Guid.Parse("03f7e71e-1729-4b24-a192-90c0470d83ed"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 5D,
                    AmplifyType = AmplifyType.Mana,
                    EffectState = EffectState.Buff
                },
                //Amplify 10 Mana 10
                new Amplify
                {
                    Id = Guid.Parse("df2f81c9-54cc-4ddf-ae55-eb59a664aa30"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 10D,
                    AmplifyType = AmplifyType.Mana,
                    EffectState = EffectState.Buff
                },
                //Amplify Mana Regeneration 1
                new Amplify
                {
                    Id = Guid.Parse("d818f097-d830-4b3b-aaec-5abc73d5be59"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 1D,
                    AmplifyType = AmplifyType.ManaRegen,
                    EffectState = EffectState.Buff
                },
                //Amplify 11 ManaRegen 1.5
                new Amplify
                {
                    Id = Guid.Parse("eebe8f58-962c-4a81-8d9a-ea9c0b63d9d7"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 1.5D,
                    AmplifyType = AmplifyType.ManaRegen,
                    EffectState = EffectState.Buff
                },
                //Amplify 12 ManaRegen 3
                new Amplify
                {
                    Id = Guid.Parse("efbbfc8a-6bd7-46a8-8587-455005778bb4"),
                    Description = "",
                    EffectType = EffectType.Amplify,
                    Amount = 3D,
                    AmplifyType = AmplifyType.ManaRegen,
                    EffectState = EffectState.Buff
                }

                );
            #endregion

            #region CardUnitSkills
            modelBuilder.Entity<CardUnitSkills>().HasData(
                //Bounty Hunter || Jinada
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"),
                    SkillId = Guid.Parse("35c69f01-7c39-4324-aa6f-d550676229ad")
                },
                //Bounty Hunter || Shuriken Toss
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"),
                    SkillId = Guid.Parse("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3")
                },
                //Chaos Knight || Chaos Bolt
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("038a0497-bf84-45cd-8fcc-22fd78bcafe1"),
                    SkillId = Guid.Parse("62ea4143-f6f3-4390-ac72-3e23561ed06b")
                },
                //Chaos Knight || Chaos Strike
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("038a0497-bf84-45cd-8fcc-22fd78bcafe1"),
                    SkillId = Guid.Parse("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b")
                },
                //Crystal Maiden || Arcane Aura
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("f6620430-3d02-4bae-9802-066434d03668"),
                    SkillId = Guid.Parse("f600f388-352a-4674-a533-1cc1347b7d61")
                },
                //Crystal Maiden || Frostbite
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("f6620430-3d02-4bae-9802-066434d03668"),
                    SkillId = Guid.Parse("c68ed6dd-0479-47cb-810c-03e897990665")
                },
                //Dazzle || Shadow Wave
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("66e9be55-ffef-438a-9203-64a7a3062af7"),
                    SkillId = Guid.Parse("6d241033-20da-4d9d-88db-d38551007304")
                },
                //Dazzle || Bad Juju
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("66e9be55-ffef-438a-9203-64a7a3062af7"),
                    SkillId = Guid.Parse("6ac2049f-151e-40bb-899e-0e836e0b6f5c")
                },
                //Drow Ranger || Precision Aura
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("7129011f-bca0-4449-9629-3a46198267a1"),
                    SkillId = Guid.Parse("c03d9352-b51b-4d56-afe4-dfb2a32158a2")
                },
                //Drow Ranger || Marksmanship
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("7129011f-bca0-4449-9629-3a46198267a1"),
                    SkillId = Guid.Parse("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39")
                },
                //Enchantress || Nature's Attendants
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("e618edeb-ba86-449a-9602-896adb2db850"),
                    SkillId = Guid.Parse("147c6bc2-4e9b-4afc-b422-e0130252b1e0")
                },
                //Enchantress || Enchant
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("e618edeb-ba86-449a-9602-896adb2db850"),
                    SkillId = Guid.Parse("cc4610f6-4f20-41d1-a529-522636674ff6")
                },
                //Fearful Sigil || Fearful Aura
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("27f53ca1-3a40-4462-961d-d860547d8417"),
                    SkillId = Guid.Parse("8fb27632-30c5-4e4b-9925-c3594fe55c5a")
                },
                //Juggernaut || Blade Dance
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("484c6ca0-42c8-42ec-80ed-c919ef6f186c"),
                    SkillId = Guid.Parse("36478d6b-ac61-4c5a-af51-c649ff8851d2")
                },
                //Juggernaut || Omnislash
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("484c6ca0-42c8-42ec-80ed-c919ef6f186c"),
                    SkillId = Guid.Parse("9572a874-9e78-4f3d-9964-5a25daf101d3")
                },
                //Lich || Frost Armor
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("deb26782-8dd4-4d8e-9016-1202138b7b59"),
                    SkillId = Guid.Parse("c3414818-5b50-4da6-94e4-129339ccc21b")
                },
                // Lich || Chain Frost
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("deb26782-8dd4-4d8e-9016-1202138b7b59"),
                    SkillId = Guid.Parse("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf")
                },
                //Queen Of Pain || Shadow Strike
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("b3c06915-0178-42de-a9bb-4369a41acfac"),
                    SkillId = Guid.Parse("eb1d8e33-1cad-4f14-98c3-72938bad25fd")
                },
                //Queen Of Pain || Scream Of Pain
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("b3c06915-0178-42de-a9bb-4369a41acfac"),
                    SkillId = Guid.Parse("00f75578-175e-40be-82b3-71e558041981")
                },
                //Shadow Fiend || Requiem Of Souls
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"),
                    SkillId = Guid.Parse("c6be27f6-3217-400f-9427-499d5719a5b6")
                },
                //Shadow Fiend || Presence Of The Dark Lord
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"),
                    SkillId = Guid.Parse("7e4656e2-1440-46ee-a5e9-2438e359f33b")
                },
                //Troll Warlord || Whirling Axes
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"),
                    SkillId = Guid.Parse("3a1a8de1-43b7-4dbe-861d-9c635e83df85")
                },
                //Troll Warlord || Battle Trance
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"),
                    SkillId = Guid.Parse("50fe62bf-979a-4ee7-9f12-b5313e00de98")
                },
                //Tusk || Walrus Punch
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("9cae91c6-5213-4447-a4b3-458c2e4dd944"),
                    SkillId = Guid.Parse("4db2ba57-6f02-4c95-bf0a-f59af269fd3f")
                },
                //Tusk || Fearful Sigil
                new CardUnitSkills
                {
                    CardUnitId = Guid.Parse("9cae91c6-5213-4447-a4b3-458c2e4dd944"),
                    SkillId = Guid.Parse("8fb27632-30c5-4e4b-9925-c3594fe55c5a")
                }
                );
            #endregion

            #region CriticalHit
            modelBuilder.Entity<CriticalHit>().HasData(
                //Critical hit 20% 2x Physical
                new CriticalHit
                {
                    Id = Guid.Parse("aba933fd-0da7-41aa-a4fb-19e9f6a4e86e"),
                    Description = "",
                    EffectType = EffectType.CriticalHit,
                    CriticalMultiplier = 2D,
                    CriticalProcChance = 0.2D,
                    DamageType = DamageType.Physical
                },
                //Critical hit 20% 4x Physical
                new CriticalHit
                {
                    Id = Guid.Parse("b5c330f2-23b4-4bf2-9481-55099367269c"),
                    Description = "",
                    EffectType = EffectType.CriticalHit,
                    CriticalMultiplier = 4D,
                    CriticalProcChance = 0.2D,
                    DamageType = DamageType.Physical
                },
                //Critical hit 20% 4x Pure
                new CriticalHit
                {
                    Id = Guid.Parse("10076a8f-db65-4226-b910-cf6059cbe8d1"),
                    Description = "",
                    EffectType = EffectType.CriticalHit,
                    CriticalMultiplier = 4D,
                    CriticalProcChance = 0.2D,
                    DamageType = DamageType.Pure
                },
                //Critical hit 25% 2.5x Physical
                new CriticalHit
                {
                    Id = Guid.Parse("d5bd4c65-41a0-4bdc-a155-30d3d343b774"),
                    Description = "",
                    EffectType = EffectType.CriticalHit,
                    CriticalMultiplier = 2.5D,
                    CriticalProcChance = 0.25D,
                    DamageType = DamageType.Physical
                },
                //Critical hit 30%Chance 2x Physical
                new CriticalHit
                {
                    Id = Guid.Parse("d436f5e5-d729-4d24-be7b-52e235b3bda8"),
                    Description = "",
                    EffectType = EffectType.CriticalHit,
                    CriticalMultiplier = 2D,
                    CriticalProcChance = 0.3D,
                    DamageType = DamageType.Physical
                },
                //Critical hit 100% 2.5x Physical
                new CriticalHit
                {
                    Id = Guid.Parse("25b2142f-ad42-4f4c-9c3e-855e465b28a6"),
                    Description = "",
                    EffectType = EffectType.CriticalHit,
                    CriticalMultiplier = 2.5D,
                    CriticalProcChance = 1D,
                    DamageType = DamageType.Physical
                }
                );
            #endregion

            #region Heroes
            modelBuilder.Entity<Hero>().HasData(
                //Hero Bounty Hunter
                new Hero
                {
                    Id = Guid.Parse("6f68fcfd-7cd6-4410-bc35-b7d96aa23969"),
                    Img = "BountyHunter.jpg",
                    Name = "Bounty Hunter",
                    Mana = 3D,
                    Manaregen = 0.5D,
                    Health = 300D,
                    Damage = 95D,
                    DamageType = DamageType.Physical,
                    Armor = 5D,
                    HealthRegen = 25D,
                    Description = "When the hunted tell tales of Gondar the Bounty Hunter, none are sure of which are true. In whispered tones they say he was abandoned as a kit, learning his skill in tracking as a matter of simple survival. Others hear he was an orphan of war, taken in by the great Soruq the Hunter to learn the master's skill with a blade as they plumbed the dark forests for big game. Still others believe he was a lowly street urchin raised among a guild of cutpurses and thieves, trained in the arts of stealth and misdirection. Around campfires in the wild countryside his quarry speaks the rumors of Gondar's work, growing ever more fearful: they say it was he who tracked down the tyrant King Goff years after the mad regent went into hiding, delivering his head and scepter as proof. That it was he who infiltrated the rebel camps at Highseat, finally bringing the legendary thief White Cape to be judged for his crimes. And that it was he who ended the career of Soruq the Hunter, condemned as a criminal for killing the Prince's prized hellkite. The tales of Gondar's incredible skill stretch on, with each daring feat more unbelievable than the last, each target more elusive. For the right price, the hunted know, anyone can be found. For the right price, even the mightiest may find fear in the shadows.",
                    ActionPoints = 2,
                    HeroClass = HeroClass.Assasin,
                    Race = HeroRace.Beast
                },
                //Hero Chaos Knight
                new Hero
                {
                    Id = Guid.Parse("038a0497-bf84-45cd-8fcc-22fd78bcafe1"),
                    Img = "ChaosKnight.jpg",
                    Name = "Chaos Knight",
                    Mana = 3D,
                    Manaregen = 0.5D,
                    Health = 600D,
                    Damage = 75D,
                    DamageType = DamageType.Pure,
                    Armor = 8D,
                    HealthRegen = 35D,
                    Description = "The veteran of countless battles on a thousand worlds, Chaos Knight hails from a far upstream plane where the fundamental laws of the universe have found sentient expression. Of all the ancient Fundamentals, he is the oldest and most tireless, endlessly searching out a being he knows only as \"The Light.\" Long ago the Light ventured out from the progenitor realm, in defiance of the first covenant. Now Chaos Knight shifts from plane to plane, always on the hunt to extinguish the Light wherever he finds it. A thousand times he has snuffed out the source, and always he slides into another plane to continue his search anew. Upon his steed Armageddon he rides, wading into battle with maniacal frenzy, drawing strength from the disorder of the universe. A physical manifestation of chaos itself, in times of need he calls upon other versions of himself from other planes, and together these dark horsemen ride into battle, as unstoppable as any force of nature. Only when the last Light of the world is scoured from existence will the search be ended. Where rides the Chaos Knight, death soon follows.",
                    ActionPoints = 4,
                    HeroClass = HeroClass.Knight,
                    Race = HeroRace.Demon
                },
                //Hero Crystal Maiden
                new Hero
                {
                    Id = Guid.Parse("f6620430-3d02-4bae-9802-066434d03668"),
                    Img = "CrystalMaiden.jpg",
                    Name = "Crystal Maiden",
                    Mana = 5D,
                    Manaregen = 1D,
                    Health = 300D,
                    Damage = 35D,
                    DamageType = DamageType.Magical,
                    Armor = 3D,
                    HealthRegen = 15D,
                    Description = "Born in a temperate realm, raised with her fiery older sister Lina, Rylai the Crystal Maiden soon found that her innate elemental affinity to ice created trouble for all those around her. Wellsprings and mountain rivers froze in moments if she stopped to rest nearby; ripening crops were bitten by frost, and fruiting orchards turned to mazes of ice and came crashing down, spoiled. When their exasperated parents packed Lina off to the equator, Rylai found herself banished to the cold northern realm of Icewrack, where she was taken in by an Ice Wizard who had carved himself a hermitage at the crown of the Blueheart Glacier. After long study, the wizard pronounced her ready for solitary practice and left her to take his place, descending into the glacier to hibernate for a thousand years. Her mastery of the Frozen Arts has only deepened since that time, and now her skills are unmatched.",
                    ActionPoints = 1,
                    HeroClass = HeroClass.Mage,
                    Race = HeroRace.Human
                },
                //Hero Dazzle
                new Hero
                {
                    Id = Guid.Parse("66e9be55-ffef-438a-9203-64a7a3062af7"),
                    Img = "Dazzle.jpg",
                    Name = "Dazzle",
                    Mana = 3D,
                    Manaregen = 1D,
                    Health = 450,
                    Damage = 45,
                    DamageType = DamageType.Physical,
                    Armor = 5D,
                    HealthRegen = 50D,
                    Description = "Each young acolyte to the Dezun order must complete a series of rites before becoming a shadow priest. The final rite, the rite of shades, is a harrowing spiritual journey through the Nothl Realm, an unpredictable domain from which not all visitants return. Of those who do, some return mad. Others return with strange aptitudes. But all who go there are changed by their experiences. Driven by the need for enlightenment, Dazzle was the youngest of his tribe ever to request the sacred ritual. At first the order refused him, saying he was too young. But Dazzle was not to be dissuaded. Sensing something special in the headstrong young acolyte, the elders relented. Dazzle drank down the sacred potion and sat by the fire while the rest of his tribe danced through the night. In this ethereal dimension of the Nothl Realm, the properties of light and dark are inverted. Thus his brilliant healing light, beautiful to our eye, is actually a sinister kind of evil; and the darkest deeds are done in a dazzling glow. The elders' intuition was prophetic: Dazzle returned to his people as a Shadow Priest like none seen before, with the power to heal as well as to destroy. Now he uses his gift to fight his enemies and help his friends.",
                    ActionPoints = 3,
                    HeroClass = HeroClass.Healer,
                    Race = HeroRace.Troll
                },
                //Hero Drow Ranger
                new Hero
                {
                    Id = Guid.Parse("7129011f-bca0-4449-9629-3a46198267a1"),
                    Img = "DrowRanger.jpg",
                    Name = "Drow Ranger",
                    Mana = 3,
                    Manaregen = 0.5D,
                    Health = 300D,
                    Damage = 75D,
                    DamageType = DamageType.Physical,
                    Armor = 2D,
                    HealthRegen = 20D,
                    Description = "Drow Ranger's given name is Traxex--a name well suited to the short, trollish, rather repulsive Drow people. But Traxex herself is not a Drow. Her parents were travelers in a caravan set upon by bandits, whose noisy slaughter of innocents roused the ire of the quiet Drow people. After the battle settled, the Drow discovered a small girl-child hiding in the ruined wagons, and agreed she could not be abandoned. Even as child, Traxex showed herself naturally adept at the arts they prized: Stealth, silence, subtlety. In spirit, if not in physique, she might have been a Drow changeling, returned to her proper home. But as she grew, she towered above her family and came to think of herself as ugly. After all, her features were smooth and symmetrical, entirely devoid of warts and coarse whiskers. Estranged from her adopted tribe, she withdrew to live alone in the woods. Lost travelers who find their way from the forest sometimes speak of an impossibly beautiful Ranger who peered at them from deep among the trees, then vanished like a dream before they could approach. Lithe and stealthy, icy hot, she moves like mist in silence. That whispering you hear is her frozen arrows finding an enemy's heart.",
                    ActionPoints = 1,
                    HeroClass = HeroClass.Hunter,
                    Race = HeroRace.Undead
                },
                //Hero Enchantress
                new Hero
                {
                    Id = Guid.Parse("e618edeb-ba86-449a-9602-896adb2db850"),
                    Img = "Enchantress.jpg",
                    Name = "Enchantress",
                    Mana = 5D,
                    Manaregen = 1D,
                    Health = 300D,
                    Damage = 55D,
                    DamageType = DamageType.Physical,
                    Armor = 4D,
                    HealthRegen = 15D,
                    Description = "Aiushtha appears to be an innocent, carefree creature of the woods, and while this is certainly true, it is hardly the sum of her story. She well understands the suffering of the natural world. She has wandered far, and fared through forests bright and drear, in every clime and every season, gathering friends, sharing news, bringing laughter and healing wherever she goes. For in worlds wracked by war, forests are leveled for the building of ships and siege engines; and even in places of peace, the woods are stripped for the building of homes, and as fuel for countless hearths. Aiushtha hears the pleas of the small creatures, the furtive folk who need green shade and a leafy canopy to thrive. She lends her ears to those who have no other listeners. She carries their stories from the wood to the world, believing that her own good cheer is a kind of Enchantment, that can itself fulfill the promise of a verdant future.",
                    ActionPoints = 1,
                    HeroClass = HeroClass.Healer,
                    Race = HeroRace.Beast
                },
                //Hero Juggernaut
                new Hero
                {
                    Id = Guid.Parse("484c6ca0-42c8-42ec-80ed-c919ef6f186c"),
                    Img = "Juggernaut.jpg",
                    Name = "Juggernaut",
                    Mana = 4D,
                    Manaregen = 0.5D,
                    Health = 600D,
                    Damage = 60D,
                    DamageType = DamageType.Physical,
                    Armor = 5D,
                    HealthRegen = 25,
                    Description = "No one has ever seen the face hidden beneath the mask of Yurnero the Juggernaut. It is only speculation that he even has one. For defying a corrupt lord, Yurnero was exiled from the ancient Isle of Masks--a punishment that saved his life. The isle soon after vanished beneath the waves in a night of vengeful magic. He alone remains to carry on the Isle's long Juggernaut tradition, one of ritual and swordplay. The last practitioner of the art, Yurnero's confidence and courage are the result of endless practice; his inventive bladework proves that he has never stopped challenging himself. Still, his motives are as unreadable as his expression. For a hero who has lost everything twice over, he fights as if victory is a foregone conclusion.",
                    ActionPoints = 3,
                    HeroClass = HeroClass.Warrior,
                    Race = HeroRace.Human
                },
                //Hero Lich
                new Hero
                {
                    Id = Guid.Parse("deb26782-8dd4-4d8e-9016-1202138b7b59"),
                    Img = "Lich.jpg",
                    Name = "Lich",
                    Mana = 6D,
                    Manaregen = 2D,
                    Health = 450D,
                    Damage = 45D,
                    DamageType = DamageType.Magical,
                    Armor = 3D,
                    HealthRegen = 25D,
                    Description = "In life, the frost-mage Ethreain (not yet a Lich) had used the threat of destructive ice to enslave entire kingdoms. His subjects, aided by a few desperate magicians, eventually grew bold enough to ambush him. Armed with enough charmed rope to bind him forever, they tied the frost mage to adamant weights and dropped him in a pool known chiefly for being bottomless. It wasn't. He only fell for a year or so before an outcrop snagged him. There he rested, dead but undecaying, until the geomancer Anhil thought to verify the legend of the supposedly bottomless Black Pool. Anhil's plumbline snarled with the ropes that bound the drowned magician, and up he hauled an unexpected prize. Thinking that by rendering the dead undead, he could question the Lich about the properties of the pool, he removed the bindings and commenced a simple rite of resurrection. Even the descendants of Ethreain's enemies were long forgotten by time, so there were none to warn Anhil against imprudence. But he learned the error of his judgment almost immediately, as Lich threw off the shackles and consumed him.",
                    ActionPoints = 2,
                    HeroClass = HeroClass.Mage,
                    Race = HeroRace.Undead
                },
                //Hero Queen Of Pain
                new Hero
                {
                    Id = Guid.Parse("b3c06915-0178-42de-a9bb-4369a41acfac"),
                    Img = "QueenOfPain.jpg",
                    Name = "Queen Of Pain",
                    Mana = 3D,
                    Manaregen = 0.5,
                    Health = 400D,
                    Damage = 60D,
                    DamageType = DamageType.Pure,
                    Armor = 1D,
                    HealthRegen = 10D,
                    Description = "The Ecclesiast-King of Elze nursed a desire for pain — forbidden pain. In a less prominent political figure, such desires might be considered unwise, but in a monarch of his stature, to satisfy such thirsts would have threatened the virtue of the Divine Throne itself. Therefore he turned to his dungeon full of demonologists, promising freedom to whoever could summon a personal succubus of torment and bind it entirely to his service. The creature who arrived, Akasha by name, visited upon him such exquisite torments that he named her his Secret Queen, and he began to spend all his spare moments submitting to her clever torments—eventually abdicating all his responsibilities in his pursuit of the painful pleasures that only she could bring. Queen of Pain could bring him to the brink of death, but she was rune-bound to keep him alive. At last the King's neglect of state brought on an uprising. He was dragged from his chamber and hurled from the Tower of Invocations, and at the moment of death, Queen of Pain was let loose into the world, freed from servitude—freed to visit her sufferings on anyone she deigned to notice.",
                    ActionPoints = 3,
                    HeroClass = HeroClass.Assasin,
                    Race = HeroRace.Demon
                },
                //Hero Shadow Fiend
                new Hero
                {
                    Id = Guid.Parse("cc45d15c-a24a-4e04-9720-8e1e7841f6b4"),
                    Img = "ShadowFiend.jpg",
                    Name = "Shadow Fiend",
                    Mana = 5D,
                    Manaregen = 0.5D,
                    Health = 400D,
                    Damage = 65D,
                    DamageType = DamageType.Pure,
                    Armor = 3D,
                    HealthRegen = 10D,
                    Description = "It is said that Nevermore the Shadow Fiend has the soul of a poet, and in fact he has thousands of them. Over the ages he has claimed the souls of poets, priests, emperors, beggars, slaves, philosophers, criminals and (naturally) heroes; no sort of soul escapes him. What he does with them is unknown. No one has ever peered into the Abysm whence Nevermore reaches out like an eel from among astral rocks. Does he devour them one after another? Does he mount them along the halls of an eldritch temple, or pickle the souls in necromantic brine? Is he merely a puppet, pushed through the dimensional rift by a demonic puppeteer? Such is his evil, so intense his aura of darkness, that no rational mind may penetrate it. Of course, if you really want to know where the stolen souls go, there's one sure way to find out: Add your soul to his collection. Or just wait for Nevermore.",
                    ActionPoints = 5,
                    HeroClass = HeroClass.Warlock,
                    Race = HeroRace.Demon
                },
                //Hero Troll Warlord
                new Hero
                {
                    Id = Guid.Parse("f9678bc4-bfe5-4bd9-a333-a0a93e943baa"),
                    Img = "TrollWarlord.jpg",
                    Name = "Troll Warlord",
                    Mana = 3D,
                    Manaregen = 0.5D,
                    Health = 650D,
                    Damage = 85D,
                    DamageType = DamageType.Physical,
                    Armor = 12D,
                    HealthRegen = 50D,
                    Description = "It's an easy thing to offend a troll. A prickly and contentious race, trolls thrive on argument and strife, missing no excuse to raise their voices in dispute. Males grow to maturity in subterranean chambers beneath their matriarch's domicile, feeding and amusing themselves while contributing nothing. Often they stay for years beyond the age of maturity, while the matriarch provides them with sustenance. When young trolls are finally pushed from their sub-chamber, they gather with others of their kind, forming roving gangs of malcontents who complain loudly about all manner of vexation. As much as trolls love to argue, imagine how rare it is for a troll to be driven from his own kind for being too difficult to get along with. Such was Jah'rakal's fate, a monger troll from deep in the Hoven. So deluded was he, so bitter and abrasive, that even other trolls found his company intolerable. After one particularly vitriolic outburst in which he claimed the lion's share of loot from their latest raid, his cohorts finally snapped. They turned on him, beat him with clubs, and drove him from the encampment. Enraged at his banishment, he returned the next day, armed with steel, and slew them all, one by one. He then swore a blood oath: he would ever after be a fighting force unto himself. Now he roams the world as the Troll Warlord, bitter and angry, the Imperial high commander of an army of one.",
                    ActionPoints = 4,
                    HeroClass = HeroClass.Warrior,
                    Race = HeroRace.Troll
                },
                //Hero Tusk
                new Hero
                {
                    Id = Guid.Parse("9cae91c6-5213-4447-a4b3-458c2e4dd944"),
                    Img = "Tusk.jpg",
                    Name = "Tusk",
                    Mana = 3D,
                    Manaregen = 0.5D,
                    Health = 550D,
                    Damage = 75D,
                    DamageType = DamageType.Physical,
                    Armor = 6D,
                    HealthRegen = 45D,
                    Description = "It had been a brawl to remember. There stood Ymir, the Tusk, the Terror from the Barrier, the Snowball from Cobalt, the only fighter to have bested the Bristled Bruiser in a fair fight, and now the last man standing in Wolfsden Tavern. What started as a simple bar bet of supremacy ended with four regulars, a blacksmith, and six of the Frost Brigade's best soldiers writhing against the shards and splinters of almost every bottle, mug, and chair in the building. The Tusk boasted and toasted his victory as he emptied his brew. No sooner had the defeated regained consciousness than the cries for double-or-nothing rang out. The Tusk was pleased at the prospect, but none could think of a bet bigger than the one he just conquered. Horrified at the damage to his tavern and desperate to avoid another brawl, the barkeep had an idea. As skilled as he was, Ymir had never taken part in a real battle, never tested himself against the indiscriminate death and chaos of war. He proposed a wager to the fighter: seek out the biggest battle he could find, survive, and win it for whichever side he chose. The stakes? The next round of drinks.",
                    ActionPoints = 2,
                    HeroClass = HeroClass.Warrior,
                    Race = HeroRace.Beast
                }
                );
            #endregion

            #region DealDamage
            modelBuilder.Entity<DealDamage>().HasData(
                //DealDamage == 100 Physical
                new DealDamage
                {
                    Id = Guid.Parse("64e1a36b-d705-468f-8bfd-58d60d01a9a8"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Physical,
                    DamageAmount = 100D
                },
                //DealDamage 1 == 150 Magical
                new DealDamage
                {
                    Id = Guid.Parse("b1c4dd1a-d2cc-4f16-842e-c5b99bfcb4bd"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Magical,
                    DamageAmount = 150D
                },
                //DealDamage 2 == 150 Pure
                new DealDamage
                {
                    Id = Guid.Parse("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Pure,
                    DamageAmount = 150D
                },
                //DealDamage 3 == 200 Pure
                new DealDamage
                {
                    Id = Guid.Parse("80e4330a-1ec5-498d-b3b9-eb74cef24775"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Pure,
                    DamageAmount = 200D
                },
                //DealDamage 4 == 200 Magical
                new DealDamage
                {
                    Id = Guid.Parse("1dacb3a7-21f4-4439-b23d-c1e693084ee4"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Magical,
                    DamageAmount = 200D
                },
                //DealDamage 5 == 300 Magical
                new DealDamage
                {
                    Id = Guid.Parse("915f8f7d-2a9d-4995-ae89-9d6f6e7bb40d"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Magical,
                    DamageAmount = 300D
                },
                //DealDamage 6 == 300 Pure
                new DealDamage
                {
                    Id = Guid.Parse("e5af0d52-5663-44f2-b537-dace6d117229"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Pure,
                    DamageAmount = 300D
                },
                //DealDamage == 300 Physical
                new DealDamage
                {
                    Id = Guid.Parse("3e8534bc-9679-4380-9034-1b9d62d6b8f5"),
                    Description = "",
                    EffectType = EffectType.DealDamage,
                    DamageType = DamageType.Physical,
                    DamageAmount = 300D
                }
                );
            #endregion

            #region Heal
            modelBuilder.Entity<Heal>().HasData(
                //Heal 1 75
                new Heal
                {
                    Id = Guid.Parse("460be20d-f644-4bc2-9286-7ead03b64e9c"),
                    Description = "",
                    EffectType = EffectType.Heal,
                    HealAmount = 75D
                },
                //Heal 2 150
                new Heal
                {
                    Id = Guid.Parse("1a78deb7-c5d1-43de-be46-5945153a6aca"),
                    Description = "",
                    EffectType = EffectType.Heal,
                    HealAmount = 150D
                },
                //Heal 3 300
                new Heal
                {
                    Id = Guid.Parse("2d81259f-a7eb-4fa8-bfdb-613f93e6a9a4"),
                    Description = "",
                    EffectType = EffectType.Heal,
                    HealAmount = 300D
                }
                );
            #endregion

            #region LifeSteal
            modelBuilder.Entity<Lifesteal>().HasData(
                //Lifesteal 1 25%
                new Lifesteal
                {
                    Id = Guid.Parse("ec381dc9-c1e5-47fb-8c57-51678224f07f"),
                    Description = "",
                    EffectType = EffectType.LifeSteal,
                    LifeStealPercentage = 0.25D
                },
                //Lifesteal 2 50%
                new Lifesteal
                {
                    Id = Guid.Parse("55301e2e-9fb6-42cb-9973-498dc910fab1"),
                    Description = "",
                    EffectType = EffectType.LifeSteal,
                    LifeStealPercentage = 0.5D
                },
                //Lifesteal 3 100%
                new Lifesteal
                {
                    Id = Guid.Parse("1c021dbd-16a9-4146-b810-ff1d36211599"),
                    Description = "",
                    EffectType = EffectType.LifeSteal,
                    LifeStealPercentage = 1D
                },
                //Lifesteal 4 300%
                new Lifesteal
                {
                    Id = Guid.Parse("72ef6e9f-23a9-41c5-817d-3ba44b6ffc5f"),
                    Description = "",
                    EffectType = EffectType.LifeSteal,
                    LifeStealPercentage = 3D
                }
                );
            #endregion

            #region MultipleTargets
            modelBuilder.Entity<MultipleTarget>().HasData(
                //MultipleTarget EnemyHeroes 2 Area 1
                new MultipleTarget
                {
                    Id = Guid.Parse("646aa733-f4cf-4392-a339-2a067044d787"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 2,
                    AreaOfEffect = 1
                },
                //MultipleTarget EnemyHeroes 3 Area 1
                new MultipleTarget
                {
                    Id = Guid.Parse("907b6938-1c4c-45dd-aa5c-c6be1c6965de"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 3,
                    AreaOfEffect = 1
                },
                //MultipleTarget EnemyHeroes 3 Area 3
                new MultipleTarget
                {
                    Id = Guid.Parse("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 3,
                    AreaOfEffect = 3
                },
                //MultipleTarget EnemyHeroes 3 Area 5
                new MultipleTarget
                {
                    Id = Guid.Parse("7f0c2aa1-42ca-4b97-8371-7e7821a4a745"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 3,
                    AreaOfEffect = 5
                },
                //MultipleTarget EnemyHeroes 4 Area 2
                new MultipleTarget
                {
                    Id = Guid.Parse("952d3a54-9c70-4c2b-a657-20d077a62238"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 4,
                    AreaOfEffect = 2
                },
                //MultipleTarget EnemyHeroes 5 Area 1
                new MultipleTarget
                {
                    Id = Guid.Parse("799d2e51-f05c-4975-8a2b-99ddfeb8d9ca"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 5,
                    AreaOfEffect = 1
                },
                //MultipleTarget EnemyHeroes All
                new MultipleTarget
                {
                    Id = Guid.Parse("13d0b53a-c6ad-425c-a8c1-be7ae118e78a"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Enemy,
                    AmountOfTargets = 99,
                    AreaOfEffect = 99
                },
                //MultipleTarget FriendlyHeroes 3 Area 1
                new MultipleTarget
                {
                    Id = Guid.Parse("11c5b5e5-60a7-4093-9c45-d3bb0acdb1df"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Friendly,
                    AmountOfTargets = 3,
                    AreaOfEffect = 1
                },
                //MultipleTarget FriendlyHeroes 3 Area 3
                new MultipleTarget
                {
                    Id = Guid.Parse("08bf6141-fb84-47d1-a8e1-99b227c67ed3"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Friendly,
                    AmountOfTargets = 3,
                    AreaOfEffect = 3
                },
                //MultipleTarget FriendlyHeroes 4 Area 3
                new MultipleTarget
                {
                    Id = Guid.Parse("253acb52-d5c6-4cd6-a8f8-974be5b6a91d"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Friendly,
                    AmountOfTargets = 5,
                    AreaOfEffect = 4
                },
                //MultipleTarget FriendlyHeroes 5 Area 4
                new MultipleTarget
                {
                    Id = Guid.Parse("46e167dc-52ad-4fbe-9950-967f55dc19c8"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Friendly,
                    AmountOfTargets = 5,
                    AreaOfEffect = 4
                },
                //MultipleTarget FriendlyHeroes 5 Area 1
                new MultipleTarget
                {
                    Id = Guid.Parse("0faafc79-6a2c-4506-b68a-d5c9ce226bdc"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Friendly,
                    AmountOfTargets = 5,
                    AreaOfEffect = 1
                },
                //MultipleTarget FriendlyHeroes All
                new MultipleTarget
                {
                    Id = Guid.Parse("a73a283d-a5fd-46cf-a95f-c03b05473295"),
                    TargetType = TargetType.Multiple,
                    HeroTargetType = HeroTargetType.Friendly,
                    AmountOfTargets = 99,
                    AreaOfEffect = 99
                }
                );
            #endregion

            #region PassiveSkills
            modelBuilder.Entity<PassiveSkill>().HasData(
                //Passive Skill Arcane Aura
                new PassiveSkill
                {
                    Id = Guid.Parse("f600f388-352a-4674-a533-1cc1347b7d61"),
                    Img = "ArcaneAura.jpg",
                    Name = "Arcane Aura",
                    Skillsort = SkillSort.Passive
                },
                //Passive Skill Bad Juju
                new PassiveSkill
                {
                    Id = Guid.Parse("6ac2049f-151e-40bb-899e-0e836e0b6f5c"),
                    Img = "BadJuju.jpg",
                    Name = "Bad Juju",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Beautiful Inside
                new PassiveSkill
                {
                    Id = Guid.Parse("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"),
                    Img = "BeautifulInside.jpg",
                    Name = "Beautiful Inside",
                    Skillsort = SkillSort.Passive
                },
                //Passive Skill Blade Dance
                new PassiveSkill
                {
                    Id = Guid.Parse("36478d6b-ac61-4c5a-af51-c649ff8851d2"),
                    Img = "BladeDance.jpg",
                    Name = "Blade Dance",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Bon Appetit
                new PassiveSkill
                {
                    Id = Guid.Parse("87e38d0b-af62-439a-8cfa-febc53ac1b01"),
                    Img = "BonAppetit.jpg",
                    Name = "Bon Appetit",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Chaos Strike
                new PassiveSkill
                {
                    Id = Guid.Parse("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"),
                    Img = "ChaosStrike.jpg",
                    Name = "Chaos Strike",
                    Skillsort = SkillSort.Passive
                },
                // PassiveSkill Demonic Attack
                new PassiveSkill
                {
                    Id = Guid.Parse("69bfd9cd-6c36-4637-8f17-6951cacb1204"),
                    Img = "DemonicAttack.jpg",
                    Name = "Demonic Attack",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Fearful Aura
                new PassiveSkill
                {
                    Id = Guid.Parse("85d9908a-f79d-4586-9637-91c9de70983c"),
                    Img = "FearfulAura.jpg",
                    Name = "Fearful Aura",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Jinada
                new PassiveSkill
                {
                    Id = Guid.Parse("35c69f01-7c39-4324-aa6f-d550676229ad"),
                    Img = "Jinada.jpg",
                    Name = "Jinada",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Healing Attendant 
                new PassiveSkill
                {
                    Id = Guid.Parse("dd027abc-a8b9-4d89-b582-41c480c4fb45"),
                    Img = "HealingAttendant.jpg",
                    Name = "Healing Attendant",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Human Mind
                new PassiveSkill
                {
                    Id = Guid.Parse("f50ade16-3b0e-4de4-af15-f268f075dd78"),
                    Img = "HumanMind.jpg",
                    Name = "Human Mind",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Marksmanship
                new PassiveSkill
                {
                    Id = Guid.Parse("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39"),
                    Img = "Marksmanship.jpg",
                    Name = "Marksmanship",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Orc's Flesh
                new PassiveSkill
                {
                    Id = Guid.Parse("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"),
                    Img = "Orc'sFlesh.jpg",
                    Name = "Orc's Flesh",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Presence Of The Dark Lord
                new PassiveSkill
                {
                    Id = Guid.Parse("7e4656e2-1440-46ee-a5e9-2438e359f33b"),
                    Img = "PresenceOfTheDarkLord.jpg",
                    Name = "Presence Of The Dark Lord",
                    Skillsort = SkillSort.Passive
                },
                //PassiveSkill Sharp Paw
                new PassiveSkill
                {
                    Id = Guid.Parse("18ef20f2-b94d-4a3f-b38e-60d247a4c627"),
                    Img = "SharpPaw.jpg",
                    Name = "Sharp Paw",
                    Skillsort = SkillSort.Passive
                }
                );
            #endregion

            #region Reduce
            modelBuilder.Entity<Reduce>().HasData(
                //Reduce 1 Armor 5
                new Reduce
                {
                    Id = Guid.Parse("16b9e7ba-239d-4c5b-a337-f3f78fff8065"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 5D,
                    ReduceType = ReduceType.Armor,
                    EffectState = EffectState.Debuff
                },
                //Reduce Armor 10
                new Reduce
                {
                    Id = Guid.Parse("04b17411-2761-465b-84cf-ac0e3589073d"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 10D,
                    ReduceType = ReduceType.Armor,
                    EffectState = EffectState.Debuff
                },
                //Reduce 2 Armor 15
                new Reduce
                {
                    Id = Guid.Parse("6634567a-136f-4c81-af40-7b08aba8e5f4"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 15D,
                    ReduceType = ReduceType.Armor,
                    EffectState = EffectState.Debuff
                },
                //Reduce 3 Damage 50
                new Reduce
                {
                    Id = Guid.Parse("ecaee0cf-bafa-4f21-8e6d-2e5fbd3cfe87"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 50D,
                    ReduceType = ReduceType.Damage,
                    EffectState = EffectState.Debuff
                },
                //Reduce 5 Health 200
                new Reduce
                {
                    Id = Guid.Parse("9faee829-0506-4e85-9892-decee6915dba"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 200D,
                    ReduceType = ReduceType.Health,
                    EffectState = EffectState.Debuff
                },
                //Reduce 6 Health 500
                new Reduce
                {
                    Id = Guid.Parse("b0c0f122-5310-4e9d-b809-c5727a6a11b0"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 400D,
                    ReduceType = ReduceType.Health,
                    EffectState = EffectState.Debuff
                },
                //Reduce 7 HealthRegen 50
                new Reduce
                {
                    Id = Guid.Parse("fddacf94-fb30-4476-be90-6c9ecd14c9c2"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 50D,
                    ReduceType = ReduceType.HealthRegen,
                    EffectState = EffectState.Debuff
                },
                //Reduce 8 HealthRegen 100
                new Reduce
                {
                    Id = Guid.Parse("16bde603-b191-4d96-a7fd-f5fb4609e357"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 100D,
                    ReduceType = ReduceType.HealthRegen,
                    EffectState = EffectState.Debuff
                },
                //Reduce 9 Mana 5
                new Reduce
                {
                    Id = Guid.Parse("3fff91e9-8452-488f-bd23-26d3d308ab14"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 5D,
                    ReduceType = ReduceType.Mana,
                    EffectState = EffectState.Debuff
                },
                //Reduce 11 ManaRegen 1.5
                new Reduce
                {
                    Id = Guid.Parse("8ed07187-66df-4d46-b1a0-1bdeb8dbacc8"),
                    Description = "",
                    EffectType = EffectType.Reduce,
                    ReduceAmount = 1.5D,
                    ReduceType = ReduceType.ManaRegen,
                    EffectState = EffectState.Debuff
                }
                );
            #endregion

            #region Silence
            modelBuilder.Entity<Silence>().HasData(
                //Silence 1 Duration 2 
                new Silence
                {
                    Id = Guid.Parse("c650314d-e527-43ce-9932-5a6b01e7e309"),
                    Description = "",
                    EffectType = EffectType.Silence,
                    SilenceDuration = 2D,
                    EffectState = EffectState.Debuff
                },
                //Silence 2 Duration 4
                new Silence
                {
                    Id = Guid.Parse("0025b00d-bbae-47ea-9d0d-e47f5c72ff3d"),
                    Description = "",
                    EffectType = EffectType.Silence,
                    SilenceDuration = 4D,
                    EffectState = EffectState.Debuff
                },
                //Silence 3 Duration 6
                new Silence
                {
                    Id = Guid.Parse("f44a84c3-c6eb-42ec-9bb7-c69d9b6abdc0"),
                    Description = "",
                    EffectType = EffectType.Silence,
                    SilenceDuration = 6D,
                    EffectState = EffectState.Debuff
                }
                );
            #endregion

            #region SingleTargets
            modelBuilder.Entity<SingleTarget>().HasData(
                //SingleTarget Enemy
                new SingleTarget
                {
                    Id = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9"),
                    TargetType = TargetType.Single,
                    HeroTargetType = HeroTargetType.Enemy
                },
                //SingleTarget Friendly
                new SingleTarget
                {
                    Id = Guid.Parse("636e0bb8-2876-4072-814f-1ab11e732e6c"),
                    TargetType = TargetType.Single,
                    HeroTargetType = HeroTargetType.Friendly
                },
                //SingleTarget SelfTarget
                new SingleTarget
                {
                    Id = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87"),
                    TargetType = TargetType.Single,
                    HeroTargetType = HeroTargetType.Self
                }
                );
            #endregion

            #region Stun
            modelBuilder.Entity<Stun>().HasData(
                //Stun 1 Duration 2
                new Stun
                {
                    Id = Guid.Parse("0feb5631-dd56-44b2-a207-00ee33551f09"),
                    Description = "",
                    EffectType = EffectType.Stun,
                    StunDuration = 2D,
                    EffectState = EffectState.Debuff
                },
                //Stun Duration 3
                new Stun
                {
                    Id = Guid.Parse("a0c92644-5852-4a0d-884f-f27ca162fa0e"),
                    Description = "",
                    EffectType = EffectType.Stun,
                    StunDuration = 3D,
                    EffectState = EffectState.Debuff
                },
                //Stun 2 Duration 4
                new Stun
                {
                    Id = Guid.Parse("f7a3978f-30de-4d76-b087-e5146c788b6b"),
                    Description = "",
                    EffectType = EffectType.Stun,
                    StunDuration = 4D,
                    EffectState = EffectState.Debuff
                },
                //Stun 3 Duration 6
                new Stun
                {
                    Id = Guid.Parse("4c7c8b0a-5409-41f9-a97d-00f3c7abc45b"),
                    Description = "",
                    EffectType = EffectType.Stun,
                    StunDuration = 6D,
                    EffectState = EffectState.Debuff
                }
                );
            #endregion

            #region Summon
            modelBuilder.Entity<Summon>().HasData(
                //Summon 1 Fearul Sigil
                new
                {
                    Id = Guid.Parse("826bcba5-228b-4685-b454-5b233e2cd036"),
                    Description = "",
                    EffectType = EffectType.Summon,
                    SummonUnitId = Guid.Parse("27f53ca1-3a40-4462-961d-d860547d8417"),
                    AmountToSummon = 1
                },
                //Summon 7 Nature's Attendants
                new
                {
                    Id = Guid.Parse("15332b71-72f5-45b8-9027-263ce0328067"),
                    Description = "",
                    EffectType = EffectType.Summon,
                    SummonUnitId = Guid.Parse("dedb8175-0d78-4644-9ec9-eb0a7b8315a4"),
                    AmountToSummon = 7,

                }

                //    //Summon 3
                //    new
                //    {
                //        Id = Guid.Parse("1a7762ef-65c7-40b6-ad0b-08dee5e4e9da"),
                //        Description = "",
                //        EffectType = EffectType.Summon,
                //        SummonUnitId = Guid.Parse(""),
                //        AmountToSummon = 1D
                //    }
                );
            #endregion

            #region SkillEffects
            modelBuilder.Entity<SkillEffects>().HasData(
                //Arcane Aura || Amplify ManaRegeneration 1.5 || Multiple Friendly Amount 5 Area 4
                new SkillEffects
                {
                    SkillId = Guid.Parse("f600f388-352a-4674-a533-1cc1347b7d61"),
                    EffectId = Guid.Parse("eebe8f58-962c-4a81-8d9a-ea9c0b63d9d7"),
                    TargetId = Guid.Parse("46e167dc-52ad-4fbe-9950-967f55dc19c8")
                },
                //Arcane Aura || Amplify Mana 5 || Friendly Amount 3 Area 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("f600f388-352a-4674-a533-1cc1347b7d61"),
                    EffectId = Guid.Parse("03f7e71e-1729-4b24-a192-90c0470d83ed"),
                    TargetId = Guid.Parse("08bf6141-fb84-47d1-a8e1-99b227c67ed3")
                },
                //Bad Juju || Reduce Armor 5 || Enemy Amount 3 Area 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("6ac2049f-151e-40bb-899e-0e836e0b6f5c"),
                    EffectId = Guid.Parse("16b9e7ba-239d-4c5b-a337-f3f78fff8065"),
                    TargetId = Guid.Parse("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e")
                },
                //Bad Juju || Amplify Armor 5 || Friendly Amount 3 Area 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("6ac2049f-151e-40bb-899e-0e836e0b6f5c"),
                    EffectId = Guid.Parse("44c83bc1-ecf8-4d19-b2cf-c608dcb4fe6a"),
                    TargetId = Guid.Parse("08bf6141-fb84-47d1-a8e1-99b227c67ed3")
                },
                //Battle Trance || Amplify Damage 50 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("50fe62bf-979a-4ee7-9f12-b5313e00de98"),
                    EffectId = Guid.Parse("a4d29024-307a-4a9b-8fe1-8db09421d73a"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Battle Trance || Lifesteal 100% || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("50fe62bf-979a-4ee7-9f12-b5313e00de98"),
                    EffectId = Guid.Parse("1c021dbd-16a9-4146-b810-ff1d36211599"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Beautiful Inside || Amplify Health Regeneration 50 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"),
                    EffectId = Guid.Parse("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Beautiful Inside || Amplify Health 250 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("29c6ba61-a08f-4e32-9d46-77aa6c8f1478"),
                    EffectId = Guid.Parse("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Blade Dance || 30% Critical 2x Physical || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("36478d6b-ac61-4c5a-af51-c649ff8851d2"),
                    EffectId = Guid.Parse("d436f5e5-d729-4d24-be7b-52e235b3bda8"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Bon Appetit || Lifesteal 25% || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("87e38d0b-af62-439a-8cfa-febc53ac1b01"),
                    EffectId = Guid.Parse("ec381dc9-c1e5-47fb-8c57-51678224f07f"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Bon Appetit || Amplify Health Regeneration 50 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("87e38d0b-af62-439a-8cfa-febc53ac1b01"),
                    EffectId = Guid.Parse("c5abb22c-394a-41a4-a1b7-df2ef3dfebc1"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //ChainFrost || DealDamage 300 Magical || Enemy Amount 3 Area 5
                new SkillEffects
                {
                    SkillId = Guid.Parse("b783a6d3-af5b-4b10-9f53-f3b05eb84aaf"),
                    EffectId = Guid.Parse("915f8f7d-2a9d-4995-ae89-9d6f6e7bb40d"),
                    TargetId = Guid.Parse("7f0c2aa1-42ca-4b97-8371-7e7821a4a745")
                },
                //ChaosBolt || Stun 2 || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("62ea4143-f6f3-4390-ac72-3e23561ed06b"),
                    EffectId = Guid.Parse("0feb5631-dd56-44b2-a207-00ee33551f09"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //ChaosBolt || DealDamage 150 Pure || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("62ea4143-f6f3-4390-ac72-3e23561ed06b"),
                    EffectId = Guid.Parse("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Chaos Strike || Critical Hit 20% 4x Pure || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"),
                    EffectId = Guid.Parse("10076a8f-db65-4226-b910-cf6059cbe8d1"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Chaos Strike || Lifesteal 25% || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("9bffe083-6bee-4a99-adcc-7d6cfbc8b59b"),
                    EffectId = Guid.Parse("ec381dc9-c1e5-47fb-8c57-51678224f07f"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Demonic Attack || Amplify Damage 50 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("69bfd9cd-6c36-4637-8f17-6951cacb1204"),
                    EffectId = Guid.Parse("a4d29024-307a-4a9b-8fe1-8db09421d73a"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Enchant || Stun 3 || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("cc4610f6-4f20-41d1-a529-522636674ff6"),
                    EffectId = Guid.Parse("a0c92644-5852-4a0d-884f-f27ca162fa0e"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Fearful Aura || Reduce Damage 50 || Enemy Amount 5 Area 1
                new SkillEffects
                {
                    SkillId = Guid.Parse("85d9908a-f79d-4586-9637-91c9de70983c"),
                    EffectId = Guid.Parse("ecaee0cf-bafa-4f21-8e6d-2e5fbd3cfe87"),
                    TargetId = Guid.Parse("799d2e51-f05c-4975-8a2b-99ddfeb8d9ca")
                },
                //Fearful Sigil || Summon 1 Sigil || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("8fb27632-30c5-4e4b-9925-c3594fe55c5a"),
                    EffectId = Guid.Parse("826bcba5-228b-4685-b454-5b233e2cd036"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Frost Armor || Amplify Armor 10 || Friendly
                new SkillEffects
                {
                    SkillId = Guid.Parse("c3414818-5b50-4da6-94e4-129339ccc21b"),
                    EffectId = Guid.Parse("b12bbe16-3e81-4500-abb9-625f88e384f5"),
                    TargetId = Guid.Parse("636e0bb8-2876-4072-814f-1ab11e732e6c")
                },
                //Frostbite || Stun 2 || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("c68ed6dd-0479-47cb-810c-03e897990665"),
                    EffectId = Guid.Parse("0feb5631-dd56-44b2-a207-00ee33551f09"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Frostbite || DealDamage 150 Magical || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("c68ed6dd-0479-47cb-810c-03e897990665"),
                    EffectId = Guid.Parse("b1c4dd1a-d2cc-4f16-842e-c5b99bfcb4bd"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Healing Attendant || Heal 75 || Friendly
                new SkillEffects
                {
                    SkillId = Guid.Parse("dd027abc-a8b9-4d89-b582-41c480c4fb45"),
                    EffectId = Guid.Parse("460be20d-f644-4bc2-9286-7ead03b64e9c"),
                    TargetId = Guid.Parse("636e0bb8-2876-4072-814f-1ab11e732e6c")
                },
                //Human Mind || Amplify Health Regeneration 25 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("f50ade16-3b0e-4de4-af15-f268f075dd78"),
                    EffectId = Guid.Parse("874a9cf7-9719-4bbf-8e7f-30b4c77712e4"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Human Mind || Amplify Mana Regeneration 1 || Friendly 3 Area 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("f50ade16-3b0e-4de4-af15-f268f075dd78"),
                    EffectId = Guid.Parse("d818f097-d830-4b3b-aaec-5abc73d5be59"),
                    TargetId = Guid.Parse("08bf6141-fb84-47d1-a8e1-99b227c67ed3")
                },
                //Jinada || Critical Hit 25% 2.5x || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("35c69f01-7c39-4324-aa6f-d550676229ad"),
                    EffectId = Guid.Parse("d5bd4c65-41a0-4bdc-a155-30d3d343b774"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Marksmanship || DealDamage 100 Physical || Enemy Amount 2 Area 1
                new SkillEffects
                {
                    SkillId = Guid.Parse("7ebeac14-4fac-4afb-9dc0-24fdc0c2fe39"),
                    EffectId = Guid.Parse("64e1a36b-d705-468f-8bfd-58d60d01a9a8"),
                    TargetId = Guid.Parse("646aa733-f4cf-4392-a339-2a067044d787")
                },
                //Nature's Attendants || Summon 7 Wisp || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("147c6bc2-4e9b-4afc-b422-e0130252b1e0"),
                    EffectId = Guid.Parse("15332b71-72f5-45b8-9027-263ce0328067"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Omnislash || DealDamage 300 Physical || Enemy 3 Amount 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("9572a874-9e78-4f3d-9964-5a25daf101d3"),
                    EffectId = Guid.Parse("3e8534bc-9679-4380-9034-1b9d62d6b8f5"),
                    TargetId = Guid.Parse("fb50a816-cd8d-4fd1-ba38-bf277dee7a1e")
                },
                //Orc's Flesh || Amplify Health 250 || Friendly Amount 3 Area 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"),
                    EffectId = Guid.Parse("621a5b22-fcd1-43d5-9a5f-c3d35f6c631e"),
                    TargetId = Guid.Parse("08bf6141-fb84-47d1-a8e1-99b227c67ed3")
                },
                //Orc's Flesh || Amplify Armor 20 || SelfTarget
                new SkillEffects
                {
                    SkillId = Guid.Parse("fc3e01a3-f6db-4912-b95c-ae10a4bc6832"),
                    EffectId = Guid.Parse("265e0345-f383-4ac8-b33c-a4e20ee05faa"),
                    TargetId = Guid.Parse("375b43ef-65db-4b38-9708-66977db44e87")
                },
                //Precision Aura || Amplify Damage 15 || Friendly All
                new SkillEffects
                {
                    SkillId = Guid.Parse("c03d9352-b51b-4d56-afe4-dfb2a32158a2"),
                    EffectId = Guid.Parse("85c2344e-22d7-42e2-aced-84c35c8eb13c"),
                    TargetId = Guid.Parse("a73a283d-a5fd-46cf-a95f-c03b05473295")
                },
                //Precense Of The Dark Lord || Reduce Armor 5 || Enemy All
                new SkillEffects
                {
                    SkillId = Guid.Parse("7e4656e2-1440-46ee-a5e9-2438e359f33b"),
                    EffectId = Guid.Parse("16b9e7ba-239d-4c5b-a337-f3f78fff8065"),
                    TargetId = Guid.Parse("13d0b53a-c6ad-425c-a8c1-be7ae118e78a")
                },
                //Requiem Of Souls || DealDamage 200 Pure || Enemy All
                new SkillEffects
                {
                    SkillId = Guid.Parse("c6be27f6-3217-400f-9427-499d5719a5b6"),
                    EffectId = Guid.Parse("80e4330a-1ec5-498d-b3b9-eb74cef24775"),
                    TargetId = Guid.Parse("13d0b53a-c6ad-425c-a8c1-be7ae118e78a")
                },
                //Scream Of Pain || DealDamage 150 Pure || Enemy Amount 4 Area 2
                new SkillEffects
                {
                    SkillId = Guid.Parse("00f75578-175e-40be-82b3-71e558041981"),
                    EffectId = Guid.Parse("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"),
                    TargetId = Guid.Parse("952d3a54-9c70-4c2b-a657-20d077a62238")
                },
                //Shadow Strike || DealDamage 150 Pure || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("eb1d8e33-1cad-4f14-98c3-72938bad25fd"),
                    EffectId = Guid.Parse("1deaa57c-bc65-485e-8bb1-8d69aeeffa3d"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Shadow Wave || Heal 150 || Friendly Amount 4 Area 3
                new SkillEffects
                {
                    SkillId = Guid.Parse("6d241033-20da-4d9d-88db-d38551007304"),
                    EffectId = Guid.Parse("1a78deb7-c5d1-43de-be46-5945153a6aca"),
                    TargetId = Guid.Parse("253acb52-d5c6-4cd6-a8f8-974be5b6a91d")
                },
                //Sharp Paw || Critical Hit 20% 2x || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("18ef20f2-b94d-4a3f-b38e-60d247a4c627"),
                    EffectId = Guid.Parse("aba933fd-0da7-41aa-a4fb-19e9f6a4e86e"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Sharp Paw || Amplify Damage 25 || Friendly All
                new SkillEffects
                {
                    SkillId = Guid.Parse("18ef20f2-b94d-4a3f-b38e-60d247a4c627"),
                    EffectId = Guid.Parse("783a580c-8153-457c-847f-4e137c7e9b44"),
                    TargetId = Guid.Parse("a73a283d-a5fd-46cf-a95f-c03b05473295")
                },
                //Shuriken Toss || DealDamage 300 Physical || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("e5e7bd4c-2be6-411c-a75c-81b4a8db86c3"),
                    EffectId = Guid.Parse("3e8534bc-9679-4380-9034-1b9d62d6b8f5"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Walrus Punch || Critical Hit 100% 2.5x Physical || Enemy
                new SkillEffects
                {
                    SkillId = Guid.Parse("4db2ba57-6f02-4c95-bf0a-f59af269fd3f"),
                    EffectId = Guid.Parse("25b2142f-ad42-4f4c-9c3e-855e465b28a6"),
                    TargetId = Guid.Parse("e21f9012-3037-4385-b0af-2d2eec3245b9")
                },
                //Whirling Axes || DealDamage 150 Physical || Enemy Amount 5 Area 1
                new SkillEffects
                {
                    SkillId = Guid.Parse("3a1a8de1-43b7-4dbe-861d-9c635e83df85"),
                    EffectId = Guid.Parse("64e1a36b-d705-468f-8bfd-58d60d01a9a8"),
                    TargetId = Guid.Parse("0faafc79-6a2c-4506-b68a-d5c9ce226bdc")
                },
                //Whirling Axes || Reduce Armor 10 || Enemy Amount 5 Area 1
                new SkillEffects
                {
                    SkillId = Guid.Parse("3a1a8de1-43b7-4dbe-861d-9c635e83df85"),
                    EffectId = Guid.Parse("04b17411-2761-465b-84cf-ac0e3589073d"),
                    TargetId = Guid.Parse("0faafc79-6a2c-4506-b68a-d5c9ce226bdc")
                }
                );
            #endregion

            #region SummonUnits
            modelBuilder.Entity<SummonUnit>().HasData(
                //Fearful Sigil
                new SummonUnit
                {
                    Id = Guid.Parse("27f53ca1-3a40-4462-961d-d860547d8417"),
                    Img = "FearfulSigil.jpg",
                    Name = "Fearful Sigil",
                    Mana = 1D,
                    Manaregen = 1D,
                    Health = 100D,
                    Damage = 1D,
                    DamageType = DamageType.Physical,
                    Armor = 5D,
                    HealthRegen = 25D,
                    Description = "",
                    Race = HeroRace.Spirit
                },

                //Nature's Attendant
                new SummonUnit
                {
                    Id = Guid.Parse("dedb8175-0d78-4644-9ec9-eb0a7b8315a4"),
                    Img = "Nature'sAttendant.jpg",
                    Name = "Nature's Attendant",
                    Mana = 1D,
                    Manaregen = 1D,
                    Health = 100D,
                    Damage = 1D,
                    DamageType = DamageType.Physical,
                    Armor = 5D,
                    HealthRegen = 25D,
                    Description = "",
                    Race = HeroRace.Wisp
                }
                );
            #endregion

            #region Users
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("caa41c5f-5325-40d0-984e-bb8a65603015"),
                    UserName = "BaldnessIsGrace",
                    FirstName = "Agent",
                    LastName = "FourtySeven",
                    Password = StringHasher.MD5Hash("silentAssasin!337"),
                    Role = UserRole.User,
                    CreationDate = DateTime.Now
                },
                new User
                {
                    Id = Guid.Parse("39bddd9e-f602-4f6f-8f33-22c11f867ed1"),
                    UserName = "AllHailTheKing",
                    FirstName = "Gaben",
                    LastName = "Newell",
                    Password = StringHasher.MD5Hash("BetweenTwo&Four"),
                    Role = UserRole.Admin,
                    CreationDate = DateTime.Now
                }
                ) ;
            #endregion
        }
    }
}
