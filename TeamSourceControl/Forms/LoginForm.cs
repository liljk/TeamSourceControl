using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) | string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter User ID and Password");
            }
            else
            {
                int exists;
                string password;

                CheckID(out exists, out password);
                CheckPassword(exists, password);
            }
        }

        private void CheckPassword(int exists, string password)
        {
            var frmGradesForm = new frmGradesForm();
            var frmEmployeeForm = new frmEmployeeForm();

            if (exists == 1)
            {

                if (txtPassword.Text == password)
                {
                    frmGradesForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else if (exists == 2)
            {
                if (txtPassword.Text == password)
                {
                    frmEmployeeForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void CheckID(out int exists, out string password)
        {
            exists = 0;
            password = null;
            SqlConnection con = new SqlConnection();
            con = StuDB.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Students full join Employees on Students.StudentID = Employees.EmployeeID", con);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if (txtID.Text == r["StudentID"].ToString().Trim())
                    {
                        exists = 1;
                        password = r["StudentPassword"].ToString().Trim();
                    }
                    else if(txtID.Text == r["EmployeeID"].ToString().Trim())
                    {
                        exists = 2;
                        password = r["EmployeePassword"].ToString().Trim();
                    }

                }
            }
            finally
            {
                con.Dispose();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var displayAddStudent = new frmAddStudent();
            displayAddStudent.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
