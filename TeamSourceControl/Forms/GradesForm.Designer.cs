namespace TeamSourceControl
{
    partial class frmGradesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOverallGrade = new System.Windows.Forms.TextBox();
            this.btnViewGrade = new System.Windows.Forms.Button();
            this.btnTestGrade = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assignments:";
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.ItemHeight = 25;
            this.lstAssignments.Location = new System.Drawing.Point(26, 83);
            this.lstAssignments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.Size = new System.Drawing.Size(156, 254);
            this.lstAssignments.TabIndex = 1;
            this.lstAssignments.SelectedIndexChanged += new System.EventHandler(this.lstAssignments_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Overall Grade:";
            // 
            // txtOverallGrade
            // 
            this.txtOverallGrade.Location = new System.Drawing.Point(182, 396);
            this.txtOverallGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOverallGrade.Name = "txtOverallGrade";
            this.txtOverallGrade.ReadOnly = true;
            this.txtOverallGrade.Size = new System.Drawing.Size(44, 31);
            this.txtOverallGrade.TabIndex = 3;
            // 
            // btnViewGrade
            // 
            this.btnViewGrade.Location = new System.Drawing.Point(248, 83);
            this.btnViewGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnViewGrade.Name = "btnViewGrade";
            this.btnViewGrade.Size = new System.Drawing.Size(204, 94);
            this.btnViewGrade.TabIndex = 4;
            this.btnViewGrade.Text = "View Grade";
            this.btnViewGrade.UseVisualStyleBackColor = true;
            // 
            // btnTestGrade
            // 
            this.btnTestGrade.Location = new System.Drawing.Point(248, 246);
            this.btnTestGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTestGrade.Name = "btnTestGrade";
            this.btnTestGrade.Size = new System.Drawing.Size(204, 94);
            this.btnTestGrade.TabIndex = 5;
            this.btnTestGrade.Text = "Test Grade";
            this.btnTestGrade.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(278, 392);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 44);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 483);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTestGrade);
            this.Controls.Add(this.btnViewGrade);
            this.Controls.Add(this.txtOverallGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAssignments);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmGradesForm";
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.frmGradesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOverallGrade;
        private System.Windows.Forms.Button btnViewGrade;
        private System.Windows.Forms.Button btnTestGrade;
        private System.Windows.Forms.Button btnLogout;
    }
}