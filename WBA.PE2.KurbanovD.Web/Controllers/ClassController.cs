using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Description;
using WBA.PE2.KurbanovD.Domain.Repositories;
using WBA.PE2.KurbanovD.Web.Data;
using WBA.PE2.KurbanovD.Web.Services;
using WBA.PE2.KurbanovD.Web.ViewModels;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class ClassController : Controller
    {
        private CardGameService cardGameService;
        private readonly CardGameContext context;

        public ClassController(CardGameContext context)
        {
            this.context = context;
            cardGameService = new CardGameService(this.context);
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("HeroClasses/{heroClass}")]
        public async Task<IActionResult> GetClass(HeroClass heroClass)
        {
            var viewModel = new ClassGetClassViewModel();
            viewModel.Class = heroClass;
            viewModel.Heroes = await cardGameService.GetHeroesByStats(HeroStats.Class, heroClass.ToString());
            viewModel.ClassDescription = DescriptionBuilder.GetHeroClassDescription(heroClass);
            return View(viewModel);
        }
        [Route("HeroClasses")]
        public IActionResult GetAllClasses()
        {
            var viewModel = new ClassGetAllClassesViewModel();
            viewModel.HeroClasses = Enum.GetValues(typeof(HeroClass)).Cast<HeroClass>().ToList();
            return View(viewModel);
        }
    }
}