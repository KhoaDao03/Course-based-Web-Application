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
    public class StudentViewViewModel : INotifyPropertyChanged
    {
        private StudentService studentSvc;

        public StudentViewViewModel()
        {
            studentSvc = StudentService.Current;
        }
        public ObservableCollection<Person> Students
        {
            get
            {
                return new ObservableCollection<Person>(studentSvc.students);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Refresh()
        {
            NotifyPropertyChanged(nameof(Students));
        }

        public Person SelectedStudent
        {
            get; set;
        }
        public void Remove()
        {
            studentSvc.Remove(SelectedStudent);
            Refresh();
        }
    }
}
