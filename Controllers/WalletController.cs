using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Budgeteer.Models;
using Budgeteer.Identity;

namespace Budgeteer.Controllers
{
    [Authorize]
    public class WalletController : Controller
    {
        public WalletController(budgeteer_appdbContext appDBCtx, AppUserDbContext appUserCtx)
        {
            AppDBCtx = appDBCtx;
            AppUserDBCtx = appUserCtx;
        }
        private budgeteer_appdbContext AppDBCtx { get; set; }
        private AppUserDbContext AppUserDBCtx { get; set; }
        public IActionResult Index()
        {
            ViewBag.Title = "Wallet";
            return View();
        }
        public IActionResult Purchases()
        {
            ViewBag.Title = "Purchases";
            return View();
        }
        public IActionResult Savings()
        {
            ViewBag.Title = "Savings";
            return View();
        }
    }
}
