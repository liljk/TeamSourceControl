using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
    class StudentDB
    {
        public static List<Student> GetAllCharacters()
        {
            var selCommand = new SqlCommand();
            selCommand.Connection = StuDB.GetConnection();
            selCommand.CommandText =
                "SELECT StudentID, StudentFName, StudentLName, BirthDate, StudentAddress" +
                "FROM Student";

            try
            {
                selCommand.Connection.Open();
                SqlDataReader rdr =
                    selCommand.ExecuteReader();

                var studentList = new List<Student>();
                while (rdr.Read())
                {
                    var Stu = new Student();
                    Stu.StudentID = (int)rdr["Id"];
                    Stu.StudentFName = (string)rdr["FirstName"];
                    Stu.StudentLName = (string)rdr["LastName"];
                    Stu.BirthDate = (DateTime)rdr["BirthDate"];
                    Stu.StudentAddress = (char)rdr["Address"];
                    studentList.Add(Stu);
                }

                return studentList;
            }
            finally
            {
                selCommand.Connection.Dispose();
            }
        }

        public static bool UpdateCharacter(Student currStu)
        {
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.CommandText = "UPDATE Student" +
                                    "SET StudentFName = @FirstName, " +
                                    "StudentLName = @LastName, " +
                                    "BirthDate = @BirthDate, " +
                                    "Adrress = @Address " +
                                    "WHERE StudentID = @StudentID";

            updateCmd.Parameters.AddWithValue("@FirstName", currStu.StudentFName);
            updateCmd.Parameters.AddWithValue("@LastName", currStu.StudentLName);
            updateCmd.Parameters.AddWithValue("@BirthDate", currStu.BirthDate);
            updateCmd.Parameters.AddWithValue("@Address", currStu.StudentAddress);
            updateCmd.Parameters.AddWithValue("@id", currStu.StudentID);

            using (SqlConnection con = StuDB.GetConnection())
            {
                updateCmd.Connection = con;
                con.Open();

                int rows = updateCmd.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                return false;
            }
        }

        public static bool Add(Student newStu)
        {
            SqlConnection dbConnection = StuDB.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = dbConnection;
            addCommand.CommandText = "INSERT INTO Student " +
           "(StudentFName, StudentLName, BirthDate, Address)" +
           "VALUES" +
           "(@FirstName, @LastName, @BirthDate, @Address)";

            addCommand.Parameters.AddWithValue("@FirstName", newStu.StudentFName);
            addCommand.Parameters.AddWithValue("@LastName", newStu.StudentLName);
            addCommand.Parameters.AddWithValue("@BirthDate", newStu.BirthDate);
            addCommand.Parameters.AddWithValue("@Address", newStu.StudentAddress);

            try
            {
                dbConnection.Open();
                int rowsAffected = addCommand.ExecuteNonQuery();
                //GameCharacter added successfully
                if (rowsAffected == 1)
                    return true;

                return false;
            }
            finally
            {
                dbConnection.Dispose();
                //con.Close();
            }

        }

        public static bool DeleteStudent(Student stu)
        {
            SqlConnection con = StuDB.GetConnection();

            SqlCommand delCmd = new SqlCommand();
            delCmd.Connection = con;
            delCmd.CommandText = "DELETE FROM Student " +
                                 "WHERE StudentID=@StudentID";
            delCmd.Parameters.AddWithValue("@StudentID", stu.StudentID);

            try
            {
                con.Open();
                int rowsAffected = delCmd.ExecuteNonQuery();
                //check that one character was deleted
                if (rowsAffected == 1)
                    return true;
                return false;
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
