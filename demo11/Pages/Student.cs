using System.Runtime.Versioning;

namespace demo11.Pages
{
    public class Student
    {
        public List<Student> STList;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        
        public  Student(String Fname,String Lname) 
        {
           
            FirstName = Fname;
            LastName = Lname;
        }

        public Student()
        {

        }
        public Student(List<Student> STL)
        {
            this.STList = STL;
        }
    }

     class Project
    {
        

    
    }
}
