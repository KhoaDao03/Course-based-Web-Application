using Library.LearningManagement.Models;
using Library.LearningManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    class StudentDialogViewModel
    {
        private Person? student;
        public Person? Student
        {
            get => student;
        }
        public string Name
        {
            get { return student?.Name ?? string.Empty; }
            set
            {
                if (student == null) student = new Person();
                student.Name = value;
            }
        }



        public string Classification
        {
            get { return student?.Classification ?? string.Empty; }
            set
            {
                if (student == null) student = new Person();
                student.Classification = value;
            }
        }

        public string Grades
        {
            get { return student?.Grades ?? string.Empty; }
            set
            {
                if (student == null) student = new Person();
                student.Grades = value;
            }
        }

        public StudentDialogViewModel()
        {
            student = new Person
            {
                Name = "Elysia",
                Classification = "Senior",
                Grades = "A"
            };
        }

        public void AddStudent()
        {
            if (student != null)
            {
                StudentService.Current.Add(student);
                student = null;
            }
        }
    }
}
