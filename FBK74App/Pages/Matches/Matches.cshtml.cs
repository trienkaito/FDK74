using FBK74App.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FBK74App.Pages.Matches
{
    public class Matches : PageModel
    {
        private readonly AppDbContext context;
        public Matches()
        {
            context = new AppDbContext();
        }
        public List<FootballFieldSchedule> FootballFieldSchedules { get; set; } = new List<FootballFieldSchedule>();
        public List<FootballField> FootballFields { get; set; } = new List<FootballField>();
        public DateTime CurrentDate { get; set; }
        public async Task OnGetAsync()
        {
            // Lấy dữ liệu từ database
            FootballFieldSchedules = await context.FootballFieldSchedules.ToListAsync();

            FootballFields = await context.FootballFields.ToListAsync();

            // Gán ngày hiện tại
            CurrentDate = DateTime.Now;

        }
    }
}
