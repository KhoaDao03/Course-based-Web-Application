namespace App.Maui.Views;

[QueryProperty(nameof(CourseName),"courseName")]
public partial class ModuleView : ContentPage
{
	public ModuleView()
	{
		InitializeComponent();
	}

	public string CourseName { get; set;}




}