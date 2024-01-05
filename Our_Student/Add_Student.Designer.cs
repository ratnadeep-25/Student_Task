namespace Our_Student
{
    partial class Add_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            combo_Gender = new ComboBox();
            textBox_Address = new TextBox();
            TRF5 = new Label();
            TRF4 = new Label();
            TRF3 = new Label();
            TFR2 = new Label();
            TFR1 = new Label();
            label5 = new Label();
            label_years = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            text_Class = new TextBox();
            text_Age = new TextBox();
            text_LastName = new TextBox();
            text_FirstName = new TextBox();
            btn_Cancel = new Button();
            btn_Delete = new Button();
            label_Address = new Label();
            label_Class = new Label();
            label_Age = new Label();
            label_LastName = new Label();
            label_Gender = new Label();
            label_DateOfBirth = new Label();
            label_FirstName = new Label();
            label_AddStudent = new Label();
            btn_Save = new Button();
            groupBox_AddStudent = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            panel2 = new Panel();
            panel_FirstName = new Panel();
            panel_LastName = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1 = new Panel();
            groupBox_AddStudent.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // combo_Gender
            // 
            combo_Gender.DisplayMember = "Please select Gender";
            combo_Gender.DropDownHeight = 120;
            combo_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo_Gender.ForeColor = SystemColors.WindowText;
            combo_Gender.IntegralHeight = false;
            combo_Gender.ItemHeight = 32;
            combo_Gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            combo_Gender.Location = new Point(240, 290);
            combo_Gender.MaximumSize = new Size(240, 0);
            combo_Gender.MinimumSize = new Size(240, 0);
            combo_Gender.Name = "combo_Gender";
            combo_Gender.RightToLeft = RightToLeft.No;
            combo_Gender.Size = new Size(240, 40);
            combo_Gender.TabIndex = 3;
            combo_Gender.Click += combo_Gender_Click;
            combo_Gender.Leave += combo_Gender_Leave;
            // 
            // textBox_Address
            // 
            textBox_Address.BorderStyle = BorderStyle.FixedSingle;
            textBox_Address.Font = new Font("Segoe UI", 11F);
            textBox_Address.Location = new Point(3, 3);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.PlaceholderText = " Please enter address";
            textBox_Address.RightToLeft = RightToLeft.No;
            textBox_Address.Size = new Size(500, 100);
            textBox_Address.TabIndex = 7;
            // 
            // TRF5
            // 
            TRF5.AutoSize = true;
            TRF5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TRF5.ForeColor = Color.Red;
            TRF5.Location = new Point(625, 401);
            TRF5.Name = "TRF5";
            TRF5.Size = new Size(45, 21);
            TRF5.TabIndex = 29;
            TRF5.Text = "TRF5";
            // 
            // TRF4
            // 
            TRF4.AutoSize = true;
            TRF4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TRF4.ForeColor = Color.Red;
            TRF4.Location = new Point(240, 402);
            TRF4.Name = "TRF4";
            TRF4.Size = new Size(45, 21);
            TRF4.TabIndex = 28;
            TRF4.Text = "TRF4";
            // 
            // TRF3
            // 
            TRF3.AutoSize = true;
            TRF3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TRF3.ForeColor = Color.Red;
            TRF3.Location = new Point(240, 332);
            TRF3.Name = "TRF3";
            TRF3.Size = new Size(45, 21);
            TRF3.TabIndex = 27;
            TRF3.Text = "TRF3";
            // 
            // TFR2
            // 
            TFR2.AutoSize = true;
            TFR2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TFR2.ForeColor = Color.Red;
            TFR2.Location = new Point(240, 262);
            TFR2.Name = "TFR2";
            TFR2.Size = new Size(45, 21);
            TFR2.TabIndex = 26;
            TFR2.Text = "TFR2";
            // 
            // TFR1
            // 
            TFR1.AutoSize = true;
            TFR1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TFR1.ForeColor = Color.Red;
            TFR1.Location = new Point(240, 192);
            TFR1.Name = "TFR1";
            TFR1.Size = new Size(45, 21);
            TFR1.TabIndex = 25;
            TFR1.Text = "TFR1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(136, 290);
            label5.Name = "label5";
            label5.Size = new Size(29, 38);
            label5.TabIndex = 23;
            label5.Text = "*";
            // 
            // label_years
            // 
            label_years.AutoSize = true;
            label_years.Location = new Point(687, 370);
            label_years.Name = "label_years";
            label_years.Size = new Size(53, 25);
            label_years.TabIndex = 22;
            label_years.Text = "years";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(578, 360);
            label4.Name = "label4";
            label4.Size = new Size(29, 38);
            label4.TabIndex = 20;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(176, 220);
            label3.Name = "label3";
            label3.Size = new Size(29, 38);
            label3.TabIndex = 19;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(200, 360);
            label2.Name = "label2";
            label2.Size = new Size(29, 38);
            label2.TabIndex = 18;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(175, 150);
            label1.Name = "label1";
            label1.Size = new Size(29, 38);
            label1.TabIndex = 0;
            label1.Text = "*";
            // 
            // text_Class
            // 
            text_Class.BorderStyle = BorderStyle.FixedSingle;
            text_Class.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Class.ForeColor = SystemColors.WindowText;
            text_Class.Location = new Point(240, 430);
            text_Class.Name = "text_Class";
            text_Class.PlaceholderText = "  Please enter class";
            text_Class.RightToLeft = RightToLeft.No;
            text_Class.Size = new Size(241, 39);
            text_Class.TabIndex = 6;
            // 
            // text_Age
            // 
            text_Age.BorderStyle = BorderStyle.FixedSingle;
            text_Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Age.Location = new Point(625, 360);
            text_Age.Name = "text_Age";
            text_Age.RightToLeft = RightToLeft.No;
            text_Age.Size = new Size(55, 39);
            text_Age.TabIndex = 5;
            text_Age.TextChanged += text_Age_TextChanged;
            text_Age.Leave += text_Age_Leave;
            // 
            // text_LastName
            // 
            text_LastName.BorderStyle = BorderStyle.FixedSingle;
            text_LastName.Font = new Font("Segoe UI", 11F);
            text_LastName.ForeColor = SystemColors.WindowText;
            text_LastName.Location = new Point(240, 220);
            text_LastName.MaximumSize = new Size(500, 40);
            text_LastName.MinimumSize = new Size(500, 40);
            text_LastName.Name = "text_LastName";
            text_LastName.PlaceholderText = "  Please enter Last Name";
            text_LastName.RightToLeft = RightToLeft.No;
            text_LastName.Size = new Size(500, 40);
            text_LastName.TabIndex = 2;
            text_LastName.KeyPress += text_LastName_KeyPress;
            text_LastName.Leave += text_LastName_Leave;
            // 
            // text_FirstName
            // 
            text_FirstName.BorderStyle = BorderStyle.FixedSingle;
            text_FirstName.Font = new Font("Segoe UI", 11F);
            text_FirstName.ForeColor = SystemColors.WindowText;
            text_FirstName.Location = new Point(240, 150);
            text_FirstName.MaximumSize = new Size(500, 40);
            text_FirstName.MinimumSize = new Size(500, 40);
            text_FirstName.Name = "text_FirstName";
            text_FirstName.PlaceholderText = "  Please enter First Name";
            text_FirstName.RightToLeft = RightToLeft.No;
            text_FirstName.Size = new Size(500, 40);
            text_FirstName.TabIndex = 1;
            text_FirstName.KeyPress += text_FirstName_KeyPress;
            text_FirstName.Leave += text_FirstName_Leave;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = SystemColors.ScrollBar;
            btn_Cancel.Font = new Font("Segoe UI", 12F);
            btn_Cancel.Location = new Point(620, 640);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(120, 50);
            btn_Cancel.TabIndex = 8;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = SystemColors.ScrollBar;
            btn_Delete.Font = new Font("Segoe UI", 12F);
            btn_Delete.ForeColor = Color.Red;
            btn_Delete.Location = new Point(50, 640);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(120, 50);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_Address.Location = new Point(50, 500);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(100, 32);
            label_Address.TabIndex = 14;
            label_Address.Text = "Address";
            label_Address.UseMnemonic = false;
            // 
            // label_Class
            // 
            label_Class.AutoSize = true;
            label_Class.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_Class.Location = new Point(50, 430);
            label_Class.Name = "label_Class";
            label_Class.Size = new Size(68, 32);
            label_Class.TabIndex = 14;
            label_Class.Text = "Class";
            label_Class.UseMnemonic = false;
            // 
            // label_Age
            // 
            label_Age.AutoSize = true;
            label_Age.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_Age.Location = new Point(530, 360);
            label_Age.Name = "label_Age";
            label_Age.Size = new Size(57, 32);
            label_Age.TabIndex = 15;
            label_Age.Text = "Age";
            // 
            // label_LastName
            // 
            label_LastName.AutoSize = true;
            label_LastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_LastName.Location = new Point(50, 220);
            label_LastName.Name = "label_LastName";
            label_LastName.Size = new Size(130, 32);
            label_LastName.TabIndex = 11;
            label_LastName.Text = "Last Name";
            label_LastName.UseMnemonic = false;
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_Gender.Location = new Point(50, 290);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(94, 32);
            label_Gender.TabIndex = 12;
            label_Gender.Text = "Gender";
            label_Gender.UseMnemonic = false;
            // 
            // label_DateOfBirth
            // 
            label_DateOfBirth.AutoSize = true;
            label_DateOfBirth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_DateOfBirth.Location = new Point(50, 360);
            label_DateOfBirth.Name = "label_DateOfBirth";
            label_DateOfBirth.Size = new Size(160, 32);
            label_DateOfBirth.TabIndex = 13;
            label_DateOfBirth.Text = "Date Of Birth";
            label_DateOfBirth.UseMnemonic = false;
            // 
            // label_FirstName
            // 
            label_FirstName.AutoSize = true;
            label_FirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label_FirstName.Location = new Point(50, 150);
            label_FirstName.Name = "label_FirstName";
            label_FirstName.Size = new Size(132, 32);
            label_FirstName.TabIndex = 10;
            label_FirstName.Text = "First Name";
            label_FirstName.UseMnemonic = false;
            // 
            // label_AddStudent
            // 
            label_AddStudent.AutoSize = true;
            label_AddStudent.Font = new Font("Arial Rounded MT Bold", 26F);
            label_AddStudent.Location = new Point(250, 20);
            label_AddStudent.Name = "label_AddStudent";
            label_AddStudent.Size = new Size(338, 60);
            label_AddStudent.TabIndex = 0;
            label_AddStudent.Text = "Add Student";
            label_AddStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(71, 112, 180);
            btn_Save.Font = new Font("Segoe UI", 12F);
            btn_Save.Location = new Point(487, 640);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(120, 50);
            btn_Save.TabIndex = 7;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // groupBox_AddStudent
            // 
            groupBox_AddStudent.BackColor = SystemColors.Window;
            groupBox_AddStudent.Controls.Add(TRF5);
            groupBox_AddStudent.Controls.Add(TRF4);
            groupBox_AddStudent.Controls.Add(TRF3);
            groupBox_AddStudent.Controls.Add(TFR2);
            groupBox_AddStudent.Controls.Add(TFR1);
            groupBox_AddStudent.Controls.Add(dateTimePicker2);
            groupBox_AddStudent.Controls.Add(label5);
            groupBox_AddStudent.Controls.Add(label_years);
            groupBox_AddStudent.Controls.Add(combo_Gender);
            groupBox_AddStudent.Controls.Add(label4);
            groupBox_AddStudent.Controls.Add(label3);
            groupBox_AddStudent.Controls.Add(label2);
            groupBox_AddStudent.Controls.Add(label1);
            groupBox_AddStudent.Controls.Add(text_Class);
            groupBox_AddStudent.Controls.Add(text_Age);
            groupBox_AddStudent.Controls.Add(text_LastName);
            groupBox_AddStudent.Controls.Add(text_FirstName);
            groupBox_AddStudent.Controls.Add(btn_Cancel);
            groupBox_AddStudent.Controls.Add(btn_Save);
            groupBox_AddStudent.Controls.Add(btn_Delete);
            groupBox_AddStudent.Controls.Add(label_Address);
            groupBox_AddStudent.Controls.Add(label_Class);
            groupBox_AddStudent.Controls.Add(label_Age);
            groupBox_AddStudent.Controls.Add(label_LastName);
            groupBox_AddStudent.Controls.Add(label_Gender);
            groupBox_AddStudent.Controls.Add(label_DateOfBirth);
            groupBox_AddStudent.Controls.Add(label_FirstName);
            groupBox_AddStudent.Controls.Add(label_AddStudent);
            groupBox_AddStudent.Controls.Add(panel2);
            groupBox_AddStudent.Controls.Add(panel_FirstName);
            groupBox_AddStudent.Controls.Add(panel_LastName);
            groupBox_AddStudent.Controls.Add(panel4);
            groupBox_AddStudent.Controls.Add(panel3);
            groupBox_AddStudent.Controls.Add(panel5);
            groupBox_AddStudent.Controls.Add(panel6);
            groupBox_AddStudent.Controls.Add(panel7);
            groupBox_AddStudent.Location = new Point(3, 3);
            groupBox_AddStudent.Name = "groupBox_AddStudent";
            groupBox_AddStudent.Size = new Size(800, 710);
            groupBox_AddStudent.TabIndex = 1;
            groupBox_AddStudent.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker2.CustomFormat = "dd- MM -yyyy ";
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(240, 360);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.No;
            dateTimePicker2.Size = new Size(241, 39);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(textBox_Address);
            panel2.Location = new Point(237, 497);
            panel2.Name = "panel2";
            panel2.Size = new Size(506, 106);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // panel_FirstName
            // 
            panel_FirstName.BackColor = Color.SteelBlue;
            panel_FirstName.Location = new Point(238, 148);
            panel_FirstName.Name = "panel_FirstName";
            panel_FirstName.Size = new Size(504, 44);
            panel_FirstName.TabIndex = 31;
            // 
            // panel_LastName
            // 
            panel_LastName.BackColor = Color.SteelBlue;
            panel_LastName.Location = new Point(238, 218);
            panel_LastName.Name = "panel_LastName";
            panel_LastName.Size = new Size(504, 44);
            panel_LastName.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Location = new Point(238, 288);
            panel4.Name = "panel4";
            panel4.Size = new Size(244, 44);
            panel4.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(238, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 43);
            panel3.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(238, 358);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 43);
            panel5.TabIndex = 32;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Location = new Point(623, 358);
            panel6.Name = "panel6";
            panel6.Size = new Size(59, 43);
            panel6.TabIndex = 34;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Location = new Point(238, 428);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 43);
            panel7.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 49, 107);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox_AddStudent);
            panel1.Location = new Point(85, 65);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(808, 718);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Add_Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(978, 844);
            Controls.Add(panel1);
            Name = "Add_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Student";
            Load += Add_Student_Load;
            groupBox_AddStudent.ResumeLayout(false);
            groupBox_AddStudent.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox_AddStudent;
        private TextBox textBox_Address;
        private Label TRF5;
        private Label TRF4;
        private Label TRF3;
        private Label TFR2;
        private Label TFR1;
        private Label label5;
        private Label label_years;
        private ComboBox combo_Gender;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox text_Class;
        private TextBox text_Age;
        private TextBox text_LastName;
        private TextBox text_FirstName;
        private Button btn_Cancel;
        private Button btn_Save;
        private Button btn_Delete;
        private Label label_Address;
        private Label label_Class;
        private Label label_Age;
        private Label label_LastName;
        private Label label_Gender;
        private Label label_DateOfBirth;
        private Label label_FirstName;
        private Label label_AddStudent;
        private DateTimePicker dateTimePicker2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel_LastName;
        private Panel panel_FirstName;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private Panel panel2;
    }
}