using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class SearchSkillSearchViewModel
    {
        public List<SelectListItem> SkillStats { get; set; }
        [Display(Name = "Choose an attribute to search for")]
        public int SkillStat { get; set; }

        public string Value { get; set; }
        public SearchSkillSearchViewModel()
        {
            SkillStats = Enum.GetValues(typeof(SkillStats)).Cast<SkillStats>().Select(p => new SelectListItem
            {
                Text = p.ToString(),
                Value = ((int)p).ToString()
            }).ToList();
        }
    }
}
