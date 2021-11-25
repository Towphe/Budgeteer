using System;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Budgeteer.Filters;
using Budgeteer.Identity;

namespace Budgeteer.Controllers
{
    
    public class AccountController : Controller
    {
        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userMgr)
        {
            SignInManager = signInManager;
            UserManager = userMgr;
        }
        private SignInManager<AppUser> SignInManager { get; set; }
        private UserManager<AppUser> UserManager { get; set; }

        [NonAuthenticatedOnly]
        public IActionResult SignIn([FromQuery]string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [NonAuthenticatedOnly]
        public IActionResult SignUp() => View();
        [NonAuthenticatedOnly]
        public IActionResult ForgotPassword() => View();
        
        [HttpPost]
        public async Task<IActionResult> AttemptSignIn([FromForm] string username, [FromForm] string password, [FromForm]string returnUrl)
        {
            AppUser user = await UserManager.FindByNameAsync(username);
            Microsoft.AspNetCore.Identity.SignInResult result = Microsoft.AspNetCore.Identity.SignInResult.Failed;
            if (user != null && !string.IsNullOrEmpty(password))
            {
                result = await SignInManager.PasswordSignInAsync(user, password, false, true);
            }
            if (!result.Succeeded)
            {
                return RedirectToAction(nameof(SignIn));
            }
            return Redirect(returnUrl ?? "/");
        }
        [HttpPost]
        public async Task<IActionResult> AttemptSignUp([FromForm] AppUser userInput, [FromForm] string password)
        {
            await UserManager.CreateAsync(userInput, password);
            AppUser user = await UserManager.FindByNameAsync(userInput.UserName);
            await SignInManager.SignInAsync(user, false);
            await UserManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "User"));
            return RedirectToAction(nameof(SignUp));
        }
        [HttpPost]
        public async Task<IActionResult> AttemptSignOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        
    }
}
