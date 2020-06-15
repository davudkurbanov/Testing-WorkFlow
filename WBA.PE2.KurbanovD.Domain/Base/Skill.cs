using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;

namespace WBA.PE2.KurbanovD.Domain.Base
{
    public abstract class Skill : Card
    {
        public SkillSort Skillsort { get; set; }
        public List<SkillEffects> Effects { get; set; }
        public List<CardUnitSkills> CardUnits { get; set; }
        //public Skill(string name,Effect effect,SkillSort skillSort) :base(name)
        //{
        //    Effects = new List<Effect>
        //    {
        //        effect
        //    };
        //    Name = name;
        //    Skillsort = skillSort;
        //    Img = string.Concat(name.Where(p => !char.IsWhiteSpace(p))) + ".jpg";
        //}

        //public Skill(string name, List<Effect> effects,SkillSort skillSort) :base(name)
        //{
        //    Effects = effects;
        //    Name = name;
        //    Skillsort = skillSort;
        //    Img = string.Concat(name.Where(p => !char.IsWhiteSpace(p))) + ".jpg";
        //}
    }
}
