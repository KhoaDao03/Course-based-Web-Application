using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LearningManagement.Helpers
{
    public class ContentItem
    {
        public void contentName() {
            Console.WriteLine("Enter content name: ");
            var name = Console.ReadLine();
        }

        public void contentDescription() {
            Console.WriteLine("Enter content description: ");
            var description = Console.ReadLine();
        }

        public void contentPath() { 
            Console.WriteLine("Enter content path: ");
            var code = Console.ReadLine();

        }
    }
}
