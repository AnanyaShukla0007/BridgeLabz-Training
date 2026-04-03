namespace EduResults
{
    internal class Student
    {
        private string name;
        private int marks;
        private string district;

        public Student(string name, int marks, string district)
        {
            this.name = name;
            this.marks = marks;
            this.district = district;
        }

        public int GetMarks()
        {
            return marks;
        }

        public string GetInfo()
        {
            return name + " | " + marks + " | " + district;
        }
    }
}
