using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    public class StudentViewViewModel
    {
        private IEnumerable<string> student;
        public IEnumerable<string> Students
        {
            get
            {
                return student;
            }
        }
        public StudentViewViewModel()
        {
            student = new List<string> { "Bellona", "Lua", "Nahkwol" };
        }
    }
}
