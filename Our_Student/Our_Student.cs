using System.Text;
using System.Windows.Forms;

namespace Our_Student
{
    public partial class Our_Student : Form
    {
        // local List
        public List<StudentTable> ST1 = new List<StudentTable>();

        // Parameterless constructor
        public Our_Student()
        {
            InitializeComponent();
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();
            //Display default member on datagridview
            ST1.Add(new StudentTable { FirstName = "Ajay", LastName = "Patil", Gender = "Male", BirthDate = new DateTime(2008, 1, 20), Age = 15, Class = "12th", Address = "Pune" });
            ST1.Add(new StudentTable { FirstName = "Ranjeet", LastName = "Jadhav", Gender = "Male", BirthDate = new DateTime(2006, 8, 06), Age = 17, Class = "10th", Address = "Mumbai" });

            // Used for 
            foreach (var student in ST1)
            {
                dataGridView1.Rows.Add(student.FirstName.Trim(),
                                       student.LastName.Trim(),
                                       student.Gender.Trim(),
                                       student.Age,
                                       student.Class.Trim());
            }
            //Display two rows
            if (dataGridView1.Rows.Count > 2)
                dataGridView1.Rows[2].Selected = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Default Row Selection

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;

                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        //Parameterized constructor recieves List 
        public Our_Student(List<StudentTable> studentList)
        {
            InitializeComponent();
            ST1 = studentList;
            //ST1.AddRange(studentList);
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();
            foreach (var student in ST1)
            {
                dataGridView1.Rows.Add(student.FirstName.Trim(),
                    student.LastName.Trim(),
                    student.Gender.Trim(),
                    student.Age,
                    student.Class.Trim());
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //public int dataGridViewCount()
        //{
        //    return dataGridView1.Rows.Count;
        //}

        //Add Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student Add = new Add_Student(ST1);
            Add.Show();
        }

        //Search Box
        private void text_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_Search.Text.ToLower();

            // Filter the list based on the search text
            List<StudentTable> filteredList = new List<StudentTable>();
            foreach (var student in ST1)
            {
                if (student.FirstName.ToLower().Contains(searchText) ||
                    student.LastName.ToLower().Contains(searchText) ||
                    student.Age.ToString().Contains(searchText))
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

        // Double click on cell 
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Student Edit = new Edit_Student();

            //Passing Row of List And Index to Method
            OpenAddStudentFormForEdit(ST1[e.RowIndex], e.RowIndex);
            this.Hide();
        }


        private void OpenAddStudentFormForEdit(StudentTable student, int Index)
        {

            //Passing Row of List And Index to Constructor of the edit class
            Edit_Student editForm = new Edit_Student(student, Index);
            editForm.studentList.AddRange(ST1);
            editForm.Show();
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.SteelBlue, ButtonBorderStyle.Solid);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
