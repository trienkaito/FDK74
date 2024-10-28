using FBK74App.models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace FBK74App.Service
{
    public interface ICookieAdminAuthentication
    {
        public Task SignInAsync(Account account, HttpContext context);
        public Task SignOutAsync(HttpContext context);
    }

    public class CookieAdminAuthentication : ICookieAdminAuthentication
    {
        public async Task SignInAsync(Account account, HttpContext context)
        {
            AccountType role = account.Type;
            int id = account.Id;
            string scheme = "AdminScheme";

            List<Claim> claims = new List<Claim>()
            {
                new Claim("Id", id.ToString()),
                new Claim(ClaimTypes.Name, account.UserName),
                new Claim(ClaimTypes.Role, role.ToString())
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, scheme);

            AuthenticationProperties properties = new AuthenticationProperties()
            {
                AllowRefresh = true,
                IsPersistent = false
            };

            await context.SignInAsync(scheme,
                new ClaimsPrincipal(claimsIdentity), properties);
        }

        public async Task SignOutAsync(HttpContext context)
        {
            await context.SignOutAsync("AdminScheme");
        }
    }
}