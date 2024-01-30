namespace Student.Pages
{
    public class StoreData
    {
        public List<StudentTable> StudentList = new List<StudentTable>();
        public StoreData()
        {
            {
                StudentList.Add(new StudentTable { FirstName = "Ajay", LastName = "Patil", Gender = "Male", BirthDate = new DateTime(2008, 1, 20), Age = 15, Class = "12th", Address = "Pune" });
                StudentList.Add(new StudentTable { FirstName = "Ranjeet", LastName = "Jadhav", Gender = "Male", BirthDate = new DateTime(2006, 8, 06), Age = 17, Class = "10th", Address = "Mumbai" });
            };
        }

        public StoreData(List<StudentTable> SList)
        {
            StudentList.AddRange(SList);
        }
    }
       
    
}