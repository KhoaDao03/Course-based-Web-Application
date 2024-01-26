using App.LearningManagement.Helpers;
using Library.LearningManagement.Models;
using System;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var courseHlpr = new CourseHelper();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Add a new course");
            var myCourse = new Course();
            //courseHlpr.courseName();
            //courseHlpr.courseCode();
            //courseHlpr.courseDescription();
            addCourse();
            addCourse();

            Console.WriteLine("Finish adding");

            foreach (Course c in CourseHelper.current.Instances) { 
                Console.WriteLine(c);
            }
        }


        static void addCourse() {
            Console.WriteLine("Enter course name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter course description");
            var description = Console.ReadLine();

            Console.WriteLine("Enter course code");
            var code = Console.ReadLine();

            Course course;
            course = new Course{ Name = name, Description = description, Code = code };
            CourseHelper.current.Add(course);

        }

    }
}