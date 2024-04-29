using Library.LearningManagement.Database;
using Library.LearningManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LearningManagement.Services
{
    public class StudentService
    {

        public static StudentService? instance;

        public IEnumerable<Person> students
        {
            get
            {
                return FakeDatabase.Students;
            }
        }

        private StudentService()
        {

        }

        public static StudentService Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentService();
                }
                return instance;

            }
        }

        public void Add(Person student)
        {
            FakeDatabase.Students.Add(student);
        }

        public void Remove(Person student)
        {
            FakeDatabase.Students.Remove(student);
        }

        public Person? Get(string name)
        {
            return FakeDatabase.Students.FirstOrDefault(x => x.Name == name);
        }

        private int LastId
        {
            get
            {
                return instructors.Select(c => c.Id).Max();
            }
        }

    }
}
