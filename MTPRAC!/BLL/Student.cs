using MTPRAC_.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTPRAC_.BLL
{
    public class Student
    {
        private int studentNumber;
        private string FirstName;
        private string LastName;
        private string Email;
        private int PhoneNumber;

        public Student() { }

        public Student(int studentNumber, string firstName, string lastName, string email, int phoneNumber)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            
        }

        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }


        public void SaveInfo(Student student)
        {
            StudentDB.SaveInfo(student);
        }

        public List<Student> GetStudentList()
        {
            return StudentDB.GetAllInfos();
        }

        public Student SearchStudent(string StudentName)
        {
            return StudentDB.SearchRecord(StudentName);
        }

        public bool IsUniqueUName(string StudentName) => StudentDB.IsUniqueStudentNumber(StudentName);

       
    }
}
