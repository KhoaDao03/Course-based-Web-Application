using App.Maui.ViewModels;

namespace App.Maui.Views;

public partial class InstructorFunctions : ContentPage
{
	public InstructorFunctions()
	{
		InitializeComponent();
        BindingContext = new StudentViewViewModel();

    }
    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructor");
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorViewViewModel).AddInstructor();
        Shell.Current.GoToAsync("//StudentDialog");

    }
    private void Remove_Clicked(object sender, EventArgs e)
    {
        (BindingContext as StudentViewViewModel)?.Remove();

    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as StudentViewViewModel)?.Refresh();
    }
}