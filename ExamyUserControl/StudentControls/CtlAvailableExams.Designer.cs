namespace ExamyUserControl.StudentControls
{
    partial class CtlAvailableExams
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAvailableExams = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableExams
            // 
            this.dgvAvailableExams.AllowUserToAddRows = false;
            this.dgvAvailableExams.AllowUserToDeleteRows = false;
            this.dgvAvailableExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableExams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAvailableExams.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAvailableExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableExams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvailableExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableExams.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableExams.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAvailableExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailableExams.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAvailableExams.Location = new System.Drawing.Point(0, 57);
            this.dgvAvailableExams.MultiSelect = false;
            this.dgvAvailableExams.Name = "dgvAvailableExams";
            this.dgvAvailableExams.ReadOnly = true;
            this.dgvAvailableExams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAvailableExams.RowHeadersVisible = false;
            this.dgvAvailableExams.RowHeadersWidth = 51;
            this.dgvAvailableExams.RowTemplate.Height = 24;
            this.dgvAvailableExams.ShowCellErrors = false;
            this.dgvAvailableExams.ShowCellToolTips = false;
            this.dgvAvailableExams.ShowEditingIcon = false;
            this.dgvAvailableExams.ShowRowErrors = false;
            this.dgvAvailableExams.Size = new System.Drawing.Size(900, 568);
            this.dgvAvailableExams.TabIndex = 0;
            this.dgvAvailableExams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableExams_CellContentClick);
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
            this.label4.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(900, 57);
            this.label4.TabIndex = 27;
            this.label4.Text = "Available Exams";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CtlAvailableExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvAvailableExams);
            this.Controls.Add(this.label4);
            this.Name = "CtlAvailableExams";
            this.Size = new System.Drawing.Size(900, 625);
            this.Load += new System.EventHandler(this.CtlAvailableExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableExams;
        private System.Windows.Forms.Label label4;
    }
}
