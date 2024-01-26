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
        private static IList<Course>? instance;
        private static CourseHelper? courseList;
        ////private static object block;
        private string? query;


        private CourseHelper()
        {
            instance = new List<Course>();

        }
        public void Add(Course courses)
        {
            instance.Add(courses);
        }

        public void Remove(Course courses) 
        { 
            instance.Remove(courses);
        }
        public Course Get(int c)
        {
            return instance[c];
        }
        public int Count()
        {
            return instance.Count;
        }


        //public void addPerson(int choice, Person p)
        //{
        //    instance[choice].Roster.Add(p);
        //}


        public static CourseHelper current
        {
            get
            {
                //lock (block) {
                if (courseList == null)
                {
                    courseList = new CourseHelper();
                }
                //}
                return courseList;
            }

        }

        public IEnumerable<Course> Search(string query)
        {
            this.query = query;
            return Instances;
        }


        public IEnumerable<Course> Instances
        {
            get
            {
                return instance.Where(
                    i =>
                    i.Name.Contains(query ?? string.Empty) ||
                    i.Code.Contains(query ?? string.Empty)
                    );
            }
        }








    }
}
