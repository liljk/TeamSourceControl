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
            int valid = 0;
            if (string.IsNullOrEmpty(txtID.Text) | string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter User ID and Password");
                valid = 1;
            }
            else
            {

                int exists = 0;
                string password = null;

                if (valid == 0)
                {
                    SqlConnection con = new SqlConnection();
                    con = StuDB.GetConnection();
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select * from Students", con);
                        SqlDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            if (txtID.Text == r["StudentID"].ToString().Trim())
                            {
                                exists = 1;
                                password = r["StudentPassword"].ToString().Trim();
                            }
                        }
                    }
                    finally
                    {
                        con.Dispose();
                    }
                }

                if (exists == 1)
                {
                    if (txtPassword.Text == password)
                    {
                        var frmGradesForm = new frmGradesForm();
                        frmGradesForm.Show();
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
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var displayAddStudent = new frmAddStudent();
            displayAddStudent.Show();
        }
    }
}
