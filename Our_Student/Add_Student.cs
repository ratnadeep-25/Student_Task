using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            TFR1.Text = "";
            TFR2.Text = "";
            TRF3.Text = "";
            TRF4.Text = "";
            TRF5.Text = "";
        }

        public Add_Student(List<StudentTable> SList)
        {
            InitializeComponent();
            this.studentList = SList;
            TFR1.Text = "";
            TFR2.Text = "";
            TRF3.Text = "";
            TRF4.Text = "";
            TRF5.Text = "";
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        //Save Button
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string firstName = text_FirstName.Text;
            string lastName = text_LastName.Text;
            //if field is empty then "This Field is Required" is displayed below the Textbox
            if (string.IsNullOrWhiteSpace(text_FirstName.Text) || text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15 ||firstName.Contains("  "))
            {
                if (string.IsNullOrWhiteSpace(text_FirstName.Text) )
                {
                    TFR1.Text = "This field is required";
                    TFR1.ForeColor = Color.Red;
                }
                if (firstName.Contains("  "))
                {
                    TFR1.Text = "Consecutive spaces are not allowed.";
                    TFR1.ForeColor = Color.Red;
                }
                else
                {
                    TFR1.Text = "First Name must be between 3 and 15 characters.";
                    TFR1.ForeColor = Color.Red;
                }

            }
            else
            {
                TFR1.Text = "";
            }

            //Last Name
            if (string.IsNullOrWhiteSpace(text_LastName.Text) || text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18 || lastName.Contains("  "))
            {
                

                //if field is empty then "This Field is Required" is displayed below the Textbox   
                if (string.IsNullOrWhiteSpace(text_LastName.Text))
                {
                    TFR2.Text = "This field is required";
                    TFR2.ForeColor = Color.Red;
                }
                if (lastName.Contains("  "))
                {
                    TFR2.Text = "Consecutive spaces are not allowed.";
                    TFR2.ForeColor = Color.Red;
                }
                else
                {
                    TFR2.Text = "Last Name must be between 3 and 18 characters.";
                    TFR2.ForeColor = Color.Red;
                }
            }
            else
            {
                TFR2.Text = "";
            }

            //Gender
            if (string.IsNullOrWhiteSpace(combo_Gender.Text) || combo_Gender.Text != "Male" && combo_Gender.Text != "Female" && combo_Gender.Text != "Other")
            {
                if (string.IsNullOrWhiteSpace(combo_Gender.Text))
                {
                    TRF3.Text = "This field is required";
                    TRF3.ForeColor = Color.Red;
                }
                else
                {
                    TRF3.Text = "Please select valid data";
                    TRF3.ForeColor = Color.Red;
                }
            }
            else
            {
                TRF3.Text = "";
            }



            //if Age should be between 5 to 99 years
            if (!int.TryParse(text_Age.Text, out int age) || age < 5 || age > 99)
            {
                if (age == 0)
                {
                    TRF5.Text = "This field is required";
                    TRF5.ForeColor = Color.Red;
                }
                else
                {
                    TRF5.Text = "Age must be in between 5 to 99";
                    TRF5.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {

                TRF5.Text = "";
            }
            DateTime Time1 = DateTime.Today;

            if (dateTimePicker2.Value.Date >= Time1)
            {
                if (dateTimePicker2.Value.Date >= Time1)
                {
                    TRF4.Text = "This field is required";
                    TRF4.ForeColor = Color.Red;
                }
            }
            else
            {
                TRF4.Text = "";
            }


            if (string.IsNullOrWhiteSpace(text_FirstName.Text) || text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15 || firstName.Contains("  ") ||
                string.IsNullOrWhiteSpace(text_LastName.Text) || text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18 || lastName.Contains("  ") ||
                string.IsNullOrWhiteSpace(combo_Gender.Text) || combo_Gender.Text != "Male" && combo_Gender.Text != "Female" && combo_Gender.Text != "Other" ||
                age < 5 || age > 99 && age == 0 && dateTimePicker2.Value.Date >= Time1)
            {
                return;                             // return stay on same page
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

            // Adding Student class obj to the studentList
            studentList.Add(STO);

            // Sending List to the Our Student class constructor
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

        // only accepts aplphabets space and backspace
        private void text_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
            //if (text_FirstName.TextLength > 30)
            //    text_FirstName.Text = "";

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
            Our_Student OS1 = new Our_Student(studentList);
            OS1.Show();
        }


        //Add age also change the date timepicker
        private void text_Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(text_Age.Text, "^[0-9]*$"))
                {
                    TRF5.Text = "Please enter only numbers in Age.";

                    TRF5.ForeColor = Color.Red;
                    text_Age.Text = string.Empty;
                }

                if (int.TryParse(text_Age.Text, out int age))
                {
                    DateTime todayDate = DateTime.Today;
                    DateTime birthDate = todayDate.AddYears(-age);

                    if (birthDate.Year >= 1900 && birthDate.Year <= DateTime.Now.Year)
                    {
                        // Update the DateTimePicker value to the calculated birth date
                        dateTimePicker2.Value = birthDate;
                    }

                }
                else
                {
                    TRF5.Text = $"Age Should be between{"\n"} 5 to 99 Years";
                    TRF5.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Age Should be between 5 to 99 Years");
                text_Age.Text = "";
                //TFR1.Text = "";
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

        //Leave Events
        private void text_FirstName_Leave(object sender, EventArgs e)
        {

            //if (text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15 || text_FirstName.Text.Length != null)
            //{
            //    TFR1.Text = "First Name must be between 3 and 15 characters.";
            //    TFR1.ForeColor = Color.Red;
            //}
            //else
            //{
            //    TFR1.Text = "";
            //}
        }

        private void text_LastName_Leave(object sender, EventArgs e)
        {
            //if (text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18)
            //{
            //    TFR2.Text = "Last Name must be between 3 and 18 characters.";
            //    TFR2.ForeColor = Color.Red;
            //}
            //else
            //{
            //    TFR2.Text = "";
            //}
        }

        private void combo_Gender_Leave(object sender, EventArgs e)
        {
            //if (combo_Gender.Text != "Male" && combo_Gender.Text != "Female" && combo_Gender.Text != "Other")
            //{
            //    TRF3.Text = "Please select valid data";
            //    TRF3.ForeColor = Color.Red;
            //}
            //else
            //{ TRF3.Text = ""; }

        }

        private void text_Age_Leave(object sender, EventArgs e)
        {
            //if (!int.TryParse(text_Age.Text, out int age) || age < 5 || age > 99 && age == 0)
            //{
            //    TRF5.Text = "Age must be in between 5 to 99";
            //    TRF5.ForeColor = Color.Red;
            //}
            //else
            //{
            //    TRF5.Text = "";
            //}
        }



        //Panel used for set borders
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Panel p = sender as Panel;
            //ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.SteelBlue, ButtonBorderStyle.Solid);
            ////ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void combo_Gender_Click(object sender, EventArgs e)
        {
        }

        private void groupBox_AddStudent_Enter(object sender, EventArgs e)
        {

        }

        private void text_FirstName_TextChanged(object sender, EventArgs e)
        {
            //string firstName = text_FirstName.Text; 
            //if (firstName.Contains("  "))
            //{
            //    TFR1.Text = "this field required";
            //    TFR1.ForeColor = Color.Red;
            //}
        }
    }
}
