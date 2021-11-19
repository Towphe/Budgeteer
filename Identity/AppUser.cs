using System;
using Microsoft.AspNetCore.Identity;

namespace Budgeteer.Identity
{
    public class AppUser : IdentityUser
    {
        public string SettingsJSON { get; set; } // JSON text
        public string ProfilePicDir { get; set; }
    }
}
