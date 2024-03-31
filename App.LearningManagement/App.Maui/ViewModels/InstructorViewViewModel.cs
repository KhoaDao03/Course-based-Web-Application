using Library.LearningManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    public class InstructorViewViewModel
    {
        private IEnumerable<string> student;
        public IEnumerable<string> Students 
        {
            get
            {
                return StudentService.Students;
            }
        }
        public InstructorViewViewModel() 
        { 
           
        }
    }
}
