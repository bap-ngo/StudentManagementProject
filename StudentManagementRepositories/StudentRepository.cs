using StudentManagementObject;

namespace StudentManagementRepositories
{
    public class StudentRepository
    {
        public List<StudentDTO> getCsvStudent(string filePath)
        {
            List<StudentDTO> students = new List<StudentDTO>();
            //string filePath = @"C:\Users\Koushik\Desktop\Questions\ConsoleApp\Data.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    StudentDTO student = new StudentDTO(values[0], values[1], int.Parse(values[2]));
                    students.Add(student);
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            return students;
        }
    }
}