namespace ExamyUserControl.StudentControls
{
    partial class FrmExam
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExamTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExamHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmitExam = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblQuestionBody = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblQuestionGrade = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.examDuration = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblInstructorName = new System.Windows.Forms.Label();
            this.lblTotalNumberofQuestons = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRadioContainer = new System.Windows.Forms.Panel();
            this.rdChoice04 = new System.Windows.Forms.RadioButton();
            this.rdChoice03 = new System.Windows.Forms.RadioButton();
            this.rdChoice02 = new System.Windows.Forms.RadioButton();
            this.rdChoice01 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblExamGrade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlRadioContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(890, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 728);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 48);
            this.label3.TabIndex = 66;
            this.label3.Text = "Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblExamTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 146);
            this.panel5.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(69, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "HH : MM : SS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExamTime
            // 
            this.lblExamTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTime.Location = new System.Drawing.Point(69, 35);
            this.lblExamTime.Name = "lblExamTime";
            this.lblExamTime.Size = new System.Drawing.Size(190, 41);
            this.lblExamTime.TabIndex = 0;
            this.lblExamTime.Text = "00 : 00 : 00";
            this.lblExamTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 48);
            this.label2.TabIndex = 64;
            this.label2.Text = "Time Left";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblExamHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 48);
            this.panel2.TabIndex = 1;
            // 
            // lblExamHeader
            // 
            this.lblExamHeader.BackColor = System.Drawing.SystemColors.Control;
            this.lblExamHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExamHeader.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblExamHeader.Location = new System.Drawing.Point(0, 0);
            this.lblExamHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamHeader.Name = "lblExamHeader";
            this.lblExamHeader.Size = new System.Drawing.Size(890, 48);
            this.lblExamHeader.TabIndex = 63;
            this.lblExamHeader.Text = "Online Test - Subject Name";
            this.lblExamHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnSubmitExam);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 593);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 135);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(47, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(797, 2);
            this.label10.TabIndex = 2;
            // 
            // btnSubmitExam
            // 
            this.btnSubmitExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.btnSubmitExam.FlatAppearance.BorderSize = 0;
            this.btnSubmitExam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(100)))));
            this.btnSubmitExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(155)))), ((int)(((byte)(100)))));
            this.btnSubmitExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitExam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitExam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitExam.Location = new System.Drawing.Point(712, 46);
            this.btnSubmitExam.Name = "btnSubmitExam";
            this.btnSubmitExam.Size = new System.Drawing.Size(132, 40);
            this.btnSubmitExam.TabIndex = 0;
            this.btnSubmitExam.Text = "Submit Test";
            this.btnSubmitExam.UseVisualStyleBackColor = false;
            this.btnSubmitExam.Click += new System.EventHandler(this.btnSubmitExam_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(180, 46);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 40);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnPrevious.Enabled = false;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.Location = new System.Drawing.Point(47, 46);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 40);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlRadioContainer);
            this.panel4.Controls.Add(this.lblQuestionBody);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(890, 545);
            this.panel4.TabIndex = 3;
            // 
            // lblQuestionBody
            // 
            this.lblQuestionBody.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.lblQuestionBody.Location = new System.Drawing.Point(47, 130);
            this.lblQuestionBody.Name = "lblQuestionBody";
            this.lblQuestionBody.Size = new System.Drawing.Size(797, 97);
            this.lblQuestionBody.TabIndex = 1;
            this.lblQuestionBody.Text = "Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, whe" +
    "n an unknown printer took a galley of type and scrambled it to make a type speci" +
    "men book.";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.lblQuestionGrade);
            this.panel6.Controls.Add(this.lblQuestionNumber);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(890, 112);
            this.panel6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(797, 2);
            this.label9.TabIndex = 1;
            // 
            // lblQuestionGrade
            // 
            this.lblQuestionGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionGrade.AutoSize = true;
            this.lblQuestionGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionGrade.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblQuestionGrade.Location = new System.Drawing.Point(717, 37);
            this.lblQuestionGrade.Name = "lblQuestionGrade";
            this.lblQuestionGrade.Size = new System.Drawing.Size(114, 28);
            this.lblQuestionGrade.TabIndex = 0;
            this.lblQuestionGrade.Text = "[ 5 Marks ]";
            this.lblQuestionGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblQuestionNumber.Location = new System.Drawing.Point(45, 37);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(193, 28);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Quant - Question 1";
            this.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // examDuration
            // 
            this.examDuration.Interval = 1000;
            this.examDuration.Tick += new System.EventHandler(this.examDuration_Tick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.lblInstructorName);
            this.panel7.Controls.Add(this.lblExamGrade);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.lblTotalNumberofQuestons);
            this.panel7.Controls.Add(this.lblCurrentDate);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 242);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(328, 484);
            this.panel7.TabIndex = 67;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.lblCurrentDate.Location = new System.Drawing.Point(19, 182);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(293, 36);
            this.lblCurrentDate.TabIndex = 1;
            this.lblCurrentDate.Text = "Current Date";
            this.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructorName
            // 
            this.lblInstructorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.lblInstructorName.Location = new System.Drawing.Point(18, 421);
            this.lblInstructorName.Name = "lblInstructorName";
            this.lblInstructorName.Size = new System.Drawing.Size(293, 29);
            this.lblInstructorName.TabIndex = 2;
            this.lblInstructorName.Text = "Name Here";
            this.lblInstructorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalNumberofQuestons
            // 
            this.lblTotalNumberofQuestons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalNumberofQuestons.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumberofQuestons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.lblTotalNumberofQuestons.Location = new System.Drawing.Point(18, 37);
            this.lblTotalNumberofQuestons.Name = "lblTotalNumberofQuestons";
            this.lblTotalNumberofQuestons.Size = new System.Drawing.Size(293, 42);
            this.lblTotalNumberofQuestons.TabIndex = 3;
            this.lblTotalNumberofQuestons.Text = "1 / 20";
            this.lblTotalNumberofQuestons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(17, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(18, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instructor Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Questions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRadioContainer
            // 
            this.pnlRadioContainer.Controls.Add(this.rdChoice04);
            this.pnlRadioContainer.Controls.Add(this.rdChoice03);
            this.pnlRadioContainer.Controls.Add(this.rdChoice02);
            this.pnlRadioContainer.Controls.Add(this.rdChoice01);
            this.pnlRadioContainer.Location = new System.Drawing.Point(47, 227);
            this.pnlRadioContainer.Name = "pnlRadioContainer";
            this.pnlRadioContainer.Size = new System.Drawing.Size(781, 260);
            this.pnlRadioContainer.TabIndex = 3;
            // 
            // rdChoice04
            // 
            this.rdChoice04.AutoSize = true;
            this.rdChoice04.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoice04.Location = new System.Drawing.Point(5, 166);
            this.rdChoice04.Name = "rdChoice04";
            this.rdChoice04.Size = new System.Drawing.Size(108, 29);
            this.rdChoice04.TabIndex = 3;
            this.rdChoice04.TabStop = true;
            this.rdChoice04.Text = "Choice03";
            this.rdChoice04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChoice04.UseVisualStyleBackColor = true;
            // 
            // rdChoice03
            // 
            this.rdChoice03.AutoSize = true;
            this.rdChoice03.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoice03.Location = new System.Drawing.Point(5, 112);
            this.rdChoice03.Name = "rdChoice03";
            this.rdChoice03.Size = new System.Drawing.Size(108, 29);
            this.rdChoice03.TabIndex = 4;
            this.rdChoice03.TabStop = true;
            this.rdChoice03.Text = "Choice03";
            this.rdChoice03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChoice03.UseVisualStyleBackColor = true;
            // 
            // rdChoice02
            // 
            this.rdChoice02.AutoSize = true;
            this.rdChoice02.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoice02.Location = new System.Drawing.Point(5, 58);
            this.rdChoice02.Name = "rdChoice02";
            this.rdChoice02.Size = new System.Drawing.Size(108, 29);
            this.rdChoice02.TabIndex = 5;
            this.rdChoice02.TabStop = true;
            this.rdChoice02.Text = "Choice02";
            this.rdChoice02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChoice02.UseVisualStyleBackColor = true;
            // 
            // rdChoice01
            // 
            this.rdChoice01.AutoSize = true;
            this.rdChoice01.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoice01.Location = new System.Drawing.Point(5, 4);
            this.rdChoice01.Name = "rdChoice01";
            this.rdChoice01.Size = new System.Drawing.Size(105, 29);
            this.rdChoice01.TabIndex = 6;
            this.rdChoice01.TabStop = true;
            this.rdChoice01.Text = "Choice01";
            this.rdChoice01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChoice01.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(18, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 36);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Grade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExamGrade
            // 
            this.lblExamGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExamGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.lblExamGrade.Location = new System.Drawing.Point(18, 306);
            this.lblExamGrade.Name = "lblExamGrade";
            this.lblExamGrade.Size = new System.Drawing.Size(293, 36);
            this.lblExamGrade.TabIndex = 2;
            this.lblExamGrade.Text = "Grade";
            this.lblExamGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(89, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 2);
            this.label8.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(89, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 2);
            this.label11.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(89, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 2);
            this.label12.TabIndex = 1;
            // 
            // FrmExam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1220, 728);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExam";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExam_FormClosing);
            this.Load += new System.EventHandler(this.FrmExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.pnlRadioContainer.ResumeLayout(false);
            this.pnlRadioContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExamTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExamHeader;
        private System.Windows.Forms.Button btnSubmitExam;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblQuestionBody;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer examDuration;
        private System.Windows.Forms.Label lblQuestionGrade;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblInstructorName;
        private System.Windows.Forms.Label lblTotalNumberofQuestons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRadioContainer;
        private System.Windows.Forms.RadioButton rdChoice04;
        private System.Windows.Forms.RadioButton rdChoice03;
        private System.Windows.Forms.RadioButton rdChoice02;
        private System.Windows.Forms.RadioButton rdChoice01;
        private System.Windows.Forms.Label lblExamGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}