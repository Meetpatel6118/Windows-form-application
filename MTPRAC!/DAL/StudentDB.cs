using MTPRAC_.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTPRAC_.DAL
{
    public class StudentDB
    {
                                                                //Saving Student Details

        public static void SaveInfo(Student student )
        {
            // step 1: Connect db open
            SqlConnection conn = UtilityDB.ConnectDB();

            // step 2: do insert operation
            // create and customize an obj of type sql command

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Student (StudentNumber, FirstName, LastName ,Email , PhoneNumber) " +
                                    "VALUES(@StudentNumber, @FirstName, @LastName ,@Email , @PhoneNumber)";
            cmdInsert.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
            cmdInsert.Parameters.AddWithValue("@FirstName ", student.FirstName1);
            cmdInsert.Parameters.AddWithValue("@LastName", student.LastName1);
            cmdInsert.Parameters.AddWithValue("@Email", student.Email1);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber1);



            cmdInsert.ExecuteNonQuery();

            // step 3: close db
            conn.Close();
        }
                                                        // List out Students List

        public static List<Student> GetAllInfos()
        {
            List<Student> listStudent = new List<Student>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM StudentAccounts", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader(); //APPLIES TO SELECT
            Student student;
            while (reader.Read())
            {
                student = new Student();
                student.StudentNumber = (int)reader["StudentNumber"];
                student.FirstName1 = reader["FirstName"].ToString();
                student.LastName1 = reader["LastName"].ToString();
                student.Email1 = reader["Email"].ToString();
                student.PhoneNumber1 = (int)reader["Phone Number"];

                listStudent.Add(student);
            }
            conn.Close();
            return listStudent;
        }

                                                                       //Search Student in the list
        public static Student SearchRecord(string UsName)
        {
            Student Student = new Student();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchByID = new SqlCommand();
            cmdSearchByID.Connection = conn;
            cmdSearchByID.CommandText = "SELECT * FROM StudentAccounts " +
                                        "WHERE StudentName=@StudentName";
            cmdSearchByID.Parameters.AddWithValue("@StudentName", UsName);
            SqlDataReader reader = cmdSearchByID.ExecuteReader();
            if (reader.Read())
            {

                Student.StudentNumber = (int)reader["StudentNumber"];
                Student.FirstName1 = reader["FirstName"].ToString();
                Student.LastName1 = reader["LastName"].ToString();
                Student.Email1 = reader["Email"].ToString();
                Student.PhoneNumber1 = (int)reader["Phone Number"];

            }
            else
            {
                Student = null;
            }
            conn.Close();
            return Student;
        }

        public static bool IsUniqueStudentNumber(string UsNumber)
        {
            Student Student = SearchRecord(UsNumber);
            if (Student != null)
            {
                return false;
            }
            return true;
        }
    }
}
