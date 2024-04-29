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
    public class CourseViewViewModel : INotifyPropertyChanged
    {

        private CourseService courseSvc;


        public CourseViewViewModel()
        {
            courseSvc = CourseService.Current;
        }
        public ObservableCollection<Course> Courses
        {
            get
            {
                return new ObservableCollection<Course>(courseSvc.courses);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Refresh()
        {
            NotifyPropertyChanged(nameof(Courses));
        }

        public Course SelectedCourse
        {
            get; set;
        }
        public void Remove()
        {
            courseSvc.Remove(SelectedCourse);
            Refresh();
        }
    }
}
