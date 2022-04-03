namespace ExamyUserControl.InstructorControls
{
    partial class CtlCreateExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbCourseNames = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.picExamDate = new System.Windows.Forms.DateTimePicker();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudMCQ = new System.Windows.Forms.NumericUpDown();
            this.nudTrueFalseQ = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerateExam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrueFalseQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 602);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbCourseNames);
            this.splitContainer1.Panel1.Controls.Add(this.label19);
            this.splitContainer1.Panel1.Controls.Add(this.picExamDate);
            this.splitContainer1.Panel1.Controls.Add(this.nudDuration);
            this.splitContainer1.Panel1.Controls.Add(this.nudMCQ);
            this.splitContainer1.Panel1.Controls.Add(this.nudTrueFalseQ);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerateExam);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvExams);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(918, 602);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 1;
            // 
            // cmbCourseNames
            // 
            this.cmbCourseNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCourseNames.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseNames.FormattingEnabled = true;
            this.cmbCourseNames.Items.AddRange(new object[] {
            "Bachelor’s ",
            "Master",
            "PHD",
            "Select Instructor Degree..."});
            this.cmbCourseNames.Location = new System.Drawing.Point(65, 138);
            this.cmbCourseNames.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCourseNames.Name = "cmbCourseNames";
            this.cmbCourseNames.Size = new System.Drawing.Size(324, 31);
            this.cmbCourseNames.TabIndex = 60;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(65, 405);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 29);
            this.label19.TabIndex = 70;
            this.label19.Text = "Exam Date";
            // 
            // picExamDate
            // 
            this.picExamDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picExamDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F);
            this.picExamDate.CustomFormat = "dd-mm-yyyy";
            this.picExamDate.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.picExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picExamDate.Location = new System.Drawing.Point(65, 438);
            this.picExamDate.Margin = new System.Windows.Forms.Padding(4);
            this.picExamDate.Name = "picExamDate";
            this.picExamDate.Size = new System.Drawing.Size(324, 30);
            this.picExamDate.TabIndex = 71;
            // 
            // nudDuration
            // 
            this.nudDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDuration.BackColor = System.Drawing.Color.White;
            this.nudDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDuration.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nudDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nudDuration.Location = new System.Drawing.Point(65, 363);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4);
            this.nudDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(324, 31);
            this.nudDuration.TabIndex = 67;
            this.nudDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMCQ
            // 
            this.nudMCQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMCQ.BackColor = System.Drawing.Color.White;
            this.nudMCQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudMCQ.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nudMCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nudMCQ.Location = new System.Drawing.Point(65, 288);
            this.nudMCQ.Margin = new System.Windows.Forms.Padding(4);
            this.nudMCQ.Name = "nudMCQ";
            this.nudMCQ.Size = new System.Drawing.Size(324, 31);
            this.nudMCQ.TabIndex = 68;
            this.nudMCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudTrueFalseQ
            // 
            this.nudTrueFalseQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTrueFalseQ.BackColor = System.Drawing.Color.White;
            this.nudTrueFalseQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTrueFalseQ.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.nudTrueFalseQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.nudTrueFalseQ.Location = new System.Drawing.Point(65, 213);
            this.nudTrueFalseQ.Margin = new System.Windows.Forms.Padding(4);
            this.nudTrueFalseQ.Name = "nudTrueFalseQ";
            this.nudTrueFalseQ.Size = new System.Drawing.Size(324, 31);
            this.nudTrueFalseQ.TabIndex = 69;
            this.nudTrueFalseQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(65, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Exam Duration";
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.btnGenerateExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateExam.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateExam.ForeColor = System.Drawing.Color.White;
            this.btnGenerateExam.Location = new System.Drawing.Point(246, 508);
            this.btnGenerateExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(143, 49);
            this.btnGenerateExam.TabIndex = 61;
            this.btnGenerateExam.Text = "Create";
            this.btnGenerateExam.UseVisualStyleBackColor = false;
            this.btnGenerateExam.Click += new System.EventHandler(this.btnGenerateExam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(65, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "Number Of MCQ Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(65, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Number Of TrueFalse Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(65, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 62;
            this.label1.Text = "Create Exam";
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExams.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvExams.Location = new System.Drawing.Point(0, 57);
            this.dgvExams.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExams.RowHeadersVisible = false;
            this.dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExams.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvExams.RowTemplate.Height = 40;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.ShowCellErrors = false;
            this.dgvExams.ShowCellToolTips = false;
            this.dgvExams.ShowEditingIcon = false;
            this.dgvExams.ShowRowErrors = false;
            this.dgvExams.Size = new System.Drawing.Size(464, 545);
            this.dgvExams.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 57);
            this.label4.TabIndex = 26;
            this.label4.Text = "Created Exams";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CtlCreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "CtlCreateExam";
            this.Size = new System.Drawing.Size(921, 602);
            this.Load += new System.EventHandler(this.CtlCreateExam_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMCQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrueFalseQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbCourseNames;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker picExamDate;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudMCQ;
        private System.Windows.Forms.NumericUpDown nudTrueFalseQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerateExam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Label label4;
    }
}
