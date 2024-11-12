using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FBK74App.models;

namespace FBK74App.Areas.Admin.Pages.FootballFieldManager
{
    public class EditModel : PageModel
    {
        private readonly FBK74App.models.AppDbContext _context;

        public EditModel(FBK74App.models.AppDbContext context)
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

            var footballfield =  await _context.FootballFields.FirstOrDefaultAsync(m => m.Id == id);
            if (footballfield == null)
            {
                return NotFound();
            }
            FootballField = footballfield;
            FootballField.UpdatedDate = DateTime.Now;   
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FootballField).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FootballFieldExists(FootballField.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FootballFieldExists(int id)
        {
            return _context.FootballFields.Any(e => e.Id == id);
        }
    }
}
