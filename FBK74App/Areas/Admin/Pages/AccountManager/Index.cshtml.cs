﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FBK74App.models;

namespace FBK74App.Areas.Admin.Pages.AccountManager
{
    public class IndexModel : PageModel
    {
        private readonly FBK74App.models.AppDbContext _context;

        public IndexModel(FBK74App.models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Account = await _context.Accounts.ToListAsync();
        }
    }
}
