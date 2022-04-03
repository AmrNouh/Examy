namespace ExamyUserControl.Admin
{
    partial class AddUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAdd = new System.Windows.Forms.TabControl();
            this.tpAddCourse = new System.Windows.Forms.TabPage();
            this.nudTotalGrade = new System.Windows.Forms.NumericUpDown();
            this.nudCourseDuration = new System.Windows.Forms.NumericUpDown();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpAddInstructor = new System.Windows.Forms.TabPage();
            this.cmbDegrees = new System.Windows.Forms.ComboBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInstAddress = new System.Windows.Forms.TextBox();
            this.txtInstructorName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInstDepartments = new System.Windows.Forms.ComboBox();
            this.tbAddStudent = new System.Windows.Forms.TabPage();
            this.nupAge = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStudAddress = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentPassword = new System.Windows.Forms.TextBox();
            this.txtSudentName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbStudDepartments = new System.Windows.Forms.ComboBox();
            this.tpAddDepartment = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDeptDesc = new System.Windows.Forms.TextBox();
            this.txtDeptname = new System.Windows.Forms.TextBox();
            this.cmbDeptManagers = new System.Windows.Forms.ComboBox();
            this.picHireDate = new System.Windows.Forms.DateTimePicker();
            this.tbAdd.SuspendLayout();
            this.tpAddCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseDuration)).BeginInit();
            this.tpAddInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.tbAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).BeginInit();
            this.tpAddDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAdd
            // 
            this.tbAdd.Controls.Add(this.tpAddCourse);
            this.tbAdd.Controls.Add(this.tpAddInstructor);
            this.tbAdd.Controls.Add(this.tbAddStudent);
            this.tbAdd.Controls.Add(this.tpAddDepartment);
            this.tbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdd.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdd.ItemSize = new System.Drawing.Size(200, 40);
            this.tbAdd.Location = new System.Drawing.Point(0, 0);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tbAdd.Multiline = true;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.SelectedIndex = 0;
            this.tbAdd.Size = new System.Drawing.Size(1058, 637);
            this.tbAdd.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbAdd.TabIndex = 0;
            this.tbAdd.SelectedIndexChanged += new System.EventHandler(this.tbAdd_SelectedIndexChanged);
            // 
            // tpAddCourse
            // 
            this.tpAddCourse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpAddCourse.Controls.Add(this.nudTotalGrade);
            this.tpAddCourse.Controls.Add(this.nudCourseDuration);
            this.tpAddCourse.Controls.Add(this.btnAddCourse);
            this.tpAddCourse.Controls.Add(this.label4);
            this.tpAddCourse.Controls.Add(this.label3);
            this.tpAddCourse.Controls.Add(this.label2);
            this.tpAddCourse.Controls.Add(this.txtCourseName);
            this.tpAddCourse.Controls.Add(this.label1);
            this.tpAddCourse.Location = new System.Drawing.Point(4, 44);
            this.tpAddCourse.Name = "tpAddCourse";
            this.tpAddCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCourse.Size = new System.Drawing.Size(1050, 589);
            this.tpAddCourse.TabIndex = 0;
            this.tpAddCourse.Text = "Add Course";
            // 
            // nudTotalGrade
            // 
            this.nudTotalGrade.BackColor = System.Drawing.Color.White;
            this.nudTotalGrade.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nudTotalGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nudTotalGrade.Location = new System.Drawing.Point(303, 352);
            this.nudTotalGrade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotalGrade.Name = "nudTotalGrade";
            this.nudTotalGrade.Size = new System.Drawing.Size(452, 27);
            this.nudTotalGrade.TabIndex = 13;
            this.nudTotalGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTotalGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCourseDuration
            // 
            this.nudCourseDuration.BackColor = System.Drawing.Color.White;
            this.nudCourseDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCourseDuration.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nudCourseDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nudCourseDuration.Location = new System.Drawing.Point(303, 271);
            this.nudCourseDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCourseDuration.Name = "nudCourseDuration";
            this.nudCourseDuration.Size = new System.Drawing.Size(452, 27);
            this.nudCourseDuration.TabIndex = 13;
            this.nudCourseDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCourseDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(648, 447);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(107, 40);
            this.btnAddCourse.TabIndex = 12;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(303, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Total Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(303, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(303, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Course Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.Color.White;
            this.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtCourseName.Location = new System.Drawing.Point(303, 196);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(452, 27);
            this.txtCourseName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(295, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Course";
            // 
            // tpAddInstructor
            // 
            this.tpAddInstructor.Controls.Add(this.cmbDegrees);
            this.tpAddInstructor.Controls.Add(this.nudSalary);
            this.tpAddInstructor.Controls.Add(this.label9);
            this.tpAddInstructor.Controls.Add(this.btnAddInstructor);
            this.tpAddInstructor.Controls.Add(this.label5);
            this.tpAddInstructor.Controls.Add(this.label6);
            this.tpAddInstructor.Controls.Add(this.label10);
            this.tpAddInstructor.Controls.Add(this.label7);
            this.tpAddInstructor.Controls.Add(this.txtInstAddress);
            this.tpAddInstructor.Controls.Add(this.txtInstructorName);
            this.tpAddInstructor.Controls.Add(this.label8);
            this.tpAddInstructor.Controls.Add(this.cmbInstDepartments);
            this.tpAddInstructor.Location = new System.Drawing.Point(4, 44);
            this.tpAddInstructor.Name = "tpAddInstructor";
            this.tpAddInstructor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddInstructor.Size = new System.Drawing.Size(1050, 589);
            this.tpAddInstructor.TabIndex = 1;
            this.tpAddInstructor.Text = "Add Instructor";
            this.tpAddInstructor.UseVisualStyleBackColor = true;
            // 
            // cmbDegrees
            // 
            this.cmbDegrees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDegrees.FormattingEnabled = true;
            this.cmbDegrees.Items.AddRange(new object[] {
            "Select Instructor Degree...",
            "Bachelor’s ",
            "Master",
            "PHD"});
            this.cmbDegrees.Location = new System.Drawing.Point(302, 268);
            this.cmbDegrees.Name = "cmbDegrees";
            this.cmbDegrees.Size = new System.Drawing.Size(452, 27);
            this.cmbDegrees.TabIndex = 22;
            // 
            // nudSalary
            // 
            this.nudSalary.BackColor = System.Drawing.Color.White;
            this.nudSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSalary.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nudSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nudSalary.Location = new System.Drawing.Point(302, 201);
            this.nudSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSalary.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(452, 27);
            this.nudSalary.TabIndex = 21;
            this.nudSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSalary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(302, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Department";
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstructor.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.Location = new System.Drawing.Point(647, 493);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(107, 40);
            this.btnAddInstructor.TabIndex = 19;
            this.btnAddInstructor.Text = "Add";
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(302, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Degree";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(302, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Salary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(302, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(302, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Instructor Name";
            // 
            // txtInstAddress
            // 
            this.txtInstAddress.BackColor = System.Drawing.Color.White;
            this.txtInstAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtInstAddress.Location = new System.Drawing.Point(302, 402);
            this.txtInstAddress.Multiline = true;
            this.txtInstAddress.Name = "txtInstAddress";
            this.txtInstAddress.Size = new System.Drawing.Size(452, 58);
            this.txtInstAddress.TabIndex = 15;
            // 
            // txtInstructorName
            // 
            this.txtInstructorName.BackColor = System.Drawing.Color.White;
            this.txtInstructorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructorName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtInstructorName.Location = new System.Drawing.Point(302, 134);
            this.txtInstructorName.Name = "txtInstructorName";
            this.txtInstructorName.Size = new System.Drawing.Size(452, 27);
            this.txtInstructorName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(296, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "Add Instructor";
            // 
            // cmbInstDepartments
            // 
            this.cmbInstDepartments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstDepartments.FormattingEnabled = true;
            this.cmbInstDepartments.Location = new System.Drawing.Point(302, 335);
            this.cmbInstDepartments.Name = "cmbInstDepartments";
            this.cmbInstDepartments.Size = new System.Drawing.Size(452, 27);
            this.cmbInstDepartments.TabIndex = 22;
            // 
            // tbAddStudent
            // 
            this.tbAddStudent.Controls.Add(this.nupAge);
            this.tbAddStudent.Controls.Add(this.label11);
            this.tbAddStudent.Controls.Add(this.btnAddStudent);
            this.tbAddStudent.Controls.Add(this.label17);
            this.tbAddStudent.Controls.Add(this.label12);
            this.tbAddStudent.Controls.Add(this.label13);
            this.tbAddStudent.Controls.Add(this.label14);
            this.tbAddStudent.Controls.Add(this.label15);
            this.tbAddStudent.Controls.Add(this.txtStudAddress);
            this.tbAddStudent.Controls.Add(this.txtStudentEmail);
            this.tbAddStudent.Controls.Add(this.txtStudentPassword);
            this.tbAddStudent.Controls.Add(this.txtSudentName);
            this.tbAddStudent.Controls.Add(this.label16);
            this.tbAddStudent.Controls.Add(this.cmbStudDepartments);
            this.tbAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbAddStudent.Location = new System.Drawing.Point(4, 44);
            this.tbAddStudent.Name = "tbAddStudent";
            this.tbAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddStudent.Size = new System.Drawing.Size(1050, 589);
            this.tbAddStudent.TabIndex = 2;
            this.tbAddStudent.Text = "Add Student";
            this.tbAddStudent.UseVisualStyleBackColor = true;
            // 
            // nupAge
            // 
            this.nupAge.BackColor = System.Drawing.Color.White;
            this.nupAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupAge.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nupAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nupAge.Location = new System.Drawing.Point(299, 175);
            this.nupAge.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nupAge.Name = "nupAge";
            this.nupAge.Size = new System.Drawing.Size(452, 27);
            this.nupAge.TabIndex = 32;
            this.nupAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupAge.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(302, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Department";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(647, 510);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(107, 40);
            this.btnAddStudent.TabIndex = 31;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(302, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 23);
            this.label17.TabIndex = 27;
            this.label17.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(302, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(302, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Age";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(302, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(302, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 23);
            this.label15.TabIndex = 30;
            this.label15.Text = "Student Name";
            // 
            // txtStudAddress
            // 
            this.txtStudAddress.BackColor = System.Drawing.Color.White;
            this.txtStudAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtStudAddress.Location = new System.Drawing.Point(299, 411);
            this.txtStudAddress.Multiline = true;
            this.txtStudAddress.Name = "txtStudAddress";
            this.txtStudAddress.Size = new System.Drawing.Size(452, 58);
            this.txtStudAddress.TabIndex = 24;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.BackColor = System.Drawing.Color.White;
            this.txtStudentEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtStudentEmail.Location = new System.Drawing.Point(299, 234);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(452, 27);
            this.txtStudentEmail.TabIndex = 25;
            // 
            // txtStudentPassword
            // 
            this.txtStudentPassword.BackColor = System.Drawing.Color.White;
            this.txtStudentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtStudentPassword.Location = new System.Drawing.Point(299, 293);
            this.txtStudentPassword.Name = "txtStudentPassword";
            this.txtStudentPassword.Size = new System.Drawing.Size(452, 27);
            this.txtStudentPassword.TabIndex = 25;
            // 
            // txtSudentName
            // 
            this.txtSudentName.BackColor = System.Drawing.Color.White;
            this.txtSudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSudentName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtSudentName.Location = new System.Drawing.Point(299, 116);
            this.txtSudentName.Name = "txtSudentName";
            this.txtSudentName.Size = new System.Drawing.Size(452, 27);
            this.txtSudentName.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(296, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(285, 37);
            this.label16.TabIndex = 23;
            this.label16.Text = "Add Student";
            // 
            // cmbStudDepartments
            // 
            this.cmbStudDepartments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudDepartments.FormattingEnabled = true;
            this.cmbStudDepartments.Location = new System.Drawing.Point(299, 352);
            this.cmbStudDepartments.Name = "cmbStudDepartments";
            this.cmbStudDepartments.Size = new System.Drawing.Size(452, 27);
            this.cmbStudDepartments.TabIndex = 34;
            // 
            // tpAddDepartment
            // 
            this.tpAddDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpAddDepartment.Controls.Add(this.label22);
            this.tpAddDepartment.Controls.Add(this.label18);
            this.tpAddDepartment.Controls.Add(this.btnAddDepartment);
            this.tpAddDepartment.Controls.Add(this.label19);
            this.tpAddDepartment.Controls.Add(this.label20);
            this.tpAddDepartment.Controls.Add(this.label21);
            this.tpAddDepartment.Controls.Add(this.txtDeptDesc);
            this.tpAddDepartment.Controls.Add(this.txtDeptname);
            this.tpAddDepartment.Controls.Add(this.cmbDeptManagers);
            this.tpAddDepartment.Controls.Add(this.picHireDate);
            this.tpAddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tpAddDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpAddDepartment.Location = new System.Drawing.Point(4, 44);
            this.tpAddDepartment.Name = "tpAddDepartment";
            this.tpAddDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddDepartment.Size = new System.Drawing.Size(1050, 589);
            this.tpAddDepartment.TabIndex = 3;
            this.tpAddDepartment.Text = "Add Department";
            this.tpAddDepartment.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(295, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(285, 37);
            this.label22.TabIndex = 44;
            this.label22.Text = "Add Department";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(304, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "Department Manager";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(646, 469);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(107, 40);
            this.btnAddDepartment.TabIndex = 42;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(304, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 23);
            this.label19.TabIndex = 39;
            this.label19.Text = "HireDate";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Location = new System.Drawing.Point(304, 326);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 23);
            this.label20.TabIndex = 40;
            this.label20.Text = "Description";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(304, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 23);
            this.label21.TabIndex = 41;
            this.label21.Text = "Department Name";
            // 
            // txtDeptDesc
            // 
            this.txtDeptDesc.BackColor = System.Drawing.Color.White;
            this.txtDeptDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptDesc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtDeptDesc.Location = new System.Drawing.Point(301, 352);
            this.txtDeptDesc.Multiline = true;
            this.txtDeptDesc.Name = "txtDeptDesc";
            this.txtDeptDesc.Size = new System.Drawing.Size(452, 58);
            this.txtDeptDesc.TabIndex = 35;
            // 
            // txtDeptname
            // 
            this.txtDeptname.BackColor = System.Drawing.Color.White;
            this.txtDeptname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeptname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.txtDeptname.Location = new System.Drawing.Point(301, 144);
            this.txtDeptname.Name = "txtDeptname";
            this.txtDeptname.Size = new System.Drawing.Size(452, 27);
            this.txtDeptname.TabIndex = 37;
            // 
            // cmbDeptManagers
            // 
            this.cmbDeptManagers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeptManagers.FormattingEnabled = true;
            this.cmbDeptManagers.Location = new System.Drawing.Point(301, 211);
            this.cmbDeptManagers.Name = "cmbDeptManagers";
            this.cmbDeptManagers.Size = new System.Drawing.Size(452, 27);
            this.cmbDeptManagers.TabIndex = 43;
            // 
            // picHireDate
            // 
            this.picHireDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F);
            this.picHireDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.picHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picHireDate.Location = new System.Drawing.Point(301, 282);
            this.picHireDate.Name = "picHireDate";
            this.picHireDate.Size = new System.Drawing.Size(452, 26);
            this.picHireDate.TabIndex = 45;
            // 
            // AddUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbAdd);
            this.Name = "AddUserControl";
            this.Size = new System.Drawing.Size(1058, 637);
            this.Load += new System.EventHandler(this.AddUserControl_Load);
            this.tbAdd.ResumeLayout(false);
            this.tpAddCourse.ResumeLayout(false);
            this.tpAddCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCourseDuration)).EndInit();
            this.tpAddInstructor.ResumeLayout(false);
            this.tpAddInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.tbAddStudent.ResumeLayout(false);
            this.tbAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).EndInit();
            this.tpAddDepartment.ResumeLayout(false);
            this.tpAddDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAdd;
        private System.Windows.Forms.TabPage tpAddCourse;
        private System.Windows.Forms.TabPage tpAddInstructor;
        private System.Windows.Forms.TabPage tbAddStudent;
        private System.Windows.Forms.NumericUpDown nudTotalGrade;
        private System.Windows.Forms.NumericUpDown nudCourseDuration;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInstructorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDegrees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInstAddress;
        private System.Windows.Forms.ComboBox cmbInstDepartments;
        private System.Windows.Forms.NumericUpDown nupAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStudAddress;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentPassword;
        private System.Windows.Forms.TextBox txtSudentName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbStudDepartments;
        private System.Windows.Forms.TabPage tpAddDepartment;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDeptDesc;
        private System.Windows.Forms.TextBox txtDeptname;
        private System.Windows.Forms.ComboBox cmbDeptManagers;
        private System.Windows.Forms.DateTimePicker picHireDate;
    }
}
