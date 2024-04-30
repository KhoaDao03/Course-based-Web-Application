using Library.LearningManagement.Models;
using Library.LearningManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    public class InstructorDialogViewModel
    {
        private Person? instructor;
        public Person? Instructor
        {
            get => instructor;
        }
        public string Name
        {
            get { return instructor?.Name ?? string.Empty; }
            set {
                if (instructor == null) instructor = new Person();
                instructor.Name = value;
            }
        }



        public string Classification
        {
            get { return instructor?.Classification ?? string.Empty; }
            set {
                if (instructor == null) instructor = new Person();
                instructor.Classification = value;
            }
        }

        public string Grades
        {
            get { return instructor?.Grades ?? string.Empty; }
            set {
                if (instructor == null) instructor = new Person();
                instructor.Grades = value;
            }
        }

        public InstructorDialogViewModel(int iId)
        {
            if (iId == 0)
            {
                instructor = new Person
                {
                    Name = "Acheron",
                    Classification = "Instructor",
                    Grades = string.Empty
                };
            } 
            else
            {
                instructor = InstructorService.Current.Get(iId) ?? new Person();
                
            }
        }
        
            
        

        public void AddInstructor()
        {
            if (instructor != null)
            {
                InstructorService.Current.AddOrUpdate(instructor);
                instructor = null;
            }
        }
    }
}
