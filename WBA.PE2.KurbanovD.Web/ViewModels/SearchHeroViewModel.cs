using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class SearchHeroViewModel
    {
        public List<SelectListItem> HeroStats { get; set; }
        public List<SelectListItem> ValueTypes { get; set; }

        [Required]
        [Display(Name = "Hero Attributes")]
        public int HeroStat { get; set; }
        public int ValueType { get; set; }
        [Required]
        [Display(Name = "Value of attribute")]
        public string SearchValue { get; set; }
        public SearchHeroViewModel()
        {
            HeroStats = Enum.GetValues(typeof(HeroStats)).Cast<HeroStats>().Select(p => new SelectListItem
            {
                Text = p.ToString(),
                Value = ((int)p).ToString()
            }).ToList();
            ValueTypes = Enum.GetValues(typeof(StatAmountType)).Cast<StatAmountType>().Select(p => new SelectListItem
            {
                Text = p.ToString(),
                Value = ((int)p).ToString()
            }).ToList();

        }
    }
}
