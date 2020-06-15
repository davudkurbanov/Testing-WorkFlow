using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Base.Skills;
using WBA.PE2.KurbanovD.Domain.Repositories;

namespace WBA.PE2.KurbanovD.Domain.Base.Units
{
   public class Hero : CardUnit
    {
        public int ActionPoints { get; set; }
        public HeroClass HeroClass { get; set; }
        public List<UserHeroCards> Users { get; set; }
    }
}
