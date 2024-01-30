using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class AddEditModel : PageModel
    {
        private readonly StudentService _studentService;

        [BindProperty]
        public Student Student { get; set; }
        public bool DeleteFlag { get; set; }

       
        public AddEditModel(StudentService studentService)
        {

            _studentService = studentService;
        }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                // Editing existing student
                Student = _studentService.GetStudentById(id.Value);
   
            }
            else
            {
                // Adding a new student
                Student = new Student();
            }

            return Page();
        }

        public IActionResult OnPost()
        {


           

            if (DeleteFlag)
            {
                // Delete the student and redirect to Index
                _studentService.DeleteStudent(Student.Id);

                return RedirectToPage("Index");
            }

            if (ModelState.IsValid)
            {
                _studentService.AddOrUpdateStudent(Student);
                return RedirectToPage("Index");
            }


            return Page();
        }

    }
}
