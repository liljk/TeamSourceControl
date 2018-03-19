namespace TeamSourceControl
{
    partial class frmEmployeeForm
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateStuGrade = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewStuGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(26, 38);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(73, 134);
            this.lstStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // btnUpdateStuGrade
            // 
            this.btnUpdateStuGrade.Location = new System.Drawing.Point(116, 123);
            this.btnUpdateStuGrade.Name = "btnUpdateStuGrade";
            this.btnUpdateStuGrade.Size = new System.Drawing.Size(102, 49);
            this.btnUpdateStuGrade.TabIndex = 3;
            this.btnUpdateStuGrade.Text = "Update Grade";
            this.btnUpdateStuGrade.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(126, 205);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnViewStuGrade
            // 
            this.btnViewStuGrade.Location = new System.Drawing.Point(116, 39);
            this.btnViewStuGrade.Name = "btnViewStuGrade";
            this.btnViewStuGrade.Size = new System.Drawing.Size(102, 49);
            this.btnViewStuGrade.TabIndex = 5;
            this.btnViewStuGrade.Text = "View Grade";
            this.btnViewStuGrade.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 240);
            this.Controls.Add(this.btnViewStuGrade);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateStuGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStudents);
            this.Name = "frmEmployeeForm";
            this.Text = "Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateStuGrade;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewStuGrade;
    }
}