using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class SkillGetSkillViewModel
    {
        public Skill Skill { get; set; }
        public List<Hero> HeroesWithSkill { get; set; }
    }
}
