namespace DM_Tool
{
    partial class CalendarControl
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
            this.tbYearName = new System.Windows.Forms.TextBox();
            this.lblDaysPerYear = new System.Windows.Forms.Label();
            this.tbNumDays = new System.Windows.Forms.TextBox();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.tbMonthNames = new System.Windows.Forms.TextBox();
            this.lblDaysPerWeek = new System.Windows.Forms.Label();
            this.tbDaysPerWeek = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbYearName
            // 
            this.tbYearName.Location = new System.Drawing.Point(390, 10);
            this.tbYearName.Name = "tbYearName";
            this.tbYearName.Size = new System.Drawing.Size(189, 20);
            this.tbYearName.TabIndex = 0;
            // 
            // lblDaysPerYear
            // 
            this.lblDaysPerYear.AutoSize = true;
            this.lblDaysPerYear.Location = new System.Drawing.Point(3, 65);
            this.lblDaysPerYear.Name = "lblDaysPerYear";
            this.lblDaysPerYear.Size = new System.Drawing.Size(78, 13);
            this.lblDaysPerYear.TabIndex = 6;
            this.lblDaysPerYear.Text = "Days in Month:";
            // 
            // tbNumDays
            // 
            this.tbNumDays.Location = new System.Drawing.Point(87, 62);
            this.tbNumDays.Name = "tbNumDays";
            this.tbNumDays.Size = new System.Drawing.Size(492, 20);
            this.tbNumDays.TabIndex = 5;
            // 
            // lblMonthName
            // 
            this.lblMonthName.AutoSize = true;
            this.lblMonthName.Location = new System.Drawing.Point(3, 39);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(76, 13);
            this.lblMonthName.TabIndex = 8;
            this.lblMonthName.Text = "Month Names:";
            // 
            // tbMonthNames
            // 
            this.tbMonthNames.Location = new System.Drawing.Point(87, 36);
            this.tbMonthNames.Name = "tbMonthNames";
            this.tbMonthNames.Size = new System.Drawing.Size(492, 20);
            this.tbMonthNames.TabIndex = 7;
            // 
            // lblDaysPerWeek
            // 
            this.lblDaysPerWeek.AutoSize = true;
            this.lblDaysPerWeek.Location = new System.Drawing.Point(3, 91);
            this.lblDaysPerWeek.Name = "lblDaysPerWeek";
            this.lblDaysPerWeek.Size = new System.Drawing.Size(84, 13);
            this.lblDaysPerWeek.TabIndex = 10;
            this.lblDaysPerWeek.Text = "Days per Week:";
            // 
            // tbDaysPerWeek
            // 
            this.tbDaysPerWeek.Location = new System.Drawing.Point(87, 88);
            this.tbDaysPerWeek.Name = "tbDaysPerWeek";
            this.tbDaysPerWeek.Size = new System.Drawing.Size(188, 20);
            this.tbDaysPerWeek.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(504, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(276, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next Day";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(3, 13);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentDate.TabIndex = 2;
            this.lblCurrentDate.Text = "Current Date:";
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(87, 10);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.Size = new System.Drawing.Size(183, 20);
            this.tbCurrentDate.TabIndex = 17;
            this.tbCurrentDate.Leave += new System.EventHandler(this.tbCurrentDate_Leave);
            // 
            // CalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDaysPerWeek);
            this.Controls.Add(this.tbDaysPerWeek);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.tbMonthNames);
            this.Controls.Add(this.lblDaysPerYear);
            this.Controls.Add(this.tbNumDays);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.tbYearName);
            this.Name = "CalendarControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbYearName;
        private System.Windows.Forms.Label lblDaysPerYear;
        private System.Windows.Forms.TextBox tbNumDays;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.TextBox tbMonthNames;
        private System.Windows.Forms.Label lblDaysPerWeek;
        private System.Windows.Forms.TextBox tbDaysPerWeek;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.TextBox tbCurrentDate;

    }
}
