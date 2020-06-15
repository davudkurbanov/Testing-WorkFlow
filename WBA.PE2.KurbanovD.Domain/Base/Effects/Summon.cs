using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Targets;
using WBA.PE2.KurbanovD.Domain.Repositories;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
    public class Summon : Effect
    {
        public int AmountToSummon { get; set; }
        public SummonUnit SummonUnit { get; set; }
        //public Summon(int amount,SummonUnit summonUnit) : base(EffectType.Summon,TargetRepository.GetSelfTarget())
        //{
        //    Amount = amount;
        //    SummonUnit = summonUnit;
        //}

    }
}
