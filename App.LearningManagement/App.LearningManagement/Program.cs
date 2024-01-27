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

            Console.WriteLine("Welcome to Programming Assignment 1");
            int choice;
            while (true)
            {
                choice = printMenu();

                if (choice == 0)
                {

                    printCourseListFull();
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
                    Console.WriteLine("Enter any key to continue");
                    Console.ReadKey();
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
                    removePersonFromCourse();
                }
                else if (choice == 8)
                {
                    printPersonCourse(choosePerson());
                    Console.WriteLine("Enter any key to continue");
                    Console.ReadKey();
                }
                else if (choice == 9)
                {
                    printCoursePerson(chooseCourse());
                    Console.WriteLine("Enter any key to continue");
                    Console.ReadKey();
                }
                else if (choice == 10)
                {
                    modifyCourse();
                }
                else if (choice == 11)
                {
                    modifyPerson();

                }
                else if (choice == 12)
                {
                    searchCourse();

                }
                else if (choice == 13)
                {
                    searchPerson();

                }
                else if (choice == 14)
                {
                    addAssignemnt();

                }
                else if (choice == 15)
                {
                    printAssignments(chooseCourse());

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
            Console.WriteLine("9. List all Persons in a course");

            Console.WriteLine("");
            Console.WriteLine("10. Modify a Course");
            Console.WriteLine("11. Modify a Person");

            Console.WriteLine("");
            Console.WriteLine("12. Search a Course");
            Console.WriteLine("13. Search a Person");

            Console.WriteLine("");
            Console.WriteLine("14. Add Assignment");
            Console.WriteLine("15. Print Assignments in a Course");


            Console.WriteLine("\nEnter a number: ");








            Console.WriteLine("-1. Exit the program");

            Console.Write("> ");
            var choice = Console.ReadLine();
            int c;
            while (!int.TryParse(choice, out c)) { 
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            
            return c;


            
        }

        static int chooseCourse() {
            Console.WriteLine("Choose a course");
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
            return cCourse;
        }

        static int choosePersonC(int cCourse) {
            Console.WriteLine("Choose the person");
            for (int i = 0; i < CourseHelper.current.Get(cCourse).Roster.Count; i++)
            {
                Console.WriteLine($"{i}. {CourseHelper.current.Get(cCourse).Roster[i]}");
            }
            Console.Write("> ");
            var choice = Console.ReadLine();
            int cPerson;
            while (!int.TryParse(choice, out cPerson) && cPerson < 0 && cPerson > PersonHelper.current.Count())
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            return cPerson;
        }

        static int choosePerson() {
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
            course = new Course { 
                Name = name, 
                Description = description, 
                Code = code 
            };
            CourseHelper.current.Add(course);

        }


        static void removeCourse() {
            CourseHelper.current.Remove(CourseHelper.current.Get(chooseCourse()));
        }
        


        static void printCourseList() {
            Console.WriteLine("Printing course list.");
            if (CourseHelper.current.Count() == 0) {
                Console.WriteLine("The course list is empty.");
                return;
            }
            Console.WriteLine($"There are: {CourseHelper.current.Count()} course/courses. ");
            for (int i = 0; i < CourseHelper.current.Count(); i++) {
                Console.WriteLine($"{i}. {CourseHelper.current.Get(i)}");
                Console.WriteLine("");
            }
        }
        static void printCourseListFull()
        {
            Console.WriteLine("Printing course list.");
            if (CourseHelper.current.Count() == 0)
            {
                Console.WriteLine("The course list is empty.");
                return;
            }
            Console.WriteLine($"There are: {CourseHelper.current.Count()} course/courses. ");
            for (int i = 0; i < CourseHelper.current.Count(); i++)
            {
                Console.WriteLine($"{i}. {CourseHelper.current.Get(i).Print()}");
                Console.WriteLine("");
                printCoursePerson(i);
                Console.WriteLine("");
                printAssignments(i);
                Console.WriteLine("");
                Console.WriteLine($"Module is empty");


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
            person = new Person { 
                Name = name, 
                Classification = classification, 
                Grades = grade 
            };
            PersonHelper.current.Add(person);

        }


        static void removePerson()
        {
            PersonHelper.current.Remove(PersonHelper.current.Get(choosePerson()));
        }



        static void printPersonList()
        {
            Console.WriteLine("Printing person list.");
            if (PersonHelper.current.Count() == 0)
            {
                Console.WriteLine("The person list is empty.");
                return;
            }
            Console.WriteLine($"There are: {PersonHelper.current.Count()} person/Person. ");
            for (int i = 0; i < PersonHelper.current.Count(); i++)
            {
                Console.WriteLine($"{i}. {PersonHelper.current.Get(i)}");
            }
        }


        static void addPersonToCourse() {
            int cCourse = chooseCourse();

            int cPerson = choosePerson();
           
            CourseHelper.current.Get(cCourse).Roster.Add(PersonHelper.current.Get(cPerson));
            PersonHelper.current.Get(cPerson).Courses.Add(CourseHelper.current.Get(cCourse));


        }


        static void removePersonFromCourse()
        {
            int cCourse = chooseCourse();
            int cPerson = choosePersonC(cCourse);
            CourseHelper.current.Get(cCourse).Roster.Remove(PersonHelper.current.Get(cPerson));
            PersonHelper.current.Get(cPerson).Courses.Remove(CourseHelper.current.Get(cCourse));


        }


        static void printPersonCourse(int cPerson) {

            Console.WriteLine("Courses: ");

            if (PersonHelper.current.Get(cPerson).Courses.Count() == 0)
            {
                Console.WriteLine("The course list is empty.");
                return;
            }
            foreach (Course c in PersonHelper.current.Get(cPerson).Courses) {
                Console.WriteLine(c);
            }
        }


        static void printCoursePerson(int cCourse)
        {

            Console.WriteLine("Person:");

            if (CourseHelper.current.Get(cCourse).Roster.Count() == 0)
            {
                Console.WriteLine("The person list is empty.");
                return;
            }
            foreach (Person p in CourseHelper.current.Get(chooseCourse()).Roster)
            {
                Console.WriteLine(p);
            }
        }


        static void modifyCourse() {
            int cCourse = chooseCourse();
            Console.WriteLine("Which one do you want to modify:");
            Console.WriteLine("0. Name");
            Console.WriteLine("1. Code");
            Console.WriteLine("2. Description");
            Console.Write("> ");
            var choice = Console.ReadLine();
            int c;
            while (!int.TryParse(choice, out c))
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            var ans = String.Empty;

            if (c == 0) {
                Console.WriteLine("Enter course Name: ");
                Console.Write("> ");
                ans = Console.ReadLine();
                CourseHelper.current.setName(cCourse, ans);

            } else if (c == 1) {
                Console.WriteLine("Enter course Code: ");
                Console.Write("> ");
                ans = Console.ReadLine();
                CourseHelper.current.setCode(cCourse, ans);

            } else if (c == 2) {
                Console.WriteLine("Enter course Description: ");
                Console.Write("> ");
                ans = Console.ReadLine();
                CourseHelper.current.setDescription(cCourse, ans);

            } else {
                Console.WriteLine("No Operation Found");
            }
        }

        static void modifyPerson()
        {
            int cPerson = choosePerson();
            Console.WriteLine("Which one do you want to modify:");
            Console.WriteLine("0. Name");
            Console.WriteLine("1. Grade");
            Console.WriteLine("2. Classification");
            Console.Write("> ");
            var choice = Console.ReadLine();
            int c;
            while (!int.TryParse(choice, out c))
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("> ");
                choice = Console.ReadLine();

            }
            var ans = String.Empty;

            if (c == 0)
            {
                Console.WriteLine("Enter person Name: ");
                Console.Write("> ");
                ans = Console.ReadLine();
                PersonHelper.current.setName(cPerson, ans ?? "");

            }
            else if (c == 1)
            {
                Console.WriteLine("Enter person Grade: ");
                Console.Write("> ");
                ans = Console.ReadLine();
                PersonHelper.current.setGrade(cPerson, ans ?? "");

            }
            else if (c == 2)
            {
                Console.WriteLine("Enter person Classification: ");
                Console.Write("> ");
                ans = Console.ReadLine();
                PersonHelper.current.setClassification(cPerson, ans?? "");

            }
            else
            {
                Console.WriteLine("No Operation Found");
            }
        }

        static void searchCourse()
        {
            Console.WriteLine("Enter the keyword to search in Name and Description: ");
            Console.Write("> ");
            var query = Console.ReadLine();
            Console.WriteLine($"Query: {query}");

            foreach (Course i in CourseHelper.current.Search(query ?? "")) { 
                Console.WriteLine(i);
                Console.WriteLine("");
                Console.WriteLine($"Persons:");
                if (i.Roster.Count() == 0)
                {
                    Console.WriteLine("The course list is empty.");

                }
                else
                {
                    foreach (Person p in i.Roster)
                    {
                        Console.WriteLine(p);
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Assignments: ");
                if (i.Assignments.Count() == 0)
                {
                    Console.WriteLine("The assignemnt list is empty.");
                    return;
                }
                foreach (Assignment a in i.Assignments)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine("");
                Console.WriteLine($"Module is empty");
            }

        }

        static void searchPerson()
        {
            Console.WriteLine("Enter the keyword to search in Name:");
            Console.Write("> ");
            var query = Console.ReadLine();
            foreach (Person i in PersonHelper.current.Search(query ?? ""))
            {
                Console.WriteLine(i);
            }
        }

        static void addAssignemnt() {

            int cCourse = chooseCourse();
            Console.WriteLine("Enter assignment name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter assignment description: ");
            var description = Console.ReadLine();
            Console.WriteLine("Enter assignemnt total available points: ");
            var points = Console.ReadLine();
            Console.WriteLine("Enter assignemnt due date: ");
            var date = Console.ReadLine();
            DateTime d;
            if (!DateTime.TryParse(date, out d))
            {
                d = DateTime.Now;
            }

            double p;
            if (!double.TryParse(points, out p))
            {
                p = 0; 
            }

            Assignment assign = new Assignment
            {
                Name = name,
                Description = description,
                TotalAvailablePoints = (decimal?)p,
                DueDate = d
            };
            CourseHelper.current.Add(cCourse, assign);

        }

        static void printAssignments(int cCourse)
        {
            Console.WriteLine("Assignments: ");
            if (CourseHelper.current.Get(cCourse).Assignments.Count() == 0)
            {
                Console.WriteLine("The assignemnt list is empty.");
                return;
            }
            foreach (Assignment a in CourseHelper.current.Get(cCourse).Assignments) { 
                Console.WriteLine(a);
            }
        }



    }
}