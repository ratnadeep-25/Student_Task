using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Student_ByUsingHTML_CSS_JS.Views.Home
{
    public class Add_StudentModel : PageModel
    {
        public string firstName;
        public string lastName;
       
        public void OnGet()
        {
        }

        public void OnPost()
        {
            firstName = Request.Form["firstname"];
            lastName = Request.Form["lastname"];
        }
    }
}
