
using App.Maui.ViewModels;
using Library.LearningManagement.Models;
using Library.LearningManagement.Services;

namespace App.Maui.Dialogs;

public partial class InstructorDialog : ContentPage
{
	public InstructorDialog()
	{
		InitializeComponent();
        BindingContext = new InstructorDialogViewModel();

    }

    private void Submit_Clicked(object sender, EventArgs e)
    {
 
        (BindingContext as InstructorDialogViewModel)?.AddInstructor();
        
        Shell.Current.GoToAsync("//Instructor");

    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Instructor");

    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new InstructorDialogViewModel();

    }


}