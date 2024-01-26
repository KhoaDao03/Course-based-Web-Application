using Library.LearningManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.LearningManagement.Helpers
{

    public class PersonHelper
    {
        private static PersonHelper personList;
        private IList<Person> instance;
        private PersonHelper() {
            instance = new List<Person>();
        }
        public static PersonHelper current
        {
            get
            {
                //lock (block) {
                if (personList == null)
                {
                    personList = new PersonHelper();
                }
                //}
                return personList;
            }

        }

        public void Add(Person p)
        {
            instance.Add(p);
        }

        public void Remove(Person p)
        {
            instance.Remove(p);
        }
        public Person Get(int c)
        {
            return instance[c];
        }
        public int Count()
        {
            return instance.Count;
        }


        //public void Add(Person persons) { 
        //    instance.Add(persons);
        //}

        //public void personName() {
        //    Console.WriteLine("Enter person name: ");
        //    var name = Console.ReadLine();
        //}

        //public void personClassification() {
        //    Console.WriteLine("Enter person classification: ");
        //    var description = Console.ReadLine();
        //}

        //public void personGrades() { 
        //    Console.WriteLine("Enter person grades: ");
        //    var code = Console.ReadLine();

        //}
    }
}
