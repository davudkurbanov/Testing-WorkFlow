using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WBA.PE2.KurbanovD.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.InteropServices.WindowsRuntime;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class SearchController : Controller
    {
        [Route("Search")]
        public IActionResult Index()
        {

            return View();
        }

        [Route("Search/Hero")]
        public IActionResult HeroSearch()
        {
            var viewModel = new SearchHeroViewModel();
            return View(viewModel);
        }
        [Route("Search/Hero")]
        [HttpPost]
        public IActionResult HeroSearch(SearchHeroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string heroStat = viewModel.HeroStats[viewModel.HeroStat].Text;
                string value = viewModel.SearchValue;
                string statAmountType = viewModel.ValueTypes[viewModel.ValueType].Text;

                if (heroStat == HeroStats.Name.ToString() || heroStat == HeroStats.Class.ToString()
                    || heroStat == HeroStats.Race.ToString() || heroStat == HeroStats.DamageType.ToString())
                {
                    statAmountType = "Contains";
                    return new RedirectToActionResult("GetHeroByStats", "Heroes", new { heroStat, value, statAmountType });
                }
                else
                {
                    try
                    {
                        if (statAmountType == StatAmountType.Contains.ToString())
                        {
                            ModelState.AddModelError(nameof(viewModel.SearchValue), $"Bad search value! {heroStat} can not seach for value type \"Contains\"!");
                            return View(viewModel);
                        }
                        double testDouble = double.Parse(viewModel.SearchValue);
                        return new RedirectToActionResult("GetHeroByStats", "Heroes", new { heroStat, value, statAmountType });
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError(nameof(viewModel.SearchValue), $"Bad search value! {heroStat} can only be a number!");
                        return View(viewModel);
                    }
                }
            }
            else
                return View(viewModel);
        }
        [Route("Search/Skill")]
        public IActionResult SkillSearch()
        {
            var viewModel = new SearchSkillSearchViewModel();
            return View(viewModel);
        }
        [Route("Search/Skill")]
        [HttpPost]
        public IActionResult SkillSearch(SearchSkillSearchViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string skillStat = viewModel.SkillStats[viewModel.SkillStat].Text;
                string value = viewModel.Value;
                return new RedirectToActionResult("GetSkillsByStats", "Skill", new { skillStat, value });
            }
            else
                return View(viewModel);
        }
        [Route("Search/Race")]
        public IActionResult RaceSearch()
        {
            var viewModel = new SearchRaceViewModel();
            return View(viewModel);
        }
        [Route("Search/Race")]
        [HttpPost]
        public IActionResult RaceSearch(SearchRaceViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                string heroRace = viewModel.Races[viewModel.Race].Text;
                return new RedirectToActionResult("GetRace", "Race",new { heroRace });
            }
            else
                return View(viewModel);
        }
        [Route("Search/Class")]
        public IActionResult ClassSearch()
        {
            var viewModel = new SearchClassVIewModel();
            return View(viewModel);
        }
        [Route("Search/Class")]
        [HttpPost]
        public IActionResult ClassSearch(SearchClassVIewModel vIewModel)
        {
            if (ModelState.IsValid)
            {
                string heroClass = vIewModel.Classes[vIewModel.Class].Text;
                return new RedirectToActionResult("GetClass", "Class",new { heroClass });
            }
            else return View(vIewModel);
        }


    }
}