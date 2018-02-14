using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
    class StuDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=JHOON\SQLEXPRESS;Initial Catalog=GradesDB;Integrated Security=True");
        }
    }
}
