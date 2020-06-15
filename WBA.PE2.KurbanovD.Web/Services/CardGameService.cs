using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Web.Data;

namespace WBA.PE2.KurbanovD.Web.Services
{
    public class CardGameService
    {
        private CardGameContext context;
        public CardGameService(CardGameContext cardGameContext)
        {
            context = cardGameContext;
        }

        #region Race&Class
        public List<HeroRace> GetAllRaces()
        {
            return Enum.GetValues(typeof(HeroRace)).Cast<HeroRace>().ToList();
        }
        #endregion

        #region Heroes
        public async Task<List<Hero>> GetAllHeroes()
        {
            return await context.Heroes.Include(h => h.SkillSet).ThenInclude(cus => cus.Skill)
                .ThenInclude(s => s.Effects).ThenInclude(se => se.Effect).Include(h => h.SkillSet)
                .ThenInclude(cus => cus.Skill).ThenInclude(s => s.Effects).ThenInclude(se => se.Target).ToListAsync();
        }
        public async Task<Hero> GetHeroById(Guid id)
        {
            return (await GetAllHeroes()).SingleOrDefault(h => h.Id == id);
        }
        public async Task<List<Hero>> GetHeroesByStats(HeroStats statsName, string value, StatAmountType statAmountType = StatAmountType.Exact)
        {
            switch (statsName)
            {
                case HeroStats.Name:
                    return await GetHeroesByNameContains(value);
                case HeroStats.DamageType:
                    return await GetHeroesByDamageType(value);
                case HeroStats.Race:
                    return await GetHeroesByRace(value);
                case HeroStats.Class:
                    return await GetHeroesByClass(value);
            }
            if (value.Contains("."))
                value = value.Replace(".", ",");
            double amount;
            try
            {
                amount = double.Parse(value);
            }
            catch (Exception)
            {
                throw new Exception($"Invalid format for \"{value}\" for \"{statsName}\" searchtype ");
            }

            switch (statsName)
            {
                case HeroStats.Health:
                    return await GetHeroesByHealth(amount, statAmountType);
                case HeroStats.HealthRegen:
                    return await GetHeroesByHealthRegen(amount, statAmountType);
                case HeroStats.Mana:
                    return await GetHeroesByMana(amount, statAmountType);
                case HeroStats.ManaRegen:
                    return await GetHeroesByManaRegen(amount, statAmountType);
                case HeroStats.Armor:
                    return await GetHeroesByArmor(amount, statAmountType);
                case HeroStats.Damage:
                    return await GetHeroesByDamage(amount, statAmountType);
                case HeroStats.ActionPoints:
                    return await GetHeroesByActionPoints(amount, statAmountType);
                default:
                    return null;
            }
        }
        private async Task<List<Hero>> GetHeroesByRace(string race)
        {
            return (await GetAllHeroes()).Where(h => h.Race.ToString().ToLower().Contains(race.ToLower())).ToList();
        }
        public List<string> GetAllHeroImagesString()
        {
            return new List<string>
            {
                "BountyHunter.jpg",
                "ChaosKnight.jpg",
                "CrystalMaiden.jpg",
                "Dazzle.jpg",
                "DrowRanger.jpg",
                "Enchantress.jpg",
                "Juggernaut.jpg",
                "Lich.jpg",
                "QueenOfPain.jpg",
                "ShadowFiend.jpg",
                "TrollWarlord.jpg",
                "Tusk.jpg"
            };
        }
        private async Task<List<Hero>> GetHeroesByHealth(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.Health == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.Health >= amount).ToList();
            else 
                return (await GetAllHeroes()).Where(h => h.Health <= amount).ToList();
        }
        private async Task<List<Hero>> GetHeroesByDamage(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.Damage == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.Damage >= amount).ToList();
            else
                return (await GetAllHeroes()).Where(h => h.Damage <= amount).ToList();
        }
        private async Task<List<Hero>> GetHeroesByMana(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.Mana == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.Mana >= amount).ToList();
            else
                return (await GetAllHeroes()).Where(h => h.Mana <= amount).ToList();
        }
        private async Task<List<Hero>> GetHeroesByHealthRegen(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.HealthRegen == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.HealthRegen >= amount).ToList();
            else
                return (await GetAllHeroes()).Where(h => h.HealthRegen <= amount).ToList();
        }
        private async Task<List<Hero>> GetHeroesByManaRegen(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.Manaregen == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.Manaregen >= amount).ToList();
            else
                return (await GetAllHeroes()).Where(h => h.Manaregen <= amount).ToList();
        }
        private async Task<List<Hero>> GetHeroesByArmor(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.Armor == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.Armor >= amount).ToList();
            else
                return (await GetAllHeroes()).Where(h => h.Armor <= amount).ToList();
        }
        private async Task<List<Hero>> GetHeroesByNameContains(string name)
        {
            return (await GetAllHeroes()).Where(h => h.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        public async Task<List<Hero>> GetHeroesBySkill(Skill skillToMatch)
        {
            return (await GetAllHeroes()).Where(h => h.SkillSet.Select(cus => cus.SkillId).Contains(skillToMatch.Id)).ToList();
        }
        private async Task<List<Hero>> GetHeroesByClass(string heroClass)
        {
            return (await GetAllHeroes()).Where(h => h.HeroClass.ToString().ToLower().Contains(heroClass.ToLower())).ToList();
        }
        private async Task<List<Hero>> GetHeroesByDamageType(string type)
        {
            return (await GetAllHeroes()).Where(h => h.DamageType.ToString().ToLower() == type.ToLower()).ToList();
        }
        private async Task<List<Hero>> GetHeroesByActionPoints(double amount, StatAmountType statAmountType)
        {
            if (statAmountType == StatAmountType.Exact)
                return (await GetAllHeroes()).Where(h => h.ActionPoints == amount).ToList();
            else if (statAmountType == StatAmountType.Above)
                return (await GetAllHeroes()).Where(h => h.ActionPoints >= amount).ToList();
            else
                return (await GetAllHeroes()).Where(h => h.ActionPoints <= amount).ToList();
        }
        #endregion

        #region Skills
        public async Task<List<Skill>> GetAllSkills()
        {
            return await context.Skills.Include(s => s.Effects).ThenInclude(se => se.Effect)
                .Include(s => s.Effects).ThenInclude(se => se.Target).ToListAsync();
        }
        public async Task<List<Skill>> GetSkillsByStats(SkillStats skillStat, string value)
        {
            switch (skillStat)
            {
                case SkillStats.Type:
                    return await GetSkillsBySkillTypeContains(value);
                case SkillStats.Name:
                    return await GetSkillsByNameContains(value);
                case SkillStats.Effect:
                    return await GetSkillsByEffectTypeContains(value);
                default:
                    return null;
            }
        }
        public async Task<List<Skill>> GetSkillsByEffectTypeContains(string effectType)
        {
            return (await GetAllSkills()).Where(s => s.Effects.Select(se => se.Effect.EffectType).ToString().ToLower().Contains(effectType.ToLower())).ToList();
        }
        public async Task<List<Skill>> GetSkillsByNameContains(string name)
        {
            return (await GetAllSkills()).Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        public async Task<List<Skill>> GetSkillsBySkillTypeContains(string skillSort)
        {
            return (await GetAllSkills()).Where(s => s.Skillsort.ToString().ToLower().Contains(skillSort.ToLower())).ToList();
        }
        public async Task<Skill> GetSkillById(Guid id)
        {
            return (await GetAllSkills()).SingleOrDefault(s => s.Id == id); 
        }
        #endregion;

        #region User
        public async Task<List<User>> GetAllUsers()
        {
            return await context.Users.Include(u => u.HeroCards).ThenInclude(uhc => uhc.Hero).
                ThenInclude(h => h.SkillSet).ThenInclude(cus => cus.Skill).ThenInclude(s => s.Effects)
                .ThenInclude(se => se.Effect).ThenInclude(e => e.Skills).ThenInclude(se => se.Target).ToListAsync();
        }
        #endregion
    }
}
