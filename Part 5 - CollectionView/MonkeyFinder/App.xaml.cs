namespace MonkeyFinder;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //string mainDir = FileSystem.Current.AppDataDirectory;
        MainPage = new AppShell();
	}
}
