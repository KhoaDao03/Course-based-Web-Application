using App.Maui.ViewModels;

namespace App.Maui.Dialogs;

public partial class StudentDialog : ContentPage
{
	public StudentDialog()
	{
		InitializeComponent();
        BindingContext = new StudentDialogViewModel();

    }

    private void Submit_Clicked(object sender, EventArgs e)
    {

        (BindingContext as StudentDialogViewModel)?.AddStudent();

        Shell.Current.GoToAsync("//InstructorFunctions");

    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//InstructorFunctions");

    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new StudentDialogViewModel();

    }

}