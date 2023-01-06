using MonkeyFinder.View;

namespace MonkeyFinder;

[QueryProperty(nameof(Name), "Username")]
public partial class DashboardPage : ContentPage
{
    string name;
    public string Name
    {
        get => name;
        set
        {
            name = value;
            label1.Text = "Welcome " + name.ToUpper() + "!";
        }
    }

    public DashboardPage()
	{
		InitializeComponent();
    }

    private async void onExitClicked(object sender, EventArgs e)
    {
		Application.Current.Quit();

        //await Launcher.Default.OpenAsync("https://www.google.com/");
    }

    private async void onLogoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"///MainPage");
    }
}