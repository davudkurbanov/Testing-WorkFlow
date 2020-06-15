using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;

namespace WBA.PE2.KurbanovD.Domain.Base
{
   public abstract class Effect
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public EffectType EffectType { get; set; }
        //public List<EffectTargets> Targets { get; set; }
        public List<SkillEffects> Skills { get; set; }
        //public Effect()
        //{

        //}
        //public Effect(EffectType effectType,List<Target> targets)
        //{
        //    EffectType = effectType;
        //    //Targets = targets;
        //}
        //public Effect(EffectType effectType,Target target)
        //{
        //    EffectType = effectType;
        //    //Targets = new List<Target>
        //    //{
        //    //    target
        //    //};
        //}
        //public void SetDescription(string description)
        //{
        //    this.Description = description;
        //}
    }
}
