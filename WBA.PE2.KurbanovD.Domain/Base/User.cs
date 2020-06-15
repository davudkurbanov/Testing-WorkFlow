using System;
using System.Collections.Generic;
using System.Text;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;

namespace WBA.PE2.KurbanovD.Domain.Base
{
   public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public List<UserHeroCards> HeroCards { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid AuthenticationToken { get; set; }
    }
}
