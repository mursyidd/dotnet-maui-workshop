using CommunityToolkit.Maui.Alerts;

namespace MonkeyFinder;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void onLoginClicked(object sender, EventArgs e)
    {
        string username = UserEnt.Text;
        string password = PassEnt.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            Toast.Make("Username and Password Cannot Be Empty!", CommunityToolkit.Maui.Core.ToastDuration.Short, 18).Show();
        }
        else
        {
            if (username.ToUpper() == "ADMIN" && password == "1234")
            {
                await Shell.Current.GoToAsync(nameof(DashboardPage), true);
            }
            else
            {
                Toast.Make("Please Check Your Username and Password!", CommunityToolkit.Maui.Core.ToastDuration.Short, 18).Show();
            }
        }
    }

    private async void onRegClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage), true);

    }
}