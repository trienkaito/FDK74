using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FBK74App.models;

namespace FBK74App.Areas.Admin.Pages.FootballFieldManager
{
    public class CreateModel : PageModel
    {
        private readonly FBK74App.models.AppDbContext _context;

        public CreateModel(FBK74App.models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FootballField FootballField { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            FootballField.CreatedDate = DateTime.Now;   
            FootballField.UpdatedDate = DateTime.Now;

            _context.FootballFields.Add(FootballField);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
