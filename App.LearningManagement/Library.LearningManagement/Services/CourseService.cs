using Library.LearningManagement.Database;
using Library.LearningManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.LearningManagement.Services
{
    public class CourseService
    {
        public static CourseService? instance;

        public IEnumerable<Course> courses
        {
            get
            {
                return FakeDatabase.Courses;
            }
        }

        private CourseService()
        {

        }

        public static CourseService Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new CourseService();
                }
                return instance;

            }
        }

        public void Add(Course course)
        {
            FakeDatabase.Courses.Add(course);
        }

        public void Remove(Course course)
        {
            FakeDatabase.Courses.Remove(course);
        }

        public Course? Get(string name)
        {
            return FakeDatabase.Courses.FirstOrDefault(x => x.Name == name);
        }
    }
}
