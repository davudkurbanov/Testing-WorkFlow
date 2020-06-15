using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Repositories;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class HeroesGetHeroByStatsViewModel
    {
        public string Value { get; set; }
        public HeroStats StatsName { get; set; }
        public StatAmountType StatAmountType { get; set; }
        public List<Hero> Heroes { get; set; }
    }
}
