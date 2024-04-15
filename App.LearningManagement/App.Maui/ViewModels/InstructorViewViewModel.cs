
using Library.LearningManagement.Models;
using Library.LearningManagement.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Maui.ViewModels
{
    public class InstructorViewViewModel : INotifyPropertyChanged
    {
        private InstructorService instructorSvc;


        public InstructorViewViewModel()
        {
            instructorSvc = InstructorService.Current;
        }
        public ObservableCollection<Person> Instructors
        {
            get
            {
                return new ObservableCollection<Person>(instructorSvc.instructors);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Refresh()
        {
            //instructorSvc.Add(new Person { Name = "Acheron" });
            NotifyPropertyChanged(nameof(Instructors));
        }

        public Person SelectedInstructor
        {
            get; set;
        }
        public void Remove()
        {
            instructorSvc.Remove(SelectedInstructor);
            Refresh();
        }
    }
}
