using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Budgeteer.Models;

namespace Budgeteer.Controllers
{
    public class WalletController : Controller
    {
        public WalletController(budgeteer_appdbContext appDBCtx)
        {
            AppDBCtx = appDBCtx;
        }
        private budgeteer_appdbContext AppDBCtx { get; set; }
        public IActionResult Index()
        {
            ViewBag.Title = "Wallet";
            return View();
        }
    }
}
