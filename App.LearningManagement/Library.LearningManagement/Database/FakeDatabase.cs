using Library.LearningManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LearningManagement.Database
{
    public static class FakeDatabase
    {
        private static List<Person> instructors = new List<Person>
        {
            new Person{Id = 1,Name = "Navia" },
            new Person{Id = 2,Name = "Kokomi" },
            new Person{Id = 3, Name = "Mei" },

        };
        private static List<Person> students = new List<Person>
        {
            new Person{Id = 1,  Name = "Bellona", Classification= "Junior", Grades= "A" },
            new Person{Id = 2,Name = "Lua", Classification= "Junior", Grades= "A" },
            new Person{Id = 3,Name = "Nahkwol", Classification= "Junior", Grades= "A" },

        };

        private static List<Course> courses = new List<Course>
        {
            new Course{
                Id = 1,
                Code = "COP3330", 
                Name= "Programming 1", 
                Description= "Computer Science" },
            new Course{
                Id = 2,
                Code = "MAC2312",
                Name= "Calculus 2",
                Description= "Math" },
            new Course{
                Id = 3,
                Code = "BSC2010",
                Name= "Biology 1",
                Description= "Biology" }


        };

        public static List<Person> Students
        {
            get { return students; }
        }

        public static List<Person> Instructors
        {
            get { return instructors; }
        }
        public static List<Course> Courses
        {
            get { return courses; }
        }
    }
}
