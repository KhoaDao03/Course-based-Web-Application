using App.Maui.ViewModels;

namespace App.Maui.Dialogs;

public partial class CourseDialog : ContentPage
{
	public CourseDialog()
	{
		InitializeComponent();
        BindingContext = new CourseDialogViewModel();

    }

    private void Submit_Clicked(object sender, EventArgs e)
    {

        (BindingContext as CourseDialogViewModel)?.AddCourse();

        Shell.Current.GoToAsync("//Course");

    }

    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Course");

    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new CourseDialogViewModel();

    }
}