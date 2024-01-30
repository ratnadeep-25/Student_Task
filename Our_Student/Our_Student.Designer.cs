namespace Our_Student
{
    partial class Our_Student
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            First_Name = new DataGridViewTextBoxColumn();
            Last_Name = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            text_Search = new TextBox();
            label_OurStudent = new Label();
            button_Add = new Button();
            panel_search = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { First_Name, Last_Name, Gender, Age, Class });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(25, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(230, 240, 167);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(950, 187);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.ColumnHeaderMouseDoubleClick += dataGridView1_ColumnHeaderMouseDoubleClick;
            // 
            // First_Name
            // 
            First_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Beige;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            First_Name.DefaultCellStyle = dataGridViewCellStyle2;
            First_Name.HeaderText = "First Name";
            First_Name.MinimumWidth = 8;
            First_Name.Name = "First_Name";
            First_Name.ReadOnly = true;
            First_Name.Resizable = DataGridViewTriState.False;
            // 
            // Last_Name
            // 
            Last_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            Last_Name.DefaultCellStyle = dataGridViewCellStyle3;
            Last_Name.HeaderText = "Last Name";
            Last_Name.MinimumWidth = 8;
            Last_Name.Name = "Last_Name";
            Last_Name.ReadOnly = true;
            Last_Name.Resizable = DataGridViewTriState.False;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Gender.DefaultCellStyle = dataGridViewCellStyle4;
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Resizable = DataGridViewTriState.False;
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Age.DefaultCellStyle = dataGridViewCellStyle5;
            Age.HeaderText = "Age";
            Age.MinimumWidth = 8;
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Resizable = DataGridViewTriState.False;
            // 
            // Class
            // 
            Class.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.SelectionBackColor = Color.YellowGreen;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Class.DefaultCellStyle = dataGridViewCellStyle6;
            Class.HeaderText = "Class";
            Class.MinimumWidth = 8;
            Class.Name = "Class";
            Class.ReadOnly = true;
            Class.Resizable = DataGridViewTriState.False;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(text_Search);
            groupBox1.Controls.Add(label_OurStudent);
            groupBox1.Controls.Add(button_Add);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(panel_search);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 500);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // text_Search
            // 
            text_Search.BorderStyle = BorderStyle.FixedSingle;
            text_Search.Font = new Font("Segoe UI", 12F);
            text_Search.Location = new Point(650, 200);
            text_Search.Name = "text_Search";
            text_Search.PlaceholderText = "  Search...";
            text_Search.Size = new Size(160, 39);
            text_Search.TabIndex = 1;
            text_Search.TextChanged += text_Search_TextChanged;
            // 
            // label_OurStudent
            // 
            label_OurStudent.AutoSize = true;
            label_OurStudent.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_OurStudent.Location = new Point(317, 20);
            label_OurStudent.Name = "label_OurStudent";
            label_OurStudent.RightToLeft = RightToLeft.No;
            label_OurStudent.Size = new Size(365, 74);
            label_OurStudent.TabIndex = 4;
            label_OurStudent.Text = "Our Students";
            label_OurStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.SteelBlue;
            button_Add.Font = new Font("Segoe UI", 12F);
            button_Add.ForeColor = SystemColors.WindowText;
            button_Add.Location = new Point(845, 193);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(130, 50);
            button_Add.TabIndex = 2;
            button_Add.Text = "+Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // panel_search
            // 
            panel_search.BackColor = Color.SteelBlue;
            panel_search.Location = new Point(649, 199);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(162, 41);
            panel_search.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 49, 107);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(40, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 504);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Our_Student
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(10, 10);
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1078, 594);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Our_Student";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox text_Search;
        private Label label_OurStudent;
        private Button button_Add;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Last_Name;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Class;
        private Panel panel1;
        private Panel panel_search;
        public DataGridView dataGridView1;
    }
}
