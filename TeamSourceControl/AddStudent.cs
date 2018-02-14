using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFName.Text) | string.IsNullOrEmpty(txtLName.Text) | string.IsNullOrEmpty(txtEmail.Text) | string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter valid data");
            }
            else
            {
                Student newStu = new Student();
                //StudentID is identity and set by the database
                newStu.StudentFName = txtFName.Text.Trim();
                newStu.StudentLName = txtLName.Text.Trim();
                newStu.BirthDate = txtBirthDate.Value;
                newStu.StudentEmail = txtEmail.Text.Trim();
                newStu.StudentPassword = txtPassword.Text.Trim();

                Random rand = new Random();
                int randomID = rand.Next(100000000, 999999999);

                StudentDB.Add(newStu, randomID);
                MessageBox.Show("Account Added" + "\n" +  "Your ID is: " + randomID);
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
