using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Budgeteer.Models;
using Budgeteer.Identity;

namespace Budgeteer.Controllers
{
    [Authorize]
    public class WalletController : Controller
    {
        public WalletController(budgeteer_appdbContext appDBCtx, AppUserDbContext appUserCtx, UserManager<AppUser> userMgr)
        {
            AppDBCtx = appDBCtx;
            AppUserDBCtx = appUserCtx;
            UserManager = userMgr;
        }
        private budgeteer_appdbContext AppDBCtx { get; set; }
        private AppUserDbContext AppUserDBCtx { get; set; }
        private UserManager<AppUser> UserManager { get; set; }
        public IActionResult Index()
        {
            ViewBag.Title = "Wallet";
            return View();
        }
        // TODO: Make view component for purchases table
        public async Task<IActionResult> Purchases([FromQuery] int page = 1)
        {
            AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Title = "Purchases";
            PurchaseViewModel purchases = new PurchaseViewModel()
            {
                Purchases = AppDBCtx.Purchases.Where(s => s.UserId == user.Id && s.IsDeleted == false).Skip((page - 1) * 10).Take(10).ToList<Purchase>(),
                PageCount = Convert.ToInt32(Math.Floor(Convert.ToDecimal((AppDBCtx.Purchases.Where(s => s.UserId == user.Id).Count()) / 10))) + 1
            };
            return View(purchases);
        }
        [HttpPost]
        public async Task<IActionResult> AddPurchase([FromForm] string description, [FromForm] decimal amount, [FromForm] string category)
        {
            AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
            await AppDBCtx.Purchases.AddAsync(new Purchase()
            {
                UserId = user.Id,
                Description = description,
                Amount = amount,
                Category = category,
                Date = DateTime.UtcNow,
                IsDeleted = false
            });
            await AppDBCtx.SaveChangesAsync(); 
            return RedirectToAction(nameof(Purchases));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePurchase([FromForm] long id)
        {
            AppDBCtx.Purchases.Find(id).IsDeleted = true;
            await AppDBCtx.SaveChangesAsync();
            return RedirectToAction(nameof(Purchases));
        }
        
        // TODO: Make view component for savings table
        public async Task<IActionResult> Savings([FromQuery] int page = 1)
        {
            AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Title = "Savings";
            SavingViewModel savings = new SavingViewModel
            {
                Savings = AppDBCtx.Savings.Where(s => s.UserId == user.Id && s.IsDeleted == false).Skip((page - 1) * 10).Take(10).ToList<Saving>(),
                PageCount = Convert.ToInt32(Math.Floor(Convert.ToDecimal((AppDBCtx.Savings.Where(s => s.UserId == user.Id).Count()) / 10))) + 1
            };
            return View(savings);
        }
        [HttpPost]
        public async Task<IActionResult> AddSavings([FromForm] string description, [FromForm] decimal amount, [FromForm] string category)
        {
            AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
            await AppDBCtx.Savings.AddAsync(new Saving()
            {
                UserId = user.Id,
                Description = description,
                Amount = amount,
                Category = category,
                Date = DateTime.UtcNow,
                IsDeleted = false
            });
            await AppDBCtx.SaveChangesAsync();
            return RedirectToAction(nameof(Savings));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSavings([FromForm] long id)
        {
            AppDBCtx.Savings.Find(id).IsDeleted = true;
            await AppDBCtx.SaveChangesAsync();
            return RedirectToAction(nameof(Savings));
        }
    }
    
}
