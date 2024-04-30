using Library.LearningManagement.Database;
using Library.LearningManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.LearningManagement.Services
{
    public class InstructorService
    {
        public static InstructorService? instance;

        public IEnumerable<Person> instructors
        {
            get
            {
                return FakeDatabase.Instructors;
            }
        }

        private InstructorService()
        {

        }

        public static InstructorService Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new InstructorService();
                }
                return instance;

            }
        }

        public void AddOrUpdate(Person instructor)
        {
            if (instructor.Id <= 0)
            {
                instructor.Id = LastId + 1;
            }
            var existsInstructor = FakeDatabase.Instructors.FirstOrDefault(x => x.Id == instructor.Id);
            if (existsInstructor != null)
            {
                // If it exists, update the existing instance instead of removing and adding.
                FakeDatabase.Instructors[FakeDatabase.Instructors.IndexOf(existsInstructor)] = instructor;
            }
            else
            {
                // If it does not exist, add it to the list.
                FakeDatabase.Instructors.Add(instructor);
            }
        }

        public void Remove(Person instructor)
        {
            FakeDatabase.Instructors.Remove(instructor);
        }

        public Person? Get(string name)
        {
            return FakeDatabase.Instructors.FirstOrDefault(x => x.Name == name);
        }


        private int LastId
        {
            get
            {
                return instructors.Select(c => c.Id).Max();
            }
        }

        public Person? Get(int id)
        {
            return FakeDatabase.Instructors.FirstOrDefault(c => c.Id == id);
        }

        
        //private static InstructorService instructorList;
        //private IList<Person> instance;
        //private string? query;

        //private InstructorService()
        //{
        //    instance = new List<Person> {
        //        new Person{ Name = "Bellona"},
        //        new Person{ Name = "Lua"},
        //        new Person{ Name = "Nahkwol"},
        //        new Person{ Name = "Belian"},
        //    };
        //}
        //public static InstructorService Current
        //{
        //    get
        //    {

        //        if (instructorList == null)
        //        {
        //            instructorList = new InstructorService();
        //        }

        //        return instructorList;
        //    }

        //}

        //public void Add(Person p)
        //{
        //    instance.Add(p);
        //}

        //public void Remove(Person p)
        //{
        //    instance.Remove(p);
        //}
        //public Person Get(int c)
        //{
        //    return instance[c];
        //}
        //public int Count()
        //{
        //    return instance.Count;
        //}
        //public void setName(int c, string n)
        //{
        //    instance[c].Name = n;
        //}
        //public void setGrade(int c, string n)
        //{
        //    instance[c].Grades = n;
        //}
        //public void setClassification(int c, string n)
        //{
        //    instance[c].Classification = n;
        //}

        //public IEnumerable<Person> Search(string query)
        //{
        //    this.query = query;
        //    return Instances;
        //}

        //public IEnumerable<Person> Instances
        //{
        //    get
        //    {
        //        return instance.Where(
        //            i =>
        //            i.Name.ToUpper().Contains(query.ToUpper() ?? string.Empty)
        //            );
        //    }
        //}
    }
}
