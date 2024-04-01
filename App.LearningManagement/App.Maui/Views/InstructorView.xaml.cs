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
        (BindingContext as InstructorViewViewModel).AddInstructor();
    }
    private void Remove_Clicked(object sender, EventArgs e)
    {

    }
}