using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class ClassGetClassViewModel
    {
        public HeroClass Class { get; set; }
        public List<Hero> Heroes { get; set; }
        public string ClassDescription { get; set; }
    }
}
