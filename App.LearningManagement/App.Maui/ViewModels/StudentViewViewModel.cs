using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    public class StudentViewViewModel
    {
        private IEnumerable<string> instructor;
        public IEnumerable<string> Instructors
        {
            get
            {
                return instructor;
            }
        }
        public StudentViewViewModel()
        {
            instructor = new List<string> { "Bellona", "Lua", "Nahkwol" };
        }
    }
}
