using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class RaceGetRaceByNameViewModel
    {
        public HeroRace Race { get; set; }
        public List<Hero> Heroes { get; set; }
        public string RaceDescription { get; set; }
    }
}
