using CommunityToolkit.Maui.Alerts;

namespace MonkeyFinder;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void onLoginClicked(object sender, EventArgs e)
    {
        string username = UserEnt.Text;
        string password = PassEnt.Text;

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
        {
#if ANDROID
            Toast.Make("Please Check Your Username and Password!", CommunityToolkit.Maui.Core.ToastDuration.Long, 18).Show();
#endif
#if WINDOWS
            Snackbar.Make("Please Check Your Username and Password!", null, "YES!", TimeSpan.FromSeconds(3)).Show();
#endif
        }
        else
        {

        }
    }

    private void onClearClicked(object sender, EventArgs e)
    {
        UserEnt.Text= string.Empty;
        PassEnt.Text = string.Empty;
    }
}