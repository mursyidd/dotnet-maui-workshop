namespace MonkeyFinder;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private void onExitClicked(object sender, EventArgs e)
    {
		Application.Current.Quit();
    }
}