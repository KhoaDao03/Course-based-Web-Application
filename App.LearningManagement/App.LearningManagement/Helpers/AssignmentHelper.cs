using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LearningManagement.Helpers
{
    public class AssignmentHelper
    {
        public void assignmentName()
        {
            Console.WriteLine("Enter assignment name: ");
            var name = Console.ReadLine();

        }

        public void assignmentDescription()
        {
            Console.WriteLine("Enter assignment description: ");
            var description = Console.ReadLine();
        }

        public void assignmentPoints()
        {
            Console.WriteLine("Enter assignemnt total available points: ");
            var points = Console.ReadLine();

        }
        public void assignmentDueDate()
        {
            Console.WriteLine("Enter assignemnt due date: ");
            var date = Console.ReadLine();

        }
    }
}
