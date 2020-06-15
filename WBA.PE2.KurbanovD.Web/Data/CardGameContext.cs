using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Effects;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Base.Skills;
using WBA.PE2.KurbanovD.Domain.Base.Targets;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Web.Data
{
    public class CardGameContext : DbContext
    {
        public CardGameContext(DbContextOptions<CardGameContext> options) : base(options)
        {

        }
        #region DbSet's
        public DbSet<ActiveSkill> ActiveSkills { get; set; }
        public DbSet<Amplify> Amplifies { get; set; }
        public DbSet<CardUnit> CardUnits { get; set; }
        public DbSet<CriticalHit> CriticalHits { get; set; }
        public DbSet<DealDamage> DealDamages { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Heal> Heals { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroItem> HeroItems { get; set; }
        public DbSet<CardUnitSkills> SkillSets { get; set; }
        public DbSet<Lifesteal> Lifesteals { get; set; }
        public DbSet<MultipleTarget> MultipleTargets { get; set; }
        public DbSet<PassiveSkill> PassiveSkills { get; set; }
        public DbSet<Reduce> Reduces { get; set; }
        public DbSet<Silence> Silences { get; set; }
        public DbSet<SingleTarget> SingleTargets { get; set; }
        public DbSet<SkillEffects> SkillEffects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Stun> Stuns { get; set; }
        public DbSet<Summon> Summons { get; set; }
        public DbSet<Target> Targets { get; set; }
        public DbSet<UserHeroCards> UserHeroCards { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region CardUnits
            modelBuilder.Entity<CardUnit>()
                .HasKey(cu => cu.Id);
            #endregion

            #region Effects
            modelBuilder.Entity<Effect>()
                .HasKey(e => e.Id);
            #endregion

            #region HeroItems 
            modelBuilder.Entity<HeroItem>()
                .HasKey(hi => hi.Id);
            #endregion

            #region HeroSkills
            modelBuilder.Entity<CardUnitSkills>()
                .HasKey(hs => new { hs.CardUnitId, hs.SkillId });

            modelBuilder.Entity<CardUnitSkills>()
                .HasOne(cus => cus.CardUnit)
                .WithMany(cu => cu.SkillSet)
                .HasForeignKey(cus => cus.CardUnitId);

            modelBuilder.Entity<CardUnitSkills>()
                .HasOne(hs => hs.Skill)
                .WithMany(s => s.CardUnits)
                .HasForeignKey(hs => hs.SkillId);
            #endregion

            #region SkillEffects
            modelBuilder.Entity<SkillEffects>()
                .HasKey(se => new { se.SkillId, se.EffectId, se.TargetId });

            modelBuilder.Entity<SkillEffects>()
                .HasOne(se => se.Skill)
                .WithMany(s => s.Effects)
                .HasForeignKey(se => se.SkillId);

            modelBuilder.Entity<SkillEffects>()
                .HasOne(se => se.Effect)
                .WithMany(e => e.Skills)
                .HasForeignKey(se => se.EffectId);
            modelBuilder.Entity<SkillEffects>()
                .HasOne(se => se.Target)
                .WithMany(t => t.SkillEffects);

            #endregion

            #region Skills
            modelBuilder.Entity<Skill>()
                .HasKey(s => s.Id);
            #endregion

            #region Targets
            modelBuilder.Entity<Target>()
                .HasKey(t => t.Id);
            #endregion

            #region UserHeroCards
            modelBuilder.Entity<UserHeroCards>()
                .HasKey(usc => new {usc.UserId, usc.HeroId});

            modelBuilder.Entity<UserHeroCards>()
                .HasOne(uhc => uhc.User)
                .WithMany(u => u.HeroCards)
                .HasForeignKey(uhc => uhc.UserId);

            modelBuilder.Entity<UserHeroCards>()
                .HasOne(uhc => uhc.Hero)
                .WithMany(h => h.Users)
                .HasForeignKey(uhc => uhc.HeroId);
            #endregion

            #region Users
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            #endregion

            DataSeeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }


    }
}
