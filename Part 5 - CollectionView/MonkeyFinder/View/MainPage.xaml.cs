namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeysViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
        CheckUser();
    }

    private async void CheckUser()
    {
        bool hasKey = Preferences.Default.ContainsKey("Username");
        if (hasKey)
        {
            string Username = Preferences.Default.Get("Username", "Unknown");
            string Password = Preferences.Default.Get("Password", "Unknown");
            await Shell.Current.GoToAsync($"DashboardPage?Username={Username}&Password={Password}");
        }
    }

    private void onExitClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    private async void onLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage), true);
    }
}