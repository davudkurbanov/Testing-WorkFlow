using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;

namespace WBA.PE2.KurbanovD.Domain.Base
{
    public class Target
    {
        public Guid Id { get; set; }
        public TargetType TargetType { get; set; }
        public HeroTargetType HeroTargetType{ get; set; }
        public List<SkillEffects> SkillEffects { get; set; }
        //public List<EffectTargets> Effects { get; set; }
        //public Target(TargetType targetType,HeroTargetType heroTargetType)
        //{
        //    TargetType = targetType;
        //    HeroTargetType = heroTargetType;
        //}
    }
}
