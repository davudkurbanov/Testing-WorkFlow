using System;

namespace WBA.PE2.KurbanovD.Domain.Base.Intermediates
{
    public class SkillEffects
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
        public Guid EffectId { get; set; }
        public Effect Effect { get; set; }
        public Guid TargetId { get; set; }
        public Target Target { get; set; }
    }
}
