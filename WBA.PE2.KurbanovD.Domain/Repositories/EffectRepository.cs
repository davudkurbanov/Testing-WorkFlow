using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Effects;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Targets;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Description;

namespace WBA.PE2.KurbanovD.Domain.Repositories
{
    //public class EffectRepository
    //{
    //    public Amplify GetAmplify(AmplifyType amplifyType, double amount, Target target)
    //    {
    //        return new Amplify(amplifyType, amount, target);
    //    }
    //    public Amplify GetAmplify(AmplifyType amplifyType, double amount, List<Target> targets)
    //    {
    //        return new Amplify(amplifyType, amount, targets);
    //    }
    //    public Reduce GetReduce(ReduceType reduceType, double amount, Target target)
    //    {
    //        return new Reduce(reduceType, amount, target);
    //    }
    //    public Reduce GetReduce(ReduceType reduceType, double amount, List<Target> targets)
    //    {
    //        return new Reduce(reduceType, amount, targets);
    //    }
    //    public Effect GetHeal(double amount, Target target)
    //    {
    //        return new Heal(amount, target);
    //    }
    //    public Effect GetHeal(double amount, List<Target> targets)
    //    {
    //        return new Heal(amount, targets);
    //    }
    //    public DealDamage GetDealDamage(double amount, DamageType damageType, Target target)
    //    {
    //        return new DealDamage(amount, damageType, target);
    //    }
    //    public DealDamage GetDealDamage(double amount, DamageType damageType, List<Target> targets)
    //    {
    //        return new DealDamage(amount, damageType, targets);
    //    }
    //    public Effect GetSilence(double duration, Target target)
    //    {
    //        return new Silence(duration, target);
    //    }
    //    public Effect GetSummon(int amount, SummonUnit summon)
    //    {
    //        return new Summon(amount, summon);
    //    }
    //    public CriticalHit GetCriticalHit(double procChance, double multiplier, DamageType damageType = DamageType.Physical)
    //    {
    //        return new CriticalHit(procChance, multiplier, damageType);
    //    }
    //    public Lifesteal GetLifesteal(double percentage)
    //    {
    //        return new Lifesteal(percentage);
    //    }
    //    public Stun GetStun(int duration, List<Target> targets)
    //    {
    //        return new Stun(duration, targets);
    //    }
    //    public Stun GetStun(int duration, Target target)
    //    {
    //        return new Stun(duration, target);
    //    }

    //}
}
