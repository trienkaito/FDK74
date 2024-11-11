using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FBK74App.models;

namespace FBK74App.Areas.Admin.Pages.FootballFieldManager
{
    public class DeleteModel : PageModel
    {
        private readonly FBK74App.models.AppDbContext _context;

        public DeleteModel(FBK74App.models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FootballField FootballField { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballfield = await _context.FootballFields.FirstOrDefaultAsync(m => m.Id == id);

            if (footballfield == null)
            {
                return NotFound();
            }
            else
            {
                FootballField = footballfield;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballfield = await _context.FootballFields.FindAsync(id);
            if (footballfield != null)
            {
                FootballField = footballfield;
                _context.FootballFields.Remove(FootballField);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
