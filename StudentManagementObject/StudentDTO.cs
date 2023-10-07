namespace StudentManagementObject
{
    public class StudentDTO
    {
        private string studentID;
        private string name;
        private int birthYear;

        public StudentDTO()
        {
        }

        public StudentDTO(string studentID, string name, int birthYear)
        {
            this.studentID = studentID;
            this.name = name;
            this.birthYear = birthYear;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string Name { get => name; set => name = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }

        public int getAge()
        {
            return DateTime.Now.Year - BirthYear;
        }

        public override string? ToString()
        {
            return $"{StudentID} - {Name} - {BirthYear}";
        }
    }
}