using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Base.Skills;
using WBA.PE2.KurbanovD.Domain.Base.Units;
using WBA.PE2.KurbanovD.Domain.Repositories;
using WBA.PE2.KurbanovD.Web.Constants;
using WBA.PE2.KurbanovD.Web.Data;
using WBA.PE2.KurbanovD.Web.Services;
using WBA.PE2.KurbanovD.Web.ViewModels;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class HeroesController : Controller
    {
        private CardGameService cardGameService;
        private readonly CardGameContext context;

        public HeroesController(CardGameContext context)
        {
            this.context = context;
            cardGameService = new CardGameService(this.context);
        }
        [Route("Heroes")]
        public async Task<IActionResult> GetAllHeroes()
        {
            var viewModel = new HeroesGetAllHeroesViewModel();
            viewModel.Heroes = await cardGameService.GetAllHeroes();
            return View(viewModel);
        }
        [Route("Heroes/{id}")]
        public async Task<IActionResult> GetHero(Guid id)
        {
            var viewModel = new HeroesGetHeroViewModel();
            var hero = await cardGameService.GetHeroById(id);

            if (hero == null)
                return NotFound();

            var similarRaceHeroes = (await cardGameService.GetHeroesByStats
                (HeroStats.Race, hero.Race.ToString(), StatAmountType.Contains)).Where(h => h.Id != hero.Id).ToList();
            var similarClassHeroes = (await cardGameService.GetHeroesByStats
                (HeroStats.Class, hero.HeroClass.ToString(), StatAmountType.Contains)).Where(h => h.Id != hero.Id).ToList(); ;

            viewModel.Hero = hero;
            viewModel.SimilarRaceHeroes = similarRaceHeroes;
            viewModel.SimilarClassHeroes = similarClassHeroes;

            return View(viewModel);
        }
        [Route("Heroes/Stat/{heroStat}/{statAmountType}/{value}")]
        public async Task<IActionResult> GetHeroByStats(HeroStats heroStat, string value, StatAmountType statAmountType)
        {
            var viewModel = new HeroesGetHeroByStatsViewModel();
            viewModel.StatsName = heroStat;
            viewModel.Value = value;
            viewModel.StatAmountType = statAmountType;
            viewModel.Heroes = await cardGameService.GetHeroesByStats(heroStat, value, statAmountType);
            return View(viewModel);
        }
        [Route("Heroes/Create")]
        public async Task<IActionResult> CreateHero()
        {
            var user = (await cardGameService.GetAllUsers())
                        .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());

            if (user.Role != UserRole.Admin || user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken"))
                return BadRequest();
            var allSkills = await cardGameService.GetAllSkills();
            var allImages = cardGameService.GetAllHeroImagesString();
            var viewModel = new HeroesUpdateCreateViewModel
            {
                DamageTypes = Enum.GetValues(typeof(DamageType)).Cast<DamageType>().Select(dt => new SelectListItem
                {
                    Text = dt.ToString(),
                    Value = ((int)dt).ToString()
                }).ToList(),
                HeroClasses = Enum.GetValues(typeof(HeroClass)).Cast<HeroClass>().Select(hc => new SelectListItem
                {
                    Text = hc.ToString(),
                    Value = ((int)hc).ToString()
                }).ToList(),
                Images = allImages.Select(s => new SelectListItem {
                    Text = s.Substring(0, s.Length - 4),
                    Value = s
                }).ToList()
            };
            foreach (Skill skill in allSkills)
            {
                if (skill.Skillsort == SkillSort.Active)
                {
                    var skillViewmodel = (ActiveSkill)skill;
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skillViewmodel.Name} : Active Skill , {skillViewmodel.Manacost} Mana",
                        Value = skillViewmodel.Id.ToString()
                    });
                }
                else
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skill.Name}: Passive Skill",
                        Value = skill.Id.ToString()
                    }); ;
            }


            return View(viewModel);
        }
        [HttpPost]
        [Route("Heroes/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHero(HeroesUpdateCreateViewModel viewModel)
        {
            var user = (await cardGameService.GetAllUsers())
              .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());

            if (user.Role != UserRole.Admin || user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken"))
                return BadRequest();
            var allSkills = await cardGameService.GetAllSkills();
            foreach (Skill skill in allSkills)
            {
                if (skill.Skillsort == SkillSort.Active)
                {
                    var skillViewmodel = (ActiveSkill)skill;
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skillViewmodel.Name} : Active Skill , {skillViewmodel.Manacost} Mana",
                        Value = skillViewmodel.Id.ToString()
                    });
                }
                else
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skill.Name}: Passive Skill",
                        Value = skill.Id.ToString()
                    }); ;
            }
            viewModel.DamageTypes = Enum.GetValues(typeof(DamageType)).Cast<DamageType>().Select(dt => new SelectListItem
            {
                Text = dt.ToString(),
                Value = ((int)dt).ToString()
            }).ToList();
            viewModel.HeroClasses = Enum.GetValues(typeof(HeroClass)).Cast<HeroClass>().Select(hc => new SelectListItem
            {
                Text = hc.ToString(),
                Value = ((int)hc).ToString()
            }).ToList();
            viewModel.Images = cardGameService.GetAllHeroImagesString().Select(s => new SelectListItem
            {
                Text = s.Substring(0,s.Length - 4),
                Value = s
            }).ToList();
            if (ModelState.IsValid)
            {
                var createHero = new Hero
                {
                    Id = Guid.NewGuid(),
                    Name = viewModel.Name,
                    ActionPoints = viewModel.ActionPoints,
                    HeroClass = (HeroClass)viewModel.HeroClass,
                    DamageType = (DamageType)viewModel.DamageType,
                    Health = viewModel.Health,
                    HealthRegen = viewModel.HealthRegeneration,
                    Mana = viewModel.Mana,
                    Manaregen = viewModel.ManaRegeneration,
                    Damage = viewModel.Damage,
                    Armor = viewModel.Armor,
                    Description = viewModel.Description,
                    Img = viewModel.Image

                };
                var createSkills = (await cardGameService.GetAllSkills()).Where(s => viewModel.SkillSet.Contains(s.Id)).ToList();
                var createHeroSkills = createSkills.Select(s => new CardUnitSkills
                {
                    CardUnitId = createHero.Id,
                    CardUnit = createHero,
                    SkillId = s.Id,
                    Skill = s
                }).ToList();
                if (createHeroSkills.Count() != viewModel.SkillSet.Count)
                    return BadRequest();
                createHero.SkillSet = createHeroSkills;
                try
                {
                    context.Heroes.Add(createHero);
                    await context.SaveChangesAsync();
                    TempData[ConstantValues.NotificationMessage] = $"Hero {createHero.Name} has been succesfully created!";
                    return new RedirectToActionResult(nameof(GetAllHeroes), "Heroes", null);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Something went wrong! Check your inputs and try again please");
                    return View(viewModel);
                }
            }
            else
                return View(viewModel);
        }
        [Route("Heroes/Update/{id}")]
        public async Task<IActionResult> UpdateHero(Guid id)
        {
            var user = (await cardGameService.GetAllUsers())
                .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());

            var hero = (await cardGameService.GetAllHeroes()).SingleOrDefault(h => h.Id == id);

            if (user.Role != UserRole.Admin || user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
               || hero == null)
                return BadRequest();

            var allSkills = await cardGameService.GetAllSkills();
            var viewModel = new HeroesUpdateCreateViewModel
            {
                Id = hero.Id,
                Name = hero.Name,
                ActionPoints = hero.ActionPoints,
                HeroClass = (int)hero.HeroClass,
                DamageType = (int)hero.DamageType,
                Health = hero.Health,
                HealthRegeneration = hero.HealthRegen,
                Mana = hero.Mana,
                ManaRegeneration = hero.Manaregen,
                Damage = hero.Damage,
                Armor = hero.Armor,
                Description = hero.Description,
                SkillSet = hero.SkillSet.Select(s => s.SkillId).ToList(),
                Image = hero.Img,
                HeroClasses = Enum.GetValues(typeof(HeroClass)).Cast<HeroClass>().Select(hc => new SelectListItem
                {
                    Text = hc.ToString(),
                    Value = ((int)hc).ToString()
                }).ToList(),
                DamageTypes = Enum.GetValues(typeof(DamageType)).Cast<DamageType>().Select(dt => new SelectListItem
                {
                    Text = dt.ToString(),
                    Value = ((int)dt).ToString()
                }).ToList(),
                Images = cardGameService.GetAllHeroImagesString().Select(s => new SelectListItem
                {
                    Text = s.Substring(0, s.Length - 4),
                    Value = s
                }).ToList()
            };
            foreach (Skill skill in allSkills)
            {
                if (skill.Skillsort == SkillSort.Active)
                {
                    var skillViewmodel = (ActiveSkill)skill;
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skillViewmodel.Name} : Active Skill , {skillViewmodel.Manacost} Mana",
                        Value = skillViewmodel.Id.ToString()
                    });
                }
                else
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skill.Name}: Passive Skill",
                        Value = skill.Id.ToString()
                    }); ;
            }
            return View(viewModel);
        }
        [Route("Heroes/Update/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateHero(Guid id, HeroesUpdateCreateViewModel viewModel)
        {

            var updateHero = (await cardGameService.GetAllHeroes()).SingleOrDefault(h => h.Id == id);
            var allSkills = await cardGameService.GetAllSkills();
            viewModel.HeroClasses = Enum.GetValues(typeof(HeroClass)).Cast<HeroClass>().Select(hc => new SelectListItem
            {
                Text = hc.ToString(),
                Value = ((int)hc).ToString()
            }).ToList();
            viewModel.DamageTypes = Enum.GetValues(typeof(DamageType)).Cast<DamageType>().Select(dt => new SelectListItem
            {
                Text = dt.ToString(),
                Value = ((int)dt).ToString()
            }).ToList();
            viewModel.Images = cardGameService.GetAllHeroImagesString().Select(s => new SelectListItem
            {
                Text = s.Substring(0, s.Length - 4),
                Value = s
            }).ToList();
            foreach (Skill skill in allSkills)
            {
                if (skill.Skillsort == SkillSort.Active)
                {
                    var skillViewmodel = (ActiveSkill)skill;
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skillViewmodel.Name} : Active Skill , {skillViewmodel.Manacost} Mana",
                        Value = skillViewmodel.Id.ToString()
                    });
                }
                else
                    viewModel.Skills.Add(new SelectListItem
                    {
                        Text = $"{skill.Name}: Passive Skill",
                        Value = skill.Id.ToString()
                    }); ;
            }

            var user = (await cardGameService.GetAllUsers())
                .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());


            if (user.Role != UserRole.Admin || user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
               || updateHero == null)
                return BadRequest();
            if (viewModel.SkillSet.Count < 2)
            {
                ModelState.AddModelError("SkillSet", "SkillSet should have at least 2 skills!");
                return View(viewModel);
            }
            if (ModelState.IsValid)
            {
                var updateSkills = (await cardGameService.GetAllSkills()).Where(s => viewModel.SkillSet.Contains(s.Id)).ToList();
                var updateCardUnitSkills = updateSkills.Select(s => new CardUnitSkills
                {
                    CardUnitId = updateHero.Id,
                    CardUnit = updateHero,
                    SkillId = s.Id,
                    Skill = s
                }).ToList();
                if (updateCardUnitSkills.Count() != viewModel.SkillSet.Count)
                    return BadRequest();
                updateHero.Name = viewModel.Name;
                updateHero.ActionPoints = viewModel.ActionPoints;
                updateHero.HeroClass = (HeroClass)viewModel.HeroClass;
                updateHero.DamageType = (DamageType)viewModel.DamageType;
                updateHero.Health = viewModel.Health;
                updateHero.HealthRegen = viewModel.HealthRegeneration;
                updateHero.Mana = viewModel.Mana;
                updateHero.Manaregen = viewModel.ManaRegeneration;
                updateHero.Damage = viewModel.Damage;
                updateHero.Armor = viewModel.Armor;
                updateHero.Description = viewModel.Description;
                updateHero.SkillSet = updateCardUnitSkills;
                updateHero.Img = viewModel.Image;
                try
                {
                    context.Heroes.Update(updateHero);
                    await context.SaveChangesAsync();
                    TempData[ConstantValues.NotificationMessage] = $"Hero {updateHero.Name} has been succesfully updated!";
                    return new RedirectToActionResult(nameof(GetAllHeroes), "Heroes", null);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Something went wrong! Check your inputs and try again please");
                    return View(viewModel);
                }
            }
            else
                return View(viewModel);
        }
        
        [Route("Heroes/Delete/{id}")]
        public async Task<IActionResult> DeleteHero(Guid id)
        {
            var deleteHero = (await cardGameService.GetAllHeroes()).SingleOrDefault(h => h.Id == id);
            var user = (await cardGameService.GetAllUsers())
    .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());


            if (user.Role != UserRole.Admin || user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
               || deleteHero == null)
                return BadRequest();
            var viewModel = new HeroesDeleteViewModel
            {
                Id = deleteHero.Id,
                Name = deleteHero.Name
            };

            return View(viewModel);

        }
        [Route("Heroes/Delete/{id}")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeleteHero(Guid id,HeroesDeleteViewModel viewModel)
        {
            var deleteHero = (await cardGameService.GetAllHeroes()).SingleOrDefault(h => h.Id == id);
            var user = (await cardGameService.GetAllUsers())
    .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());


            if (user.Role != UserRole.Admin || user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
               || deleteHero == null || id != viewModel.Id)
                return BadRequest();
            try
            {
                context.Heroes.Remove(deleteHero);
                await context.SaveChangesAsync();
                TempData[ConstantValues.NotificationMessage] = $"Hero {deleteHero.Name} has been successfully deleted!";
                return new RedirectToActionResult("GetAllHeroes", "Heroes", null);
            }
            catch (Exception)
            {
                ModelState.AddModelError("","Something went wrong! Please try again later!");
                return View(viewModel);
            }
        }
    }
}