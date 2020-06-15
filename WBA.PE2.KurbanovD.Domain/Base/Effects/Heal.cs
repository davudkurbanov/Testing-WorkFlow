using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
    public class Heal : Effect
    {
        public double HealAmount { get; set; }
        //public Heal(double amount,Target target) :base(EffectType.Heal,target)
        //{
        //    Amount = amount;
        //}
        //public Heal(double amount, List<Target> targets) : base(EffectType.Heal, targets)
        //{
        //    Amount = amount;
        //}
    }
}
