using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Description;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
   public class Stun : Effect
    {
        public double StunDuration { get; set; }
        public EffectState EffectState { get; set; }

        //public Stun(double duration,List<Target> targets) : base(EffectType.Stun,targets)
        //{
        //    Duration = duration;
        //    EffectState = EffectState.Debuff;
        //}
        //public Stun(double duration, Target target) : base(EffectType.Stun, target)
        //{
        //    Duration = duration;
        //    EffectState = EffectState.Debuff;
        //}
    }
}
