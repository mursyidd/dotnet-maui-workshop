namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeysViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
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