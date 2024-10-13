using D_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace D_Project.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        
        public AppUser? app_user;
        
        public UserModel(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
            var task = _userManager.GetUserAsync(User);
            task.Wait();
            app_user = task.Result;
        }
    }
}
