using App.LearningManagement.Helpers;
using Library.LearningManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var courseList = CourseHelper.current;
            //var personList = new PersonHelper();
            Console.WriteLine("Welcome to Programming Assignment 1");
            int choice;
            while (true)
            {
                choice = printMenu();

                if (choice == 0)
                {

                    printCourseList();
                    Console.WriteLine("Enter any key to continue");
                    Console.ReadKey();
                }
                else if (choice == 1)
                {
                    addCourse();
                }
                else if (choice == 2)
                {
                    removeCourse();
                }
                else if (choice == 3) 
                {
                    printPersonList();
                }
                else if (choice == 4)
                {
                    addPerson();
                }
                else if (choice == 5) 
                {
                    removePerson();
                }
                else if (choice == 6)
                {
                    addPersonToCourse();
                }
                else if (choice == 7)
                {
                    removePersonToCourse();
                }
                else if (choice == 8)
                {
                    listStudentCourse();
                }
                else if (choice == 9)
                {
                    listCourseStudent();
                }
                else if (choice == -1)
                {
                    Console.WriteLine("Exit the program.");
                    break;
                }
                Console.WriteLine("");


            }

        }

        static int printMenu() { 
            Console.WriteLine("Menu:");
            Console.WriteLine("0. Print course list");
            Console.WriteLine("1. Add a course");
            Console.WriteLine("2. Remove a course");

            Console.WriteLine("");
            Console.WriteLine("3. Print person list");
            Console.WriteLine("4. Add a person to the list");
            Console.WriteLine("5. Remove a person from the list");

            Console.WriteLine("");
            Console.WriteLine("6. Add a person to a course");
            Console.WriteLine("7. Remove a perosn from a course");
            Console.WriteLine("8. List all courses a person is taking");
            Console.WriteLine("9. List all students in a course");

            Console.WriteLine("");
            Console.WriteLine("9. List all students in a course");








            Console.WriteLine("-1. Exit the program");

            Console.Write("> ");
            var choice = Console.ReadLine();
            int c;
            while (!int.TryParse(choice, out c) && c < -1 && c > 2 ) { 
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            
            return c;


            
        }

        static void addCourse() {
            Console.WriteLine("Adding a new course.");
            Console.WriteLine("Enter course name: ");
            Console.Write("> ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter course description: ");
            Console.Write("> ");
            var description = Console.ReadLine();

            Console.WriteLine("Enter course code: ");
            Console.Write("> ");
            var code = Console.ReadLine();

            Course course;
            course = new Course { Name = name, Description = description, Code = code };
            CourseHelper.current.Add(course);

        }


        static void removeCourse() {
            Console.WriteLine("Removing a course.");
            printCourseList();
            Console.WriteLine("Choose a course to remove");
            Console.Write("> ");
            var choice = Console.ReadLine();
            int c;
            while (!int.TryParse(choice, out c) && c < 0 && c > CourseHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            CourseHelper.current.Remove(CourseHelper.current.Get(c));
        }
        


        static void printCourseList() {
            Console.WriteLine("Printing course list.");
            if (CourseHelper.current.Count() == 0) {
                Console.WriteLine("The course list is empty. Try to add a course to proceed");
                return;
            }
            Console.WriteLine($"There are: {CourseHelper.current.Count()} course/courses. ");
            for (int i = 0; i < CourseHelper.current.Count(); i++) {
                Console.WriteLine($"{i}. {CourseHelper.current.Get(i)}");
            }
        }




        static void addPerson()
        {
            Console.WriteLine("Enter person name: ");
            Console.Write("> ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter person classification: ");
            Console.Write("> ");
            var classification = Console.ReadLine();

            Console.WriteLine("Enter person's grade: ");
            Console.Write("> ");
            var grade = Console.ReadLine();

            Person person;
            person = new Person { Name = name, Classification = classification, Grades = grade };
            PersonHelper.current.Add(person);

        }


        static void removePerson()
        {
            Console.WriteLine("Removing a person.");
            printPersonList();
            Console.WriteLine("Choose a person to remove");
            Console.Write("> ");
            var choice = Console.ReadLine();
            int c;
            while (!int.TryParse(choice, out c) && c < 0 && c > PersonHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            PersonHelper.current.Remove(PersonHelper.current.Get(c));
        }



        static void printPersonList()
        {
            Console.WriteLine("Printing person list.");
            if (PersonHelper.current.Count() == 0)
            {
                Console.WriteLine("The person list is empty. Try to add a person to proceed");
                return;
            }
            Console.WriteLine($"There are: {PersonHelper.current.Count()} person/people. ");
            for (int i = 0; i < PersonHelper.current.Count(); i++)
            {
                Console.WriteLine($"{i}. {PersonHelper.current.Get(i)}");
            }
        }


        static void addPersonToCourse() {
            Console.WriteLine("Choose a course to add student");
            printCourseList();
            Console.Write("> ");
            var choice = Console.ReadLine();
            int cCourse;
            while (!int.TryParse(choice, out cCourse) && cCourse < 0 && cCourse > CourseHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }


            Console.WriteLine("Choose the student to be added");
            printPersonList();
            Console.Write("> ");
            choice = Console.ReadLine();
            int cPerson;
            while (!int.TryParse(choice, out cPerson) && cPerson < 0 && cPerson > PersonHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            CourseHelper.current.Get(cCourse).Roster.Add(PersonHelper.current.Get(cPerson));
            PersonHelper.current.Get(cPerson).Courses.Add(CourseHelper.current.Get(cCourse));


        }


        static void removePersonToCourse()
        {
            Console.WriteLine("Choose a course to add student");
            printCourseList();
            Console.Write("> ");
            var choice = Console.ReadLine();
            int cCourse;
            while (!int.TryParse(choice, out cCourse) && cCourse < 0 && cCourse > CourseHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }


            Console.WriteLine("Choose the student to be added");
            for (int i = 0; i < CourseHelper.current.Get(cCourse).Roster.Count; i++)
            {
                Console.WriteLine($"{i}. {CourseHelper.current.Get(cCourse).Roster[i]}");
            }
            Console.Write("> ");
            choice = Console.ReadLine();
            int cPerson;
            while (!int.TryParse(choice, out cPerson) && cPerson < 0 && cPerson > PersonHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            CourseHelper.current.Get(cCourse).Roster.Remove(PersonHelper.current.Get(cPerson));
            PersonHelper.current.Get(cPerson).Courses.Remove(CourseHelper.current.Get(cCourse));


        }


        static void listStudentCourse() {
            Console.WriteLine("Choose the student to be listed");
            printPersonList();
            Console.Write("> ");
            var choice = Console.ReadLine();
            int cPerson;
            while (!int.TryParse(choice, out cPerson) && cPerson < 0 && cPerson > PersonHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }

            foreach (Course c in PersonHelper.current.Get(cPerson).Courses) {
                Console.WriteLine(c);
            }
        }


        static void listCourseStudent()
        {
            Console.WriteLine("Choose a course to show student");
            printCourseList();
            Console.Write("> ");
            var choice = Console.ReadLine();
            int cCourse;
            while (!int.TryParse(choice, out cCourse) && cCourse < 0 && cCourse > CourseHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }

            foreach (Person p in CourseHelper.current.Get(cCourse).Roster)
            {
                Console.WriteLine(p);
            }
        }





    }
}