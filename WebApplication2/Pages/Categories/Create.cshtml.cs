using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Model;

namespace WebApplication2.Pages.Categories
{
    public class CreateModel : PageModel
    {
public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
