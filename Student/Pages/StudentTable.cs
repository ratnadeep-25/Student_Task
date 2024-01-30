namespace Student.Pages
{
    public class StudentTable
    {
        public List<StudentTable> StudentList = new List<StudentTable>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public StudentTable()
        {

        }

        public StudentTable(List<StudentTable> StudentList)
        {
            this.StudentList = StudentList;
        }
    }
}
