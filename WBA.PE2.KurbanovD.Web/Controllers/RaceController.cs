using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Description;
using WBA.PE2.KurbanovD.Domain.Repositories;
using WBA.PE2.KurbanovD.Web.Data;
using WBA.PE2.KurbanovD.Web.Services;
using WBA.PE2.KurbanovD.Web.ViewModels;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class RaceController : Controller
    {
        private CardGameService cardGameService;
        private readonly CardGameContext context;

        public RaceController(CardGameContext context)
        {
            this.context = context;
            cardGameService = new CardGameService(this.context);
        }
        [Route("/Races/{heroRace}")]
        public async Task<IActionResult> GetRace(HeroRace heroRace)
        {
            var viewModel = new RaceGetRaceByNameViewModel();
            viewModel.Race = heroRace;
            viewModel.Heroes = await cardGameService.GetHeroesByStats(HeroStats.Race,heroRace.ToString());
            viewModel.RaceDescription = DescriptionBuilder.GetHeroRaceDescription(heroRace);
            return View(viewModel);
        }
        [Route("Races")]
        public IActionResult GetAllRaces()
        {
            var viewModel = new RaceGetAllRacesViewModel();
            viewModel.HeroRaces = cardGameService.GetAllRaces();
            return View(viewModel);
        }
    }
}