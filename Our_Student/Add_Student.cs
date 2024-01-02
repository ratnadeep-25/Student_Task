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

    public partial class Add_Student : Form
    {
        //List for Adding student data in list of Student table class
        public List<StudentTable> studentList = new List<StudentTable>();

        // Property to access studentList from other forms
        public List<StudentTable> StudentList
        {
            get { return studentList; }
        }

        public Add_Student()
        {
            InitializeComponent();
        }

        public Add_Student(List<StudentTable> SList)
        {
            InitializeComponent();
            this.studentList = SList;
        }

        private void Add_Student_Load(object sender, EventArgs e)
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



            DateTime birthDate = dateTimePicker2.Value.Date;
            ////for add student  obj of Person Class
            StudentTable STO = new StudentTable
            {
                FirstName = text_FirstName.Text,
                LastName = text_LastName.Text,
                Gender = combo_Gender.Text,
                BirthDate = birthDate,
                Age = int.Parse(text_Age.Text),
                Class = text_Class.Text,
                Address = textBox_Address.Text
            };


            studentList.Add(STO);
            Our_Student Our_Student2 = new Our_Student(studentList);

            MessageBox.Show($"New student added successfully: \n Name : {STO.FirstName} {STO.LastName}\n" +
                                                                $" Gender : {STO.Gender}\n " +
                                                                $"Age : {STO.Age} \n " +
                                                                $"Class : {STO.Class}\n"+
                                                                $"Address: {STO.Address}"+
                                                                $"BirthDate : {STO.BirthDate}");
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

        // only accepts aplphabets space and backspace
        private void text_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
        }

        // only accepts alphabets space and backspace
        private void text_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
        }

        //Delete button in add which deletes last data of list 
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure you want to delete previous student records", "Our_Students", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                studentList.RemoveAt(studentList.Count - 1);
                MessageBox.Show("Student record has been deleted");
            }
            Our_Student O2 = new Our_Student(studentList);

            this.Hide();
            O2.Show();
        }

        //cancel button 
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            text_FirstName.Text = "Please enter First Name";
            text_LastName.Text = "Please enter Last Name";
            combo_Gender.Text = "Please enter Gender";
            dateTimePicker2 = new DateTimePicker();
            text_Age.Clear();
            text_Class.Text = "Please enter Class";
            textBox_Address.Text = "Please enter Address";

            // open the Our_Student Page 
            this.Hide();
            Our_Student OS1 = new Our_Student();
            OS1.Show();
        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        //Add age also change the date timepicker
        private void text_Age_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(text_Age.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please enter only numbers in Age.");
                text_Age.Text = string.Empty;
            }
            
            if(int.TryParse(text_Age.Text, out int age))
            {
                DateTime todayDate = DateTime.Today;
                DateTime birthDate = todayDate.AddYears(-age);

                // Update the DateTimePicker value to the calculated birth date
                dateTimePicker2.Value = birthDate;

            }
        }

        // selects birth date and change the age textbox by calculating
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime TimeStart = Convert.ToDateTime(dateTimePicker2.Value);
            DateTime TimeEnd = DateTime.Today;

            TimeSpan Span = TimeEnd - TimeStart;
            var InYears = Math.Truncate(Span.TotalDays / 365);
            text_Age.Text = Convert.ToString(InYears);

        }
    }
}
