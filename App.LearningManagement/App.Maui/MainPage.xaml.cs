namespace App.Maui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Student_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Student");
        }

        private void Instructor_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Instructor");
        }
    }

}
