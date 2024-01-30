using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demo11.Pages
{
    public class AddModel : PageModel
    {
        private readonly StudentService _studentService;

        public AddModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        //public void OnPost(string firstName, string lastName)
        //{
        //    // Create a new student and add it to the service
        //    Student newStudent = new Student(firstName, lastName);
        //    _studentService.AddStudent(newStudent);
        //}

        public void OnGet()
        {
        }
    }
}
