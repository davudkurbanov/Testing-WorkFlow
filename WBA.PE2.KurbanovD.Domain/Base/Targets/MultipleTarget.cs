using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Targets
{
   public class MultipleTarget : Target
    {
        public int AmountOfTargets { get; set; }
        public int AreaOfEffect { get; set; }
        //public MultipleTarget(int amountOfTargets,int areaOfEffect,
        //    HeroTargetType heroTargetType) :base(TargetType.Multiple,heroTargetType)
        //{
        //    AmountOfTargets = amountOfTargets;
        //    AreaOfEffect = areaOfEffect;
        //}
    }
}
