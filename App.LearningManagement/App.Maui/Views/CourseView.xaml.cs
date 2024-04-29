using App.Maui.ViewModels;

namespace App.Maui.Views;

public partial class CourseView : ContentPage
{
    public CourseView()
    {
        InitializeComponent();
        BindingContext = new CourseViewViewModel();

    }
    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructor");
    }

    private void Remove_Clicked(object sender, EventArgs e)
    {
        (BindingContext as CourseViewViewModel)?.Remove();

    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorViewViewModel).AddInstructor();
        Shell.Current.GoToAsync("//CourseDialog");

    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as CourseViewViewModel)?.Refresh();
    }
}