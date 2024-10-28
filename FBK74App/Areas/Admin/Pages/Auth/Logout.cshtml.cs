using FBK74App.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FBK74App.Areas.Admin.Pages.Auth
{
    [Authorize(AuthenticationSchemes = "AdminScheme")]
    public class LogoutModel : PageModel
    {
        private readonly ICookieAdminAuthentication _cookie;
        public LogoutModel(ICookieAdminAuthentication cookie)
        {
            _cookie = cookie;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            await _cookie.SignOutAsync(HttpContext);
            return RedirectToPage("/auth/login");
        }
    }
}
