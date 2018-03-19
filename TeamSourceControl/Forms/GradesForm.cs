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
    public partial class frmGradesForm : Form
    {
        public frmGradesForm()
        {
            InitializeComponent();
        }

        private void lstAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmGradesForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Grade grade = new Grade();
                grade.Assignment = "text" + i.ToString();
                grade.Assignment = i.ToString();
                this.lstAssignments.Items.Add(grade);
            }
        }
    }
}
