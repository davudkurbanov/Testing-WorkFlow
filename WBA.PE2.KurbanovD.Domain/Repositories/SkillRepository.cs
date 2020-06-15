using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Skills;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Domain.Repositories
{
    public class SkillRepository
    {
        //EffectRepository effectRepo;
        //public SkillRepository()
        //{
        //    effectRepo = new EffectRepository();
        //}
        //public Skill GetDemonRaceSkill(Hero hero)
        //{

        //    return new PassiveSkill("Demonic Attack", effectRepo.GetAmplify(AmplifyType.Damage, hero.Damage,
        //        TargetRepository.GetSelfTarget()));
        //}
        //public Skill GetHumanRaceSkill()
        //{
        //    return new PassiveSkill("Human Mind", new List<Effect>{ effectRepo.GetAmplify(AmplifyType.ManaRegen, 0.5D,
        //        TargetRepository.GetSelfTarget()), effectRepo.GetAmplify(AmplifyType.HealthRegen,15D,
        //        TargetRepository.GetSelfTarget()) });
        //}
        //public Skill GetOrcRaceSkill()
        //{
        //    return new PassiveSkill("Orc's Flesh",new List<Effect> {effectRepo.GetAmplify(AmplifyType.HealthRegen,50D,
        //        TargetRepository.GetSelfTarget()),effectRepo.GetAmplify(
        //            AmplifyType.Armor,20D,TargetRepository.GetSelfTarget()) });
        //}
        //public Skill GetBeastRaceSkill()
        //{
        //    return new PassiveSkill("Sharp Paw", effectRepo.GetAmplify(AmplifyType.Damage, 50D,
        //        TargetRepository.GetSelfTarget()));
        //}
        //public Skill GetUndeadRaceSkill()
        //{
        //    return new PassiveSkill("Bon Appetit", effectRepo.GetLifesteal(25));
        //}
        //public Skill GetTrollRaceSkill()
        //{
        //    return new PassiveSkill("Beautiful Inside",new List<Effect>{ effectRepo.GetAmplify(AmplifyType.HealthRegen, 20D,
        //        TargetRepository.GetSelfTarget()), effectRepo.GetAmplify(AmplifyType.Health,300,
        //        TargetRepository.GetSelfTarget()) });
        //}
        //public List<Skill> GetJuggernautSkillSet(Hero hero)
        //{
        //    return new List<Skill>
        //    {
        //        new PassiveSkill("Blade Dance",effectRepo.GetCriticalHit(30,2)),

        //        new ActiveSkill("Omnislash",5,effectRepo.GetDealDamage(hero.Damage * 3,DamageType.Physical,
        //        TargetRepository.GetSingleEnemyHeroTarget()))
        //    };
        //}
        //public List<Skill> GetShadowFiendSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Requiem Of Souls",5,effectRepo.GetDealDamage(150,DamageType.Magical,
        //        TargetRepository.GetMultipleEnemyHeroesTarget(99,15))),

        //        new PassiveSkill("Presence Of The Dark Lord",effectRepo.GetReduce(ReduceType.Armor,3,
        //        TargetRepository.GetMultipleEnemyHeroesTarget(99,15)))
        //    };
        //}
        //public List<Skill> GetDrowRangerSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new PassiveSkill("Marksmanship",effectRepo.GetCriticalHit(15,3,DamageType.Pure)),

        //        new ActiveSkill("Precision Aura",3,effectRepo.GetAmplify(AmplifyType.Damage,30,
        //        new List<Target>{TargetRepository.GetMultipleFriendlyHeroesTarget(99,3),
        //            TargetRepository.GetSelfTarget()}))
        //    };
        //}
        //public List<Skill> GetQueenOfPainSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Scream Of Pain",3,effectRepo.GetDealDamage(150,DamageType.Pure,
        //        TargetRepository.GetMultipleEnemyHeroesTarget(3,2))),

        //        new ActiveSkill("Shadow Strike",3,effectRepo.GetSilence(3,TargetRepository.GetSingleEnemyHeroTarget()))
        //    };
        //}
        //public List<Skill> GetChaosKnightSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Chaos Bolt",3,new List<Effect> {effectRepo.GetStun
        //        (3,TargetRepository.GetSingleEnemyHeroTarget()),
        //            effectRepo.GetDealDamage(100,DamageType.Magical,TargetRepository.GetSingleEnemyHeroTarget()) }),

        //        new PassiveSkill("Chaos Strike",new List<Effect> {effectRepo.GetCriticalHit(20,2.5D,DamageType.Pure)
        //        ,effectRepo.GetLifesteal(50)})

        //    };
        //}

        //public List<Skill> GetCrystalMaidenSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new PassiveSkill("Arcane Aura",effectRepo.GetAmplify(AmplifyType.ManaRegen,0.5,new List<Target>
        //        {TargetRepository.GetSelfTarget(),TargetRepository.GetMultipleFriendlyHeroesTarget(3,5) })),

        //        new ActiveSkill("Frostbite",3,new List<Effect> {effectRepo.GetDealDamage(150,
        //        DamageType.Magical,TargetRepository.GetSingleEnemyHeroTarget()),effectRepo.GetStun(2,
        //        TargetRepository.GetSingleEnemyHeroTarget()) })
        //    };
        //}
        //public List<Skill> GetLichSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Frost Armor",2,effectRepo.GetAmplify(AmplifyType.Armor,10,TargetRepository.GetSingleFriendlyHeroTarget())),

        //        new ActiveSkill("Chain Frost",5,effectRepo.GetDealDamage(150,DamageType.Magical,TargetRepository.GetMultipleEnemyHeroesTarget(5,3)))
        //    };
        //}
        //public List<Skill> GetDazzleSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Shadow Wave",5,effectRepo.GetHeal(150,TargetRepository.GetMultipleFriendlyHeroesTarget(5,5))),

        //        new PassiveSkill("Bad JuJu",effectRepo.GetReduce(ReduceType.Armor,3,TargetRepository.GetMultipleEnemyHeroesTarget(99,2)))
        //    };
        //}
        //public List<Skill> GetTuskSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Walrus Punch",3,effectRepo.GetCriticalHit(100,3)),

        //        new ActiveSkill("Fearful Sigil",2,effectRepo.GetSummon(1,SummonRepository.GetFearfulSigil(GetFearfulSigilSkill())))
        //    };

        //}
        //public Skill GetFearfulSigilSkill()
        //{
        //    return new PassiveSkill("Fearful aura", effectRepo.GetReduce(ReduceType.Damage, 25,
        //        TargetRepository.GetMultipleEnemyHeroesTarget(99, 2)));
        //}
        //public List<Skill> GetEnchantressSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Nature's Attendants",3,effectRepo.GetSummon(7,SummonRepository.GetWisp(GetWispSkill()))),

        //        new ActiveSkill("Enchant",2,effectRepo.GetStun(1,TargetRepository.GetSingleEnemyHeroTarget()))
        //    };
        //}
        //public Skill GetWispSkill()
        //{
        //    return new PassiveSkill("Heal Attendant", effectRepo.GetHeal(150, TargetRepository.GetSingleFriendlyHeroTarget()));
        //}
        //public List<Skill> GetBountyHunterSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("Shuriken Toss",3,effectRepo.GetDealDamage(200,DamageType.Physical,
        //        TargetRepository.GetSingleEnemyHeroTarget())),

        //        new PassiveSkill("Jinada",effectRepo.GetCriticalHit(30,2.5))
        //    };
        //}
        //public List<Skill> GetTrollWarlordSkillSet()
        //{
        //    return new List<Skill>
        //    {
        //        new ActiveSkill("BattleTrance",5,new List<Effect>{effectRepo.GetLifesteal(50),
        //            effectRepo.GetAmplify(AmplifyType.Damage,50,TargetRepository.GetSelfTarget()) }),

        //        new ActiveSkill("Whirling Axes",3,effectRepo.GetDealDamage(150,DamageType.Physical,
        //        TargetRepository.GetMultipleEnemyHeroesTarget(99,1)))

        //    };
        //}
        public void AddSkillSetsToHeroes(Hero hero)
        {
            //switch (hero.Name)
            //{
            //    case "Shadow Fiend":
            //        hero.SkillSet = GetShadowFiendSkillSet();
            //        break;
            //    case "Juggernaut":
            //        hero.SkillSet = GetJuggernautSkillSet(hero);
            //        break;
            //    case "Drow Ranger":
            //        hero.SkillSet = GetDrowRangerSkillSet();
            //        break;
            //    case "Queen Of Pain":
            //        hero.SkillSet = GetQueenOfPainSkillSet();
            //        break;
            //    case "Chaos Knight":
            //        hero.SkillSet = GetChaosKnightSkillSet();
            //        break;
            //    case "Crystal Maiden":
            //        hero.SkillSet = GetCrystalMaidenSkillSet();
            //        break;
            //    case "Lich":
            //        hero.SkillSet = GetLichSkillSet();
            //        break;
            //    case "Dazzle":
            //        hero.SkillSet = GetDazzleSkillSet();
            //        break;
            //    case "Tusk":
            //        hero.SkillSet = GetTuskSkillSet();
            //        break;
            //    case "Enchantress":
            //        hero.SkillSet = GetEnchantressSkillSet();
            //        break;
            //    case "Bounty Hunter":
            //        hero.SkillSet = GetBountyHunterSkillSet();
            //        break;
            //    case "Troll Warlord":
            //        hero.SkillSet = GetTrollWarlordSkillSet();
            //        break;
            //}
        }
    }
}

