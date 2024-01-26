using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LearningManagement.Helpers
{
    public class PersonHelper
    {
        public void personName() {
            Console.WriteLine("Enter person name: ");
            var name = Console.ReadLine();
        }

        public void personClassification() {
            Console.WriteLine("Enter person classification: ");
            var description = Console.ReadLine();
        }

        public void personGrades() { 
            Console.WriteLine("Enter person grades: ");
            var code = Console.ReadLine();

        }
    }
}
