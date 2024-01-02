using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Student
{
    public partial class Edit_Student : Form
    {
        StudentTable TableStudent = new StudentTable();

        //List for Adding student data in list of Student table class
        public List<StudentTable> studentList = new List<StudentTable>();

        // Property to access studentList from other forms
        public List<StudentTable> StudentList
        {
            get { return studentList; }
        }
        public Edit_Student()
        {
            InitializeComponent();
        }

        public Edit_Student(StudentTable TableStudent)
        {
            InitializeComponent();
            this.TableStudent = TableStudent;
            text_FirstName.Text = TableStudent.FirstName;
            text_LastName.Text = TableStudent.LastName;
            combo_Gender.Text = TableStudent.Gender;
            dateTimePicker2.Value = TableStudent.BirthDate.Date;
            text_Age.Text = TableStudent.Age.ToString();
            text_Class.Text = TableStudent.Class;
            textBox_Address.Text = TableStudent.Address;
        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //if field is not filled then "This Field is Required" is displayed below the Textbox
            if (string.IsNullOrWhiteSpace(text_FirstName.Text))
            {
                TFR1.Text = "This field is required";
                TFR1.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(text_LastName.Text))
            {
                TFR2.Text = "This field is required";
                TFR2.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(combo_Gender.Text))
            {
                TRF3.Text = "This field is required";
                TRF3.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker2.Text))
            {
                TRF4.Text = "This field is required";
                TRF4.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(text_Age.Text))
            {
                TRF5.Text = "This field is required";
                TRF5.ForeColor = Color.Red;
            }


            if (text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15)
            {
                MessageBox.Show("First Name must be between 3 and 15 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18)
            {
                MessageBox.Show("Last Name must be between 3 and 18 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int Age = int.Parse(text_Age.Text);

            if (Age <= 5 || Age >= 99)
            {
                MessageBox.Show("Age Must be between 5 to 99", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Save/ Update the data in the Object of the StudentTable 
            TableStudent.FirstName = text_FirstName.Text;
            TableStudent.LastName = text_LastName.Text;
            TableStudent.Gender = combo_Gender.Text;
            TableStudent.BirthDate = dateTimePicker2.Value;
            TableStudent.Age = int.Parse(text_Age.Text);
            TableStudent.Class = text_Class.Text;

            MessageBox.Show($"student Updated successfully: \n Name : {TableStudent.FirstName} {TableStudent.LastName}\n" +
                                                                $" Gender : {TableStudent.Gender}\n " +
                                                                $"Age : {TableStudent.Age} \n " +
                                                                $"Class : {TableStudent.Class}\n" +
                                                                $"Address: {TableStudent.Address}\n" +
                                                                $"BirthDate : {TableStudent.BirthDate}");

            Our_Student Our_Student2 = new Our_Student(studentList);
            this.Hide();
            Our_Student2.Show();

            // Clear textboxes after adding a student
            text_FirstName.Clear();
            text_LastName.Clear();
            combo_Gender.Items.Clear();
            dateTimePicker2 = new DateTimePicker();
            text_Age.Clear();
            text_Class.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            text_FirstName.Text = TableStudent.FirstName;
            text_LastName.Text = TableStudent.LastName;
            combo_Gender.Text = TableStudent.Gender;
            dateTimePicker2.Value = TableStudent.BirthDate;
            text_Age.Text = TableStudent.Age.ToString();
            text_Class.Text = TableStudent.Class;
            textBox_Address.Text = TableStudent.Address;



            // open the Our_Student Page 
            //this.Hide();
            //Our_Student OS1 = new Our_Student();
            //OS1.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime TimeStart = Convert.ToDateTime(dateTimePicker2.Value);
            DateTime TimeEnd = DateTime.Today;

            TimeSpan Span = TimeEnd - TimeStart;
            var InYears = Math.Truncate(Span.TotalDays / 365);
            text_Age.Text = Convert.ToString(InYears);
        }

        private void text_Age_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(text_Age.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers in Age.");
                text_Age.Text = string.Empty;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure you want to delete this student records", "Our_Students", MessageBoxButtons.YesNo);

            if (Exit == DialogResult.Yes)
            {
                studentList.RemoveAt(studentList.Count - 1);
                MessageBox.Show("Student record has been deleted");
            }

            this.Hide();
            Our_Student OS1 = new Our_Student(studentList);
            OS1.Show();
        }

        private void text_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accepts aplphabets space and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
        }

        private void text_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accepts aplphabets space and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
        }

        private void label_EditStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
