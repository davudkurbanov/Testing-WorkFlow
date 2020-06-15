using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WBA.PE2.KurbanovD.Web.Models;
using WBA.PE2.KurbanovD.Domain;
using WBA.PE2.KurbanovD.Web.ViewModels;
using WBA.PE2.KurbanovD.Domain.Repositories;
using WBA.PE2.KurbanovD.Domain.Base;
using WBA.PE2.KurbanovD.Domain.Base.Enums;
using System.Runtime.InteropServices;
using WBA.PE2.KurbanovD.Web.Data;

namespace WBA.PE2.KurbanovD.Web.Controllers
{
    public class CardGameController : Controller
    {
        private readonly CardGameContext _context;

        public CardGameController(CardGameContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
