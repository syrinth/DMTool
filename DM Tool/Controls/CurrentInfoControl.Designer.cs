namespace DM_Tool.Controls
{
    partial class CurrentInfoControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(508, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(14, 17);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(65, 19);
            this.lblLocation.TabIndex = 74;
            this.lblLocation.Text = "Location:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 46);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 75;
            this.lblDate.Text = "Date:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(98, 18);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(200, 20);
            this.tbLocation.TabIndex = 78;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm  tt";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(393, 18);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(190, 49);
            this.dtpTime.TabIndex = 82;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(98, 47);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.Size = new System.Drawing.Size(200, 20);
            this.tbCurrentDate.TabIndex = 84;
            this.tbCurrentDate.Leave += new System.EventHandler(this.tbCurrentDate_Leave);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(304, 45);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 23);
            this.btnNext.TabIndex = 83;
            this.btnNext.Text = "Next Day";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // CurrentInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSave);
            this.Name = "CurrentInfoControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.Button btnNext;
    }
}
