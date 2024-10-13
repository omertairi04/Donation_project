using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace D_Project.Pages;

[Authorize(Roles = "Admin")]
public class Admin : PageModel
{
    public void OnGet()
    {
        
    }
}