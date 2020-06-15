using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
    public class Silence : Effect
    {
        public double SilenceDuration { get; set; }
        public EffectState EffectState { get; set; }
    //    public Silence(double silenceDuration,List<Target> targets) 
    //        : base(EffectType.Silence,targets)
    //    {
    //        SilenceDuration = silenceDuration;
    //    }
    //    public Silence(double silenceDuration,Target target)
    //: base(EffectType.Silence, target)
    //    {
    //        SilenceDuration = silenceDuration;
    //        EffectState = EffectState.Debuff;
    //    }
    }
}
