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
    public partial class StudentLoginGUI : Form
    {
        private StudentService studentService;
        public StudentLoginGUI()
        {
            InitializeComponent();
            studentService = new StudentService();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(studentService.getCsvStudentServices(@"\\Mac\Home\Documents\StudentInfo.csv").Count.ToString());
        }
    }
}
