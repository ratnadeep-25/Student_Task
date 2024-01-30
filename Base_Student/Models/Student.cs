namespace Base_Student.Models
{
    public class Student
    {
        public const string FirstNameLbl = "First Name";
        public const string LastNameLbl = "Last Name";
        public const string GenderLbl = "Gender";
        public const string DOBLbl = "Date Of Birth";
        public const string AgeLbl = "Age";
        public const string ClassLbl = "Class";
        public const string AddressLbl = "Address";
        public const string Yeartxt = " years";
        public const string OurStdLbl = "Our Students";
        public const string AddBtnTxt = "+ Add";
        public const string SaveBtnTxt = "Save";
        public const string DeleteBtnTxt = "Delete";
        public const string CancelBtnTxt = "Cancel";
        public const string AddStdLbl = "Add Student";
        public const string EditStdLbl = "Edit Student";
        public const string DeleteStdCfm = "Are you sure you want to delete this student record?";

        public const string SearchPlacehr = "Search...";
        public const string FirstNamePlacehr = "Please Enter Your First Name...";
        public const string LastNamePlacehr = "Please Enter Your Last Name...";
        public const string GenderPlacehr = "Please Select Gender...";
        public const string AgePlacehr = "Please Enter Your Age...";
        public const string ClassPlacehr = "Please Enter Your Class...";
        public const string AddressPlacehr = "Please Enter Your Address...";

        // class Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string? Class { get; set; }
        public string Address { get; set; }
        public int OriginalIndex { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Today;

        // Error Properties
        public string FirstNameError { get; set; }
        public string LastNameError { get; set; }
        public string AgeError { get; set; }
        public string GenderError { get; set; }
        public string DOBError { get; set; }

        // Parameretized constructor
        public Student(string firstName, string lastName, string gender, string age, string _Class, string address, int originalIndex)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Class = _Class;
            Address = address;
            OriginalIndex = originalIndex;
        }

        public Student()
        {
            // Initialize error message properties
            FirstNameError = string.Empty;
            LastNameError = string.Empty;
            AgeError = string.Empty;
            GenderError = string.Empty;
            DOBError = string.Empty;
        }
    }
}
