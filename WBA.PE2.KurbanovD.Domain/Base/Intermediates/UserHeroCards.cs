using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Domain.Base.Intermediates
{
    public class UserHeroCards
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}
