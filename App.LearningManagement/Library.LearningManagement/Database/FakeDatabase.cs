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
            new Person{Name = "Navia" },
            new Person{Name = "Kokomi" },
            new Person{Name = "Mei" },

        };
        private static List<Person> students = new List<Person>();

        public static List<Person> Students
        {
            get { return students; }
        }

        public static List<Person> Instructors
        {
            get { return instructors; }
        }
    }
}
