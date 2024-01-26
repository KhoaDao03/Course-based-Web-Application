using Library.LearningManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LearningManagement.Helpers
{
    public class CourseHelper
    {
        private IList<Course> instances;
        private static CourseHelper courseList;
        private static object block;
        private string? query;

        private CourseHelper() {
            instances = new List<Course>();
        }

        public static CourseHelper current
        {
            get {
                //lock (block) {
                if (courseList == null) {
                    courseList = new CourseHelper();
                }
                //}
                return courseList;
            }

        }

        public IEnumerable<Course> Search(string query) {
            this.query = query;
            return instances;
        }

        public void Add(Course courses)
        {
            instances.Add(courses);
        }

        public IEnumerable<Course> Instances
        {
            get{
                return instances.Where(
                    i =>
                    i.Name.Contains(query ?? string.Empty) ||
                    i.Code.Contains(query ?? string.Empty)
                    );
            }
        }

        //public void courseName()
        //{
        //    Console.WriteLine("Enter course name: ");
        //    var name = Console.ReadLine();
        //}

        //public void courseDescription()
        //{
        //    Console.WriteLine("Enter course description: ");
        //    var description = Console.ReadLine();
        //}

        //public void courseCode()
        //{
        //    Console.WriteLine("Enter course code: ");
        //    var code = Console.ReadLine();
        //}



    }
}
