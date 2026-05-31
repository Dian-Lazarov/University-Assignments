using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaHub.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // TODO: Add user registration logic here later
            return RedirectToPage("/Index");
        }
    }
}