using FBK74App.models;
using FBK74App.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FBK74App.Pages.Auth
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ICookieAuthentication _cookie;
        public LoginModel(AppDbContext context, ICookieAuthentication cookie)
        {
            _context = context;
            _cookie = cookie;
        }

        [BindProperty]
        [Required]
        public string UserName { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var account = _context.Accounts.FirstOrDefault(acc => acc.UserName == UserName && acc.Password == Password && ((int)acc.Type) == 0 /*HashPassword.GetHashPassword(Password)*/);
                    if (account == default)
                {
                    TempData["Message"] = "Username or Password is wrong";
                    return Page();                                                                  
                }

                await _cookie.SignInAsync(account, HttpContext);
            }

            return RedirectToPage("/Index");
        }
    }
}
