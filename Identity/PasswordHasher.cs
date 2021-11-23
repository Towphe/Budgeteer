using BCrypt.Net;
using Microsoft.AspNetCore.Identity;
using System;

namespace Budgeteer.Identity
{
    public class PasswordHasher : IPasswordHasher<AppUser>
    {
        public string HashPassword(AppUser user, string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public PasswordVerificationResult VerifyHashedPassword(AppUser user, string hashedPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        }
    }
}
