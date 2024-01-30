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



        Our_Student O6 = new Our_Student();
        int Index;

        //Parameterless constructor
        public Edit_Student()
        {
            InitializeComponent();

            TFR1.Text = "";
            TFR2.Text = "";
            TRF3.Text = "";
            TRF4.Text = "";
            TRF5.Text = "";
        }
        DateTime BD;
        //Parameterized Constuctor Recieves Obj & index of dataGridView
        public Edit_Student(StudentTable TableStudent, int Index)
        {
            InitializeComponent();
            this.TableStudent = TableStudent;
            text_FirstName.Text = TableStudent.FirstName.Trim();
            text_LastName.Text = TableStudent.LastName.Trim();
            combo_Gender.Text = TableStudent.Gender.Trim();
            text_Age.Text = TableStudent.Age.ToString();
            dateTimePicker2.Value = TableStudent.BirthDate.Date;
            BD = TableStudent.BirthDate.Date;
            text_Class.Text = TableStudent.Class.Trim();
            textBox_Address.Text = TableStudent.Address.Trim();
            this.Index = Index;

            //MessageBox.Show($"{TableStudent.BirthDate.Date} , {dateTimePicker2.Value} ,{BD}");
            TFR1.Text = "";
            TFR2.Text = "";
            TRF3.Text = "";
            TRF4.Text = "";
            TRF5.Text = "";
        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime TimeStart = Convert.ToDateTime(dateTimePicker2.Value);
            DateTime TimeEnd = DateTime.Today;

            //time span is duration between TimeEnd & TimeStart
            TimeSpan Span = TimeEnd - TimeStart;
            var InYears = Math.Truncate(Span.TotalDays / 365);
            text_Age.Text = Convert.ToString(InYears);

        }


        //used to validate age is number & not accepts other 
        private void text_Age_TextChanged_1(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(text_Age.Text, "^[0-9]*$"))
            {
                TRF5.Text = "Please enter only numbers in Age.";

                TRF5.ForeColor = Color.Red;
                text_Age.Text = string.Empty;
            }

            //Change datetimepicker value as age changes
            if (int.TryParse(text_Age.Text, out int age))
            {
                DateTime todayDate = DateTime.Today;
                DateTime birthDate = todayDate.AddYears(-age);

                // Update the DateTimePicker value to the calculated birth date
                dateTimePicker2.Value = birthDate;


            }
        }

        //Delete Button
        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            if (O6.dataGridView1.SelectedRows.Count > 0)
            //if (O6.dataGridViewCount()>0)
            {
                DialogResult Exit;
                // Asks before delete record of selected row
                Exit = MessageBox.Show($"Are you sure you want to delete this student record of Name : {TableStudent.FirstName} {TableStudent.LastName}", "Our_Students", MessageBoxButtons.YesNo);

                if (Exit == DialogResult.Yes)
                {
                    studentList.RemoveAt(Index);
                }
                this.Hide();
                Our_Student OS1 = new Our_Student(studentList);
                OS1.Show();
            }
        }

        //Save Button
        private void btn_Save_Click_1(object sender, EventArgs e)
        {

            //if field is empty then "This Field is Required" is displayed below the Textbox
            if (string.IsNullOrWhiteSpace(text_FirstName.Text) || text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15)
            {
                if (string.IsNullOrWhiteSpace(text_FirstName.Text))
                {
                    TFR1.Text = "This field is required";
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
            //if field is empty then "This Field is Required" is displayed below the Textbox
            if (string.IsNullOrWhiteSpace(text_LastName.Text) || text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18)
            {
                if (string.IsNullOrWhiteSpace(text_LastName.Text))
                {
                    TFR2.Text = "This field is required";
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
                    //return;
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

                    //return;
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

            if (string.IsNullOrWhiteSpace(text_FirstName.Text) || text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15 ||
                string.IsNullOrWhiteSpace(text_LastName.Text) || text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18 ||
                string.IsNullOrWhiteSpace(combo_Gender.Text) || combo_Gender.Text != "Male" && combo_Gender.Text != "Female" && combo_Gender.Text != "Other" ||
                age < 5 || age > 99 && age == 0 && dateTimePicker2.Value.Date >= Time1)
            {
                return;
            }

            //Save/ Update the data in the Object of the StudentTable 
            TableStudent.FirstName = text_FirstName.Text.Trim();
            TableStudent.LastName = text_LastName.Text.Trim();
            TableStudent.Gender = combo_Gender.Text.Trim();
            TableStudent.BirthDate = dateTimePicker2.Value;
            TableStudent.Age = int.Parse(text_Age.Text);
            TableStudent.Class = text_Class.Text.Trim();
            TableStudent.Address = textBox_Address.Text.Trim();

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
            textBox_Address.Clear();
        }

        //Cancel Button
        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            text_FirstName.Text = TableStudent.FirstName.Trim();
            text_LastName.Text = TableStudent.LastName.Trim();
            combo_Gender.Text = TableStudent.Gender.Trim();
            dateTimePicker2.Value = TableStudent.BirthDate;
            text_Age.Text = TableStudent.Age.ToString();
            text_Class.Text = TableStudent.Class.Trim();
            textBox_Address.Text = TableStudent.Address.Trim();



            // open the Our_Student Page 
            this.Hide();
            Our_Student OS1 = new Our_Student(studentList);
            OS1.Show();
        }

        private void text_FirstName_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            // only accepts aplphabets space and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
        }

        private void text_LastName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // only accepts aplphabets space and backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                //supresses the keyword if its not valid
                e.Handled = true;
        }

        //Leave Events
        private void text_FirstName_Leave_1(object sender, EventArgs e)
        {
            if (text_FirstName.Text.Length < 3 || text_FirstName.Text.Length > 15)
            {
                TFR1.Text = "First Name must be between 3 and 15 characters.";
                TFR1.ForeColor = Color.Red;
            }
            else
            {
                TFR1.Text = "";
            }

        }

        private void text_LastName_Leave_1(object sender, EventArgs e)
        {
            if (text_LastName.Text.Length < 3 || text_LastName.Text.Length > 18)
            {
                TFR2.Text = "Last Name must be between 3 and 18 characters.";
                TFR2.ForeColor = Color.Red;
            }
            else
            {
                TFR2.Text = "";
            }
        }

        private void combo_Gender_Leave_1(object sender, EventArgs e)
        {
            if (combo_Gender.Text != "Male" && combo_Gender.Text != "Female" && combo_Gender.Text != "Other")
            {
                TRF3.Text = "Please select valid data";
                TRF3.ForeColor = Color.Red;
            }
            else
            { TRF3.Text = ""; }
        }

        private void text_Age_Leave_1(object sender, EventArgs e)
        {
            if (!int.TryParse(text_Age.Text, out int age) || age < 5 || age > 99 && age == 0)
            {
                TRF5.Text = "Age must be in between 5 to 99";
                TRF5.ForeColor = Color.Red;
            }
            else
            {
                TRF5.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.SteelBlue, ButtonBorderStyle.Solid);
            //ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
            //ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void groupBox_EditStudent_Enter(object sender, EventArgs e)
        {

        }


        //--------------------End of code------------------------------------//
    }
}
