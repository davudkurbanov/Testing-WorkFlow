using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class UsersDetailsViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public List<UserHeroCards> HeroCards { get; set; }
        public UsersDetailsViewModel()
        {
            HeroCards = new List<UserHeroCards>();
        }
    }
}
