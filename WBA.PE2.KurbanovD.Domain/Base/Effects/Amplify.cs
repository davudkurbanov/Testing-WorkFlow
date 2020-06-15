using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
    public class Amplify : Effect
    {
        public AmplifyType AmplifyType { get; set; }
        public EffectState EffectState { get; set; }
        public double Amount { get; set; }
        //public Amplify(AmplifyType amplifyType,double amount,Target target) :base(EffectType.Amplify,target)
        //{
        //    Type = amplifyType;
        //    EffectState = EffectState.Buff;
        //    Amount = amount;
        //}
        //public Amplify(AmplifyType amplifyType, double amount, List<Target> targets) : base(EffectType.Amplify, targets)
        //{
        //    Type = amplifyType;
        //    EffectState = EffectState.Buff;
        //    Amount = amount;
        //}
    }
}
