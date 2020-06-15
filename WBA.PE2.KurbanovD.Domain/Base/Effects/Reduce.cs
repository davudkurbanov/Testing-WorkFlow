using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
    public class Reduce : Effect
    {
        public ReduceType ReduceType { get; set; }
        public EffectState EffectState { get; set; }
        public double ReduceAmount { get; set; }
        //public Reduce(ReduceType reduceType, double amount, Target target) : base(EffectType.Reduce, target)
        //{
        //    Type = reduceType;
        //    EffectState = EffectState.Debuff;
        //    Amount = amount;
        //}
        //public Reduce(ReduceType reduceType, double amount, List<Target> targets) : base(EffectType.Reduce, targets)
        //{
        //    Type = reduceType;
        //    EffectState = EffectState.Debuff;
        //    Amount = amount;
        //}
    }
}
