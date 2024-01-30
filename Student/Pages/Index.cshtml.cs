using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student.Models;

namespace Student.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public StudentTable Student { get; set; }
        public List<StudentTable> OurStudentList { get; set; }
        //OurStudentList.Add();
            //StoreData SD2 = new StoreData();
        //public string Message { get; set; } 

        
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //OurStudentList = new Data().StudentList;
            //OurStudentList = SD2.StudentList;
            //OurStudentList.Add(new StudentTable { FirstName = "Vijay", LastName = "Jadhav" });
            //OurStudentList.Add(new StudentTable { FirstName = "Mahesh", LastName = "Patil" });
            StoreData data = new StoreData();

            //StudentTable ST = new StudentTable{FirstName = HttpContext.Request.Query["FirstName"],
            //LastName = HttpContext.Request.Query["LastName"],
            //Gender = HttpContext.Request.Query["Gender"],
            //BirthDate = DateTime.Now,
            //Age = int.Parse(HttpContext.Request.Query["Age"]),
            //Class = HttpContext.Request.Query["Class"],
            //Address = HttpContext.Request.Query["Address"]};

            //data.StudentList.Add( ST ); 
            //OurStudentList.AddRange(data.StudentList);
            Student = new StudentTable
            {
                FirstName = HttpContext.Request.Query["FirstName"],
                LastName = HttpContext.Request.Query["LastName"],
                Gender = HttpContext.Request.Query["Gender"],
                //BirthDate = HttpContext.Request.Query["BirthDate"],
                Age =int.Parse( HttpContext.Request.Query["Age"]),
                Class = HttpContext.Request.Query["Class"],
                Address = HttpContext.Request.Query["Address"]
            };
            Student = Student ?? new StudentTable();
        }
    }
}
