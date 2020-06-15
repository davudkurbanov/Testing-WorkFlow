using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Units;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class SearchRaceViewModel
    {
        public int Race { get; set; }
        public List<SelectListItem> Races { get; set; }
        public SearchRaceViewModel()
        {
            Races = Enum.GetValues(typeof(HeroRace)).Cast<HeroRace>().Select(p => new SelectListItem
            {
                Text = p.ToString(),
                Value = ((int)p).ToString()
            }).ToList();
        }
    }
}
