﻿using System;
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
            return new SqlConnection(@"Data Source=jhoon\sqlexpress;Initial Catalog=StudentDB;Integrated Security=True");
        }
    }
}
