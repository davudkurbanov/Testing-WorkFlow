using System;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Domain.Base.Intermediates
{
    public class CardUnitSkills
    {
        public Guid CardUnitId { get; set; }
        public CardUnit CardUnit { get; set; }
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
