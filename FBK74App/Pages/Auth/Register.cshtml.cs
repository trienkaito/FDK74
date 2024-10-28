using FBK74App.models;
using FBK74App.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FBK74App.Pages.Auth
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;
        public RegisterModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        [Required]
        public string Username { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [BindProperty]
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }   



        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var result = _context.Accounts.Any(acc => acc.UserName == Username);

                if (result)
                {
                    TempData["Message"] = "Username was exist!";
                    return Page();
                }

                Account acc = new Account
                {
                    UserName = Username,
                    //Password = HashPassword.GetHashPassword(Password),
                    Password = Password,
                    Email = Email,
                    Type = AccountType.Member
                };

                _context.Accounts.Add(acc);
                _context.SaveChanges();

                TempData["Message"] = "Register success";
                return RedirectToPage("/Auth/Login");

            }
            return Page();
        }
    }
}
