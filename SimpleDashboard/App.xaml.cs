using SimpleDashboard.Resources;

namespace SimpleDashboard;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
