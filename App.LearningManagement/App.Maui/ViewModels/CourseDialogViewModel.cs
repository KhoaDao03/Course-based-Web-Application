using Library.LearningManagement.Models;
using Library.LearningManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    class CourseDialogViewModel
    {
        private Course? course;
        public Course? Course
        {
            get => course;
        }
        public string Name
        {
            get { return course?.Name ?? string.Empty; }
            set
            {
                if (course == null) course = new Course();
                course.Name = value;
            }
        }



        public string Code
        {
            get { return course?.Code ?? string.Empty; }
            set
            {
                if (course == null) course = new Course();
                course.Code = value;
            }
        }

        public string Description
        {
            get { return course?.Description ?? string.Empty; }
            set
            {
                if (course == null) course = new Course();
                course.Description = value;
            }
        }

        public CourseDialogViewModel()
        {
            course = new Course
            {
                Name = "Full Stack",
                Code = "COP4870",
                Description = "Full Stack Dev with C#"
            };
        }

        public void AddCourse()
        {
            if (course != null)
            {
                CourseService.Current.Add(course);
                course = null;
            }
        }
    }
}
