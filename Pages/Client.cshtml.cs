using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace D_Project.Pages;
[Authorize(Roles = "Client")]
public class Client : PageModel
{
    public void OnGet()
    {
        
    }
}