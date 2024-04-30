using App.Maui.ViewModels;
namespace App.Maui.Views;

public partial class InstructorView : ContentPage
{
	public InstructorView()
	{
		InitializeComponent();
        BindingContext = new InstructorViewViewModel();
	}
    private void Home_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void Add_Clicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorViewViewModel).AddInstructor();
        Shell.Current.GoToAsync($"//InstructorDialog?cientId=0");

    }
    private void Remove_Clicked(object sender, EventArgs e)
    {
        (BindingContext as InstructorViewViewModel)?.Remove();

    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as InstructorViewViewModel)?.Refresh();
    }


    private void Students_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//InstructorFunctions");
    }

    private void Courses_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Course");
    }
    private void Update_Clicked(object sender, EventArgs e)
    {
        //(BindingContext as InstructorViewViewModel).AddInstructor();
        var instructorId = (BindingContext as InstructorViewViewModel)?.SelectedInstructor?.Id;
        if (instructorId != null)
        {
            Shell.Current.GoToAsync($"//InstructorDialog?instructorId={instructorId}");

        }


    }
}