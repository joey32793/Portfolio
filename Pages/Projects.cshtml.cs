using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public string Message { get; set; }
        
        public void OnGet()
        {
            Message = "Projects page";
        }
    }
}