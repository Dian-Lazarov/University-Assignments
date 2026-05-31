using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaHub.Pages
{
    public class SearchModel : PageModel
    {
        public string SearchQuery { get; set; } = string.Empty;

        public void OnGet(string q)
        {
            SearchQuery = q ?? string.Empty;
        }
    }
}
