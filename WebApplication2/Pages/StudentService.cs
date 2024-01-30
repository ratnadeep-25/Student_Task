namespace WebApplication2.Pages
{
    public class StudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
            // Initialize with some sample data
            _students = new List<Student>
        {
            new Student { Id=1, FirstName = "Ajay", LastName = "Patil", Gender = "Male", DateOfBirth = new DateTime(2008, 1, 20), Age = 15, Class = "12th", Address = "Pune" },
            new Student { Id = 2, FirstName = "Ranjeet", LastName = "Jadhav", Gender = "Male", DateOfBirth = new DateTime(2006, 8, 06), Age = 17, Class = "10th", Address = "Mumbai" },
            // Add more sample data as needed
        };
        }

        public List<Student> GetStudents()
        {
            return _students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public void AddOrUpdateStudent(Student student)
        {
            if (student.Id == 0)
            {
                // Add new student
                student.Id = _students.Count + 1;
                _students.Add(student);
            }
            else
            {
                // Update existing student
                var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
                if (existingStudent != null)
                {
                    existingStudent.FirstName = student.FirstName;
                    existingStudent.LastName = student.LastName;
                    existingStudent.Gender = student.Gender;
                    existingStudent.DateOfBirth = student.DateOfBirth;
                    existingStudent.Age = student.Age;
                    existingStudent.Class = student.Class;
                    existingStudent.Address = student.Address;
                    // Update other properties as needed
                }
            }
        }
        public void DeleteStudent(int studentId)
        {

            var studentToRemove = _students.FirstOrDefault(s => s.Id == studentId);
            if (studentToRemove != null)
            {
                _students.Remove(studentToRemove);
            }
        }
    }
}
