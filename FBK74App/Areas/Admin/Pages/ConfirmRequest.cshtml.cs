using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FBK74App.Areas.Admin.Pages
{
    [Authorize(AuthenticationSchemes = "AdminScheme")]
    public class ConfirmRequestModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
