using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
   public class DealDamage : Effect
    {
        public double DamageAmount { get; set; }
        public DamageType DamageType { get; set; }
        //public DealDamage(double amount,DamageType damageType,List<Target> targets) : base(EffectType.DealDamage,targets)
        //{
        //    Amount = amount;
        //    DamageType = damageType;
        //}
        //public DealDamage(double amount, DamageType damageType, Target target) : base(EffectType.DealDamage, target)
        //{
        //    Amount = amount;
        //    DamageType = damageType;
        //}
    }
}
