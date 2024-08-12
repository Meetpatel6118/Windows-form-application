using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPRAC_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Question 1.1
            DataSet StudentProjectDB = new DataSet("StudentProjectDB");

            // Question 1.2
            DataTable Students = new DataTable("Students");
            Students.Columns.Add("StudentID", typeof(int));
            Students.Columns.Add("FirstName", typeof(string));
            Students.Columns.Add("LastName", typeof(string));
            Students.Columns.Add("Username", typeof(string));
            Students.PrimaryKey = new DataColumn[] { Students.Columns["StudentID"] };

            DataTable Projects = new DataTable("Projects");
            Projects.Columns.Add("ProjectID", typeof(string));
            Projects.Columns.Add("ProjectName", typeof(string));
            Projects.Columns.Add("DueDate", typeof(DateTime));
            Projects.PrimaryKey = new DataColumn[] { Projects.Columns["ProjectID"] };

            DataTable ProjectAssignments = new DataTable("ProjectAssignments");
            ProjectAssignments.Columns.Add("AssignmentID", typeof(int));
            ProjectAssignments.Columns.Add("ProjectID", typeof(string));
            ProjectAssignments.Columns.Add("StudentID", typeof(int));
            ProjectAssignments.PrimaryKey = new DataColumn[] { ProjectAssignments.Columns["AssignmentID"] };

            // Adding DataTables to the DataSet
            StudentProjectDB.Tables.Add(Students);
            StudentProjectDB.Tables.Add(Projects);
            StudentProjectDB.Tables.Add(ProjectAssignments);

            // Question 2.1
            Students.Rows.Add(1111111, "Mary", "Brown", "mary1111");
            Students.Rows.Add(2222222, "Mary", "Green", "mary2222");
            Students.Rows.Add(3333333, "Thomas", "Moore", "thomas3333");

            // Displaying Students DataTable
            Console.WriteLine("Students DataTable:");
            foreach (DataRow row in Students.Rows)
            {
                Console.WriteLine($"{row["StudentID"]} {row["FirstName"]} {row["LastName"]} {row["Username"]}");
            }

            // Question 2.2
            Projects.Rows.Add("PRJ101", "Shopping Cart in C#", new DateTime(2024, 4, 20));
            Projects.Rows.Add("PRJ102", "Hi-Tech Online Order Management", new DateTime(2024, 4, 20));

            // Displaying Projects DataTable
            Console.WriteLine("\nProjects DataTable:");
            foreach (DataRow row in Projects.Rows)
            {
                Console.WriteLine($"{row["ProjectID"]} {row["ProjectName"]} {row["DueDate"]}");
            }
        }
    }
}
