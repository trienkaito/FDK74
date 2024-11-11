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
    public class IndexModel : PageModel
    {
        private readonly FBK74App.models.AppDbContext _context;

        public IndexModel(FBK74App.models.AppDbContext context)
        {
            _context = context;
        }

        public IList<FootballField> FootballField { get;set; } = default!;

        public async Task OnGetAsync()
        {
            FootballField = await _context.FootballFields.ToListAsync();
        }
    }
}
