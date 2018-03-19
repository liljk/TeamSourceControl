﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSourceControl
{
    class StudentDB
    {
        public static List<Student> GetAllStudent()
        {
            var selCommand = new SqlCommand();
            selCommand.Connection = StuDB.GetConnection();
            selCommand.CommandText =
                "SELECT StudentID, StudentPassword, StudentFName, StudentLName, BirthDate, StudentEmail" +
                "FROM Students";

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
                    Stu.StudentPassword = (string)rdr["Password"];
                    Stu.StudentFName = (string)rdr["FirstName"];
                    Stu.StudentLName = (string)rdr["LastName"];
                    Stu.BirthDate = (DateTime)rdr["BirthDate"];
                    Stu.StudentEmail = (string)rdr["Email"];
                    studentList.Add(Stu);
                }

                return studentList;
            }
            finally
            {
                selCommand.Connection.Dispose();
            }
        }

        public static bool UpdateStudent(Student currStu)
        {
            SqlCommand updateCmd = new SqlCommand();
            updateCmd.CommandText = "UPDATE Students" +
                                    "SET StudentFName = @FirstName, " +
                                    "StudentPassword = @Password, " +
                                    "StudentLName = @LastName, " +
                                    "BirthDate = @BirthDate, " +
                                    "Email = @Email, " +
                                    "WHERE StudentID = @StudentID";

            updateCmd.Parameters.AddWithValue("@FirstName", currStu.StudentFName);
            updateCmd.Parameters.AddWithValue("@LastName", currStu.StudentLName);
            updateCmd.Parameters.AddWithValue("@BirthDate", currStu.BirthDate);
            updateCmd.Parameters.AddWithValue("@Email", currStu.StudentEmail);
            updateCmd.Parameters.AddWithValue("@id", currStu.StudentID);
            updateCmd.Parameters.AddWithValue("@Password", currStu.StudentPassword);

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


        /// <summary>
        /// Adds a student to the database with the given values
        /// and returns a boolean of whether or not it was successful
        /// </summary>
        /// <param name="newStu"></param>
        /// <returns></returns>
        public static bool Add(Student newStu)
        {
            SqlConnection dbConnection = StuDB.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = dbConnection;
            addCommand.CommandText = "INSERT INTO Students " +
           "(StudentFName, StudentLName, BirthDate, StudentEmail, StudentPassword)" +
           "VALUES" +
           "(@FirstName, @LastName, @BirthDate, @Email, @Password)";

            addCommand.Parameters.AddWithValue("@FirstName", newStu.StudentFName);
            addCommand.Parameters.AddWithValue("@LastName", newStu.StudentLName);
            addCommand.Parameters.AddWithValue("@BirthDate", newStu.BirthDate);
            addCommand.Parameters.AddWithValue("@Email", newStu.StudentEmail);
            addCommand.Parameters.AddWithValue("@Password", newStu.StudentPassword);

            try
            {
                dbConnection.Open();
                int rowsAffected = addCommand.ExecuteNonQuery();
                //Student added successfully
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

        /// <summary>
        /// returns the StudentID of the most recent addition to the Student table
        /// </summary>
        /// <returns></returns>
        public static int GetNewStudentID() {
            SqlConnection con = new SqlConnection();
            con = StuDB.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT StudentID FROM Students WHERE StudentID = (SELECT MAX(StudentID) FROM Students)", con);
                SqlDataReader r = cmd.ExecuteReader();
                int userID = 0;
                while (r.Read())
                {
                    userID = Convert.ToInt32(r["StudentID"]);
                }
                return userID;
            }
            finally
            {
                con.Dispose();
            }
        }




        public static bool DeleteStudent(Student stu)
        {
            SqlConnection con = StuDB.GetConnection();

            SqlCommand delCmd = new SqlCommand();
            delCmd.Connection = con;
            delCmd.CommandText = "DELETE FROM Students " +
                                 "WHERE StudentID=@StudentID";
            delCmd.Parameters.AddWithValue("@StudentID", stu.StudentID);

            try
            {
                con.Open();
                int rowsAffected = delCmd.ExecuteNonQuery();
                //check that one student was deleted
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
