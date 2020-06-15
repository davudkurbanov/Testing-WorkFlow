using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Effects;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Repositories;
using WBA.PE2.KurbanovD.Web.Data;
using WBA.PE2.KurbanovD.Web.Services;
using WBA.PE2.KurbanovD.Web.ViewModels;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class SkillController : Controller
    {
        private CardGameService cardGameService;
        private readonly CardGameContext context;

        public SkillController(CardGameContext context)
        {
            this.context = context;
            cardGameService = new CardGameService(this.context);
        }
        [Route("Skills")]
        public async Task<IActionResult> GetAllSkills()
        {
            var allSkills = await cardGameService.GetAllSkills();
            var viewModel = new SkillGetAllSkillsViewModel()
            {
                Skills = allSkills
            };
            return View(viewModel);
        }
        [Route("Skills/{skillStat}/{value}")]
        public async Task<IActionResult> GetSkillsByStats(SkillStats skillStat,string value)
        {
            var viewModel = new SkillsGetSkillsByStatsViewModel();
            viewModel.Skills = await cardGameService.GetSkillsByStats(skillStat, value);
            viewModel.SearchStat = skillStat;
            viewModel.SearchValue = value;
            return View(viewModel);
        }
        [Route("Skills/{id}")]
        public async Task<IActionResult> GetSkill(Guid id)
        {
            var getSkill = await cardGameService.GetSkillById(id);
            if (getSkill == null)
                return NotFound();
            var heroesWithSkill = await cardGameService.GetHeroesBySkill(getSkill);
            var viewModel = new SkillGetSkillViewModel()
            {
                Skill = getSkill,
                HeroesWithSkill = heroesWithSkill
            };
            return View(viewModel);
        }
    }
}