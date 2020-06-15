using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Targets;
using WBA.PE2.KurbanovD.Domain.Repositories;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
    public class CriticalHit : Effect
    {
        public double CriticalProcChance { get; set; }
        public double CriticalMultiplier { get; set; }
        public DamageType DamageType { get; set; }
        //public CriticalHit(double procChance,double multiplier,DamageType damageType)
        //    : base(EffectType.CriticalHit,TargetRepository.GetSingleEnemyHeroTarget())
        //{
        //    ProcChance = procChance;
        //    Multiplier = multiplier;
        //    DamageType = damageType;
        //}


    }
}
