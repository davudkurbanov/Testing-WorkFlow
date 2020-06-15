using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Effects;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Base.Targets;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Domain.Description
{
    public class DescriptionBuilder
    {
        public static void GetEffectDescription(Skill skill)
        {
            foreach (SkillEffects skillEffects in skill.Effects)
            {
                switch (skillEffects.Effect.EffectType)
                {
                    case EffectType.Amplify:
                        skillEffects.Effect.Description = "Amplifies [hero attribute(s)] by [Amount].";
                        break;
                    case EffectType.Heal:
                        skillEffects.Effect.Description = "Restore [target(s)] health by [Amount].";
                        break;
                    case EffectType.DealDamage:
                        skillEffects.Effect.Description = "Deal [Amount] of [DamageType] damage.";
                        break;
                    case EffectType.Silence:
                        skillEffects.Effect.Description = "Target cannot use spells for [Amount] gameticks.";
                        break;
                    case EffectType.Summon:
                        skillEffects.Effect.Description = "Summons [Amount] [Summon Unit(s)] near caster.";
                        break;
                    case EffectType.LifeSteal:
                        skillEffects.Effect.Description = "Restore [percentage] of dealt attack damage as health to hero'/";
                        break;
                    case EffectType.Stun:
                        skillEffects.Effect.Description = "Stuns (disables unit) for [Amount] of game ticks.";
                        break;
                    case EffectType.Reduce:
                        skillEffects.Effect.Description = "Reduces [hero attribute] by [Amount].";
                        break;
                    case EffectType.CriticalHit:
                        skillEffects.Effect.Description = "For each attack hero has [Amount]% chance to hit critical hit" +
                            ",that does [multiplier]x damage to enemy hero";
                            break;

                }
            }
        }
        public static string GetHeroRaceDescription(HeroRace heroRace)
        {
            switch (heroRace)
            {
                case HeroRace.Human:
                    return "Humans get \"Human mind\" skill. That amplifies their ManaRegen and HealthRegen.";
                case HeroRace.Demon:
                    return "Demons get \"Demonic Attack\" skill. This skill doubles attack damage of a Demon. A Demon has" +
                        "gets also a Pure attack damage type.";
                case HeroRace.Orc:
                    return "Orcs get \"Orc's Flesh\" skill. Their HealthRegen and Armor are amplified";
                case HeroRace.Beast:
                    return "Beast get \"Sharp Paw\" skill. This skill amplifies damage of a beast.";
                case HeroRace.Undead:
                    return "Undead get \"Bon Appetite\" skill, that restores them their Health, by percentage of dealt Attack Damage. ";
                default:
                    return "Troll get \"Beautiful Inside\" skill, that amplifies their Health and HealthRegen";
            }
        }
        public static string GetHeroClassDescription(HeroClass heroClass) 
        {
            switch (heroClass)
            {
                case HeroClass.Hunter:
                    return "Hunters are 2nd row units. They are very weak face to face, so keep distance please!";
                case HeroClass.Warrior:
                    return "Warriors are very strong units in a battle. They are born to fight! Made of steal! The Real Power!";
                case HeroClass.Warlock:
                    return "Warlocks are very powerful spellcasters. They need their time," +
                        " sometimes it can be worth waiting! Sometimes!";
                case HeroClass.Necromancer:
                    return "Necromancers play with the death. Better not to get in their way!";
                case HeroClass.Assasin:
                    return "Assasins are real killing machines! \"Kill,sleep,get gold,repeat.\"is their moto. ";
                case HeroClass.Knight:
                    return "Knights are most honored fighters, riding on a horse (mostly) on a sunny beach. Just gorgeous!";
                case HeroClass.Mage:
                    return "Where others using their weapon and combat skills,Mages use their spells, pew pew pew, BOOM!";
                default:
                   return "Healers are unmissable in a battle. They are the only ones that have healing spells!";
            }
        }

    }
}
