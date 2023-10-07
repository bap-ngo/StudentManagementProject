using StudentManagementObject;
using StudentManagementService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class StudentManageGUI : Form
    {
        private StudentService studentService;
        public StudentManageGUI()
        {
            InitializeComponent();
            studentService = new StudentService();
            List<StudentDTO> studentList = studentService.getCsvStudentServices(@"\\Mac\Home\Documents\StudentInfo.csv");
            dtg_StudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_StudentList.DataSource = studentList;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(studentService.getCsvStudentServices(@"\\Mac\Home\Documents\StudentInfo.csv").Count.ToString());
        }
    }
}
