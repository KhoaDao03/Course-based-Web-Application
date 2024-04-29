namespace Library.LearningManagement.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Grades { get; set; }
        public string? Classification { get; set; }

        public List<Course> Courses { get; set; }

        public Person()
        {
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            return $"\nName {Name} \nClassification: {Classification}" +
                $"\nGrade: {Grades}";
        }
    }
}
