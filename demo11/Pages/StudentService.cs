namespace demo11.Pages
{
    public class StudentService
    {
        private List<Student> _studentList = new List<Student>();

        public List<Student> GetStudentList()
        {
            return _studentList;
        }

        public void AddStudent(Student student)
        {
            _studentList.Add(student);
        }
    }
}
