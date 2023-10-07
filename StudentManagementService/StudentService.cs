using StudentManagementObject;
using StudentManagementRepositories;

namespace StudentManagementService
{
    public class StudentService
    {
        private StudentRepository studentRepositories;

        public StudentService()
        {
            studentRepositories = new StudentRepository();
        }

        public List<StudentDTO> getCsvStudentServices(string filePath)
        {
            return studentRepositories.getCsvStudent(filePath);
        }
    }
}