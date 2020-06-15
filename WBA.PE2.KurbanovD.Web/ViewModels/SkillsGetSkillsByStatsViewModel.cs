using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class SkillsGetSkillsByStatsViewModel
    {
        public List<Skill> Skills { get; set; }
        public SkillStats SearchStat { get; set; }
        public string SearchValue { get; set; }
    }
}
