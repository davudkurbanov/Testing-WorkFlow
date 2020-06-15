using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Skills;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Description;

namespace WBA.PE2.KurbanovD.Domain.Repositories
{
    class HeroRepository
    {
        SkillRepository skillRepo;
        public HeroRepository()
        {
            skillRepo = new SkillRepository();
        }
        //public IEnumerable<Hero> GetHeroes()
        //{

        //    List<Hero> heroes = new List<Hero>
        //    {
        //    new Hero(3,"Shadow Fiend",300,50,HeroRace.Demon,HeroClass.Warlock) ,

        //    new Hero(3,"Juggernaut",600,50,HeroRace.Human,HeroClass.Warrior) ,

        //    new Hero(2,"Drow Ranger",300,30,HeroRace.Undead,HeroClass.Hunter) ,

        //    new Hero(2,"Queen Of Pain",300,50,HeroRace.Demon,HeroClass.Assasin) ,

        //    new Hero(2,"Chaos Knight",500,50,HeroRace.Demon,HeroClass.Knight) ,

        //    new Hero(1,"Crystal Maiden",300,35,HeroRace.Human,HeroClass.Mage) ,

        //    new Hero(2,"Lich",400,35,HeroRace.Undead,HeroClass.Mage) ,

        //    new Hero(1,"Dazzle",350,40,HeroRace.Troll,HeroClass.Healer),
            
        //    new Hero(1,"Tusk",500,75,HeroRace.Beast,HeroClass.Warrior),

        //    new Hero(1,"Enchantress",400,50,HeroRace.Beast,HeroClass.Healer),

        //    new Hero(2,"Bounty Hunter",400,75,HeroRace.Beast,HeroClass.Assasin),

        //    new Hero(3,"Troll Warlord",500,50,HeroRace.Troll,HeroClass.Warrior)
        //    };
        //    foreach (Hero hero in heroes)
        //    {
        //        skillRepo.AddSkillSetsToHeroes(hero);
        //        GetProperManaPool(hero);
        //        AddRaceBonuses(hero);
        //        //foreach (Skill skill in hero.SkillSet)
        //        //{
        //        //    DescriptionBuilder.GetEffectDescription(skill);
        //        //}
        //    }

        //    return heroes;
        //}
        public void GetProperManaPool(Hero hero)
        {
                //foreach (Skill skill in hero.SkillSet)
                //{
                //    if (skill is ActiveSkill)
                //    {
                //        ActiveSkill activeSkill = (ActiveSkill)skill;
                //        if (activeSkill.Manacost > hero.Mana)
                //            hero.Mana = activeSkill.Manacost;
                //    }
                //}
        }
        public void AddRaceBonuses(Hero hero)
        {
            hero.DamageType = DamageType.Physical;
            //switch (hero.Race)
            //{
            //    case HeroRace.Human:
            //        hero.SkillSet.Add(skillRepo.GetHumanRaceSkill());
            //        break;
            //    case HeroRace.Demon:
            //        hero.DamageType = DamageType.Pure;
            //        hero.SkillSet.Add(skillRepo.GetDemonRaceSkill(hero));
            //        break;
            //    case HeroRace.Orc:
            //        hero.SkillSet.Add(skillRepo.GetOrcRaceSkill());
            //        break;
            //    case HeroRace.Beast:
            //        hero.SkillSet.Add(skillRepo.GetBeastRaceSkill());
            //        break;
            //    case HeroRace.Undead:
            //        hero.SkillSet.Add(skillRepo.GetUndeadRaceSkill());
            //        break;
            //    case HeroRace.Troll:
            //        hero.SkillSet.Add(skillRepo.GetTrollRaceSkill());
            //        break;
            //    default:
            //        break;
            //}
        }


    }
}
