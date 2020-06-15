using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using WBA.PE2.KurbanovD.Domain.Base.Enums;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class SearchClassVIewModel
    {
        public int Class { get; set; }
        public List<SelectListItem> Classes { get; set; }
        public SearchClassVIewModel()
        {
            Classes = Enum.GetValues(typeof(HeroClass)).Cast<HeroClass>().Select(p => new SelectListItem
            {
                Text = p.ToString(),
                Value = ((int)p).ToString()
            }).ToList();
        }
    }
}
