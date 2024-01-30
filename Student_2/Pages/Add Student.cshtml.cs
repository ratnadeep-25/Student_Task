using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student.Models;

namespace Student.Pages
{
    public class Add_StudentModel : PageModel
    {
        public List<StudentTable> AddStudentList { get; set; }

        [BindProperty]
        public StudentTable NewStudent { get; set; }
        public void OnGet()
        {
            AddStudentList = new Data().StudentList;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            new Data().StudentList.Add(NewStudent);


            return RedirectToPage("/Index");
        }
    }
}
