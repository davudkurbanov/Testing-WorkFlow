using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Repositories;

namespace WBA.PE2.KurbanovD.Domain.Base.Effects
{
   public class Lifesteal : Effect
    {
        public double LifeStealPercentage { get; set; }
        //public Lifesteal(double percentage) : base(EffectType.LifeSteal,TargetRepository.GetSelfTarget())
        //{
        //    Percentage = percentage;
        //}
    }
}
