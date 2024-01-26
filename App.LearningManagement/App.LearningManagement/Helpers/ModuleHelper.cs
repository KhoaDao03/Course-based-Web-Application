using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LearningManagement.Helpers
{
    public class ModuleHelper
    {
        public void moduleName()
        {
            Console.WriteLine("Enter course name: ");
            var name = Console.ReadLine();
        }

        public void moduleDescription()
        {
            Console.WriteLine("Enter course description: ");
            var description = Console.ReadLine();
        }

    }
}
