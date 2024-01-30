using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student.Models;

namespace Student.Pages
{
    public class Add_StudentModel : PageModel
    {
        //public List<StudentTable> AddStudentList { get; set; }

        //[BindProperty]
        //public StudentTable NewStudent { get; set; }
       
        
        //StoreData SD = new StoreData();
       
        public void OnGet()
        {
            //AddStudentList = new Data().StudentList;
           // AddStudentList = SD.StudentList;
        }

        //public IActionResult OnPost()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
           
        //   // SD.StudentList.Add(NewStudent);


        //    return RedirectToPage("/Index");
        //}
    }
}
