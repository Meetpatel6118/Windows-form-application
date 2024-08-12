using MTPRAC_.BLL;
using MTPRAC_.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MTPRAC_.GUI
{
    public partial class StudentMaintenance : Form
    {
        private List<Student> students = new List<Student>();
        public StudentMaintenance()
        {
            InitializeComponent();
        }

       

        

        private void buttonExit_Click(object sender, EventArgs e)
        {
                DialogResult dialogResult = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
        }

        private void LoadStudentsToListView()
        {
            listView1.Items.Clear();
            foreach (Student student in students)
            {
                
                        ListViewItem item = new ListViewItem();
                        item.SubItems.Add(student.FirstName1);
                        item.SubItems.Add(student.LastName1);
                        item.SubItems.Add(student.Email1);
                       
                listView1.Items.Add(item);
                    
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string StudentNumber = textBoxSN.Text;
            string FirstName = textBoxFN.Text;
            string LastName = textBoxLN.Text;
            string Email = textBoxEmail.Text;
            string PhoneNumber = textBoxPN.Text;


            Student student = new Student()
            {
                StudentNumber = Convert.ToInt32(StudentNumber),
                FirstName1 = FirstName,
                LastName1 = LastName,
                Email1 = Email,
                PhoneNumber1 = Convert.ToInt32(PhoneNumber),
            };
            
        }
    }
}
