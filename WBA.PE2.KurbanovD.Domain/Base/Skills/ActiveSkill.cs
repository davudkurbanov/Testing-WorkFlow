using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Domain.Base.Skills
{
   public class ActiveSkill : Skill
    {
        public double Manacost { get; set; }
        //public ActiveSkill(string name,int manacost,Effect effect) :base(name,effect,SkillSort.Active)
        //{
        //    Manacost = manacost;
        //}
        //public ActiveSkill(string name,int manacost, List<Effect> effects) : base(name, effects, SkillSort.Active)
        //{
        //    Manacost = manacost;
        //}
    }
}
