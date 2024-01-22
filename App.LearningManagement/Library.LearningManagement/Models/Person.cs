namespace Library.LearningManagement.Models
{
    public class Person
    {
        public int id { get; set; }
        public string? name { get; set; }
        public Dictionary<int, double> Grades { get; set; }
        public char Classification { get; set; }
        public Person()
        {
            Grades = new Dictionary<int, double>();
        }
    }
}
