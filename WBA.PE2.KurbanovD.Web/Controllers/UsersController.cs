using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using WBA.PE2.KurbanovD.Domain.Base.Intermediates;
using WBA.PE2.KurbanovD.Domain.Services;
using WBA.PE2.KurbanovD.Web.Constants;
using WBA.PE2.KurbanovD.Web.Data;
using WBA.PE2.KurbanovD.Web.Services;
using WBA.PE2.KurbanovD.Web.ViewModels;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class UsersController : Controller
    {
        private CardGameService cardGameService;
        private CardGameContext context;
        public UsersController(CardGameContext context)
        {
            this.context = context;
            cardGameService = new CardGameService(context);
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Users/Register")]
        public IActionResult Register()
        {
            var viewModel = new UsersRegisterViewModel();
            return View(viewModel);
        }
        [HttpPost]
        [Route("Users/Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UsersRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.PrivacyPolicyAccepted == false)
                {
                    ModelState.AddModelError(nameof(viewModel.PrivacyPolicyAccepted), "Privace/Should be accepted before registering!");
                    return View();
                }
                var checkUserName = (await cardGameService.GetAllUsers())
                    .SingleOrDefault(u => u.UserName.ToLower() == viewModel.UserName.ToLower());
                if (checkUserName == null)
                { 
                User newUser = new User
                {
                    Id = Guid.NewGuid(),
                    UserName = viewModel.UserName,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    Password = StringHasher.MD5Hash(viewModel.Password),
                    Role = UserRole.User,
                    CreationDate = DateTime.Now
                };
                    try
                    {
                        context.Users.Add(newUser);
                        await context.SaveChangesAsync();
                        TempData[ConstantValues.NotificationMessage] = $"User {newUser.FirstName} {newUser.LastName}" +
                            $" has been successfully registered on {newUser.CreationDate}! You may now login";
                        return new RedirectToActionResult("Login", "Users", null);
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("","Something went wrong! Please check your input and try again");
                        return View(viewModel);
                    }
                }
                else
                {
                    ModelState.AddModelError(nameof(viewModel.UserName), "This username already exists!");
                    return View(viewModel);
                }
            }
            else
                return View(viewModel);
        }
        [Route("Users/Details/{authenticationToken}")]
        public async Task<IActionResult> UserDetails(Guid authenticationToken)
        {
            var user = (await cardGameService.GetAllUsers())
    .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());

            if ( user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
                || user.AuthenticationToken != authenticationToken)
                return BadRequest();
            var viewModel = new UsersDetailsViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = user.Role,
                HeroCards = user.HeroCards
            };
            return View(viewModel);
        }
        [Route("Users/Login")]
        public IActionResult Login()
        {
            var usersLoginViewModel = new UsersLoginViewModel();
            return View(usersLoginViewModel);
        }
        [HttpPost]
        [Route("Users/Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UsersLoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = (await cardGameService.GetAllUsers())
                    .SingleOrDefault(u => u.UserName.ToLower() == viewModel.UserName.ToLower());
                if (user == null)
                {
                    ModelState.AddModelError("","Username/Password doesn't match!");
                    return View(viewModel);
                }
               else if (user.Password != StringHasher.MD5Hash(viewModel.Password))
                {
                    ModelState.AddModelError("", "Username/Password doesn't match!");
                    return View(viewModel);
                }
                else
                {
                    user.AuthenticationToken = AuthenticationTokenGenerator.GenerateAuthenticationToken();
                    try
                    {
                         context.Users.Update(user);
                        await context.SaveChangesAsync();
                        TempData[ConstantValues.NotificationMessage] = "Login is successfull!";
                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("AuthenticationToken",user.AuthenticationToken.ToString());
                        HttpContext.Session.SetString("UserRole", user.Role.ToString());
                        string serializeHeroCards = JsonConvert.SerializeObject(user.HeroCards.Select(uhc => uhc.HeroId).ToList());
                        HttpContext.Session.SetString("HeroCards", serializeHeroCards);
                        return new RedirectToActionResult("UserDetails", "Users", new {authenticationToken = user.AuthenticationToken });
                    }
                    catch (Exception)
                    {
                        ModelState.AddModelError("", "Something went wrong! Please try Again!");
                        return View(viewModel);
                    }

                }
            }
            else
                return View(viewModel);
        }
        [Route("Users/Delete/HeroCard/{id}")]
        public async Task<IActionResult> DeleteUserHeroCard(Guid id)
        {
            var user = (await cardGameService.GetAllUsers())
    .SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());
            var deleteHeroCard = user.HeroCards.SingleOrDefault(uhc => uhc.HeroId == id);

            if (user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
                ||deleteHeroCard == null)
                return BadRequest();
            try
            {
                user.HeroCards.Remove(deleteHeroCard);
                await context.SaveChangesAsync();
                string serializeHeroCards = JsonConvert.SerializeObject(user.HeroCards.Select(uhc => uhc.HeroId).ToList());
                HttpContext.Session.SetString("HeroCards", serializeHeroCards);
            }
            catch (Exception)
            {
                TempData[ConstantValues.NotificationMessage] = "Something went wrong! Please try again later!";
            }
            var authenticationToken = user.AuthenticationToken;
            return Redirect(Request.Headers["Referer"].ToString());

        }
        [Route("Users/Add/HeroCard/{id}")]
        public async Task<IActionResult> AddUserHeroCard(Guid id)
        {
            var user = (await cardGameService.GetAllUsers())
.SingleOrDefault(u => u.UserName.ToLower() == HttpContext.Session.GetString("UserName").ToLower());
            var hero = await cardGameService.GetHeroById(id);

            if ( user.AuthenticationToken.ToString() != HttpContext.Session.GetString("AuthenticationToken")
                || hero == null)
                return BadRequest();
            try
            {
                user.HeroCards.Add(new UserHeroCards
                {
                    User = user,
                    UserId = user.Id,
                    Hero = hero,
                    HeroId = hero.Id
                });
                context.Users.Update(user);
                await context.SaveChangesAsync();
                string serializeHeroCards = JsonConvert.SerializeObject(user.HeroCards.Select(uhc => uhc.HeroId).ToList());
                HttpContext.Session.SetString("HeroCards", serializeHeroCards);
            }
            catch (Exception)
            {
                TempData[ConstantValues.NotificationMessage] = "Something went wrong! Please try again later!";
            }
            var authenticationToken = user.AuthenticationToken;
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [Route("Users/Lougout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            var referencePage = Request.Headers["Referer"].ToString();
            if (referencePage.ToLower().Contains("users"))
                return new RedirectToActionResult("Index", "Users", null);
            else
            return Redirect(referencePage);
        }

    }
}