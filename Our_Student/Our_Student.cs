using System.Text;
using System.Windows.Forms;

namespace Our_Student
{
    public partial class Our_Student : Form
    {
        public List<StudentTable> ST1 = new List<StudentTable>();
        public Our_Student()
        {
            InitializeComponent();

            //Display default member on datagridview
            ST1.Add(new StudentTable { FirstName = "Ajay", LastName = "Patil", Gender = "Male", BirthDate = new DateTime(2008,1,20), Age = 19, Class = "12th",Address="Pune" });
            ST1.Add(new StudentTable { FirstName = "Ranjeet", LastName = "Jadhav", Gender = "Male", BirthDate = new DateTime(2006, 8, 06), Age = 19, Class = "12th", Address = "Mumbai" });

            // Used for 
            foreach (var student in ST1)
            {
                dataGridView1.Rows.Add(student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Class);
            }
            if (dataGridView1.Rows.Count > 2)
                dataGridView1.Rows[2].Selected = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;

                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }
        public Our_Student(List<StudentTable> studentList)
        {
            InitializeComponent();
            ST1 = studentList;
            //ST1.AddRange(studentList);

            //dataGridView1.Rows.Clear();
            foreach (var student in ST1)
            {
                dataGridView1.Rows.Add(student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Class);
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student Add = new Add_Student(ST1);
            Add.Show();
        }

        private void text_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_Search.Text.ToLower();

            // Filter the list based on the search text
            List<StudentTable> filteredList = new List<StudentTable>();
            foreach (var student in ST1)
            {
                if (student.FirstName.ToLower().Contains(searchText) ||
                    student.LastName.ToLower().Contains(searchText) ||
                    int.TryParse(searchText, out int age) && student.Age == age ||
                    student.Gender.ToLower().Contains(searchText) ||
                    student.Class.ToLower().Contains(searchText))
                {
                    filteredList.Add(student);
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Clear();

            foreach (var student in filteredList)
            {
                dataGridView1.Rows.Add(student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Age,
                    student.Class);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Student Edit = new Edit_Student();
            //Edit.label_AddStudent.Text=
            OpenAddStudentFormForEdit(ST1[e.RowIndex]);
            this.Hide();
        }

        private void OpenAddStudentFormForEdit(StudentTable student)
        {
            Edit_Student editForm = new Edit_Student(student);
            editForm.studentList.AddRange(ST1);
            editForm.Show();
        }

    }
}
