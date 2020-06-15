using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class HeroesGetHeroViewModel
    {
        public Hero Hero { get; set; }
        public List<Hero> SimilarRaceHeroes { get; set; }
        public List<Hero> SimilarClassHeroes { get; set; }
    }
}
