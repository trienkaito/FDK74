using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FBK74App.models;
using FBK74App.Repository;
using FBK74App.Service;
using Microsoft.Identity.Client;

namespace FBK74App.Pages.Matches
{
    public class CheckOutModel : PageModel
    {
        private readonly FBK74App.models.AppDbContext _context;
        private readonly IRegisteredFootballFieldRepository _rff;
        private readonly ICookieAuthentication _cookie;

        public CheckOutModel(FBK74App.models.AppDbContext context, IRegisteredFootballFieldRepository registeredFootballFieldRepository, ICookieAuthentication cookieAuthentication)
        {
            _context = context;
            _rff = registeredFootballFieldRepository;
            _cookie = cookieAuthentication;
        }
        [BindProperty]
        public int ffId { get; set; }
        [BindProperty]

        public DateTime CurrentDate { get; set; }

        [BindProperty]

        public int AccountId { get; private set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Note { get; set; }

        public IActionResult OnGet(int id, DateTime currentDate)
        {
            ViewData["Account1Id"] = new SelectList(_context.Accounts, "Id", "Id");
            ViewData["Account2Id"] = new SelectList(_context.Accounts, "Id", "Id");
            ViewData["FootballFieldScheduleId"] = new SelectList(_context.FootballFieldSchedules, "Id", "Id");

            ffId = id;
            CurrentDate = currentDate;

            var accountIdClaim = User.Claims.FirstOrDefault(c => c.Type == "Id");
            if (accountIdClaim != null)
            {
                AccountId = int.Parse(accountIdClaim.Value);
            }
            return Page();
        }

        [BindProperty]
        public RegisteredFootballField RegisteredFootballField { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            var newRFF = new RegisteredFootballField
            {
                FootballFieldScheduleId = ffId,
                Name = RegisteredFootballField.Name,
                Deposit = 200,
                Account1Id = AccountId,
                Account2Id = 2,
                RegistFindOppoentId = 1,
                Date = CurrentDate,
                Note = RegisteredFootballField.Note
            };
            await _rff.Add(newRFF);
            return RedirectToPage("Matches");

        }
    }
}

