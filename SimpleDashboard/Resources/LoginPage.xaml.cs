namespace SimpleDashboard.Resources;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void login_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(username.Text))
        {
            unameBorder.BorderColor = Colors.Red;
            return;
        }
        if (string.IsNullOrEmpty(password.Text))
        {
            passBorder.BorderColor = Colors.Red;
            return;
        }

        App.Current.MainPage = new MainPage();
    }

    private void password_Unfocused(object sender, FocusEventArgs e)
    {
        if (string.IsNullOrEmpty(username.Text))
        {
            passBorder.BorderColor = Colors.Red;
        }
        else
        {
            passBorder.BorderColor = Colors.Transparent;
            passCheck.IsVisible = true;
        }
    }

    private void username_Unfocused(object sender, FocusEventArgs e)
    {
        if (string.IsNullOrEmpty(username.Text))
        {
            unameBorder.BorderColor = Colors.Red;
        }
        else
        {
            unameBorder.BorderColor = Colors.Transparent;
            unameCheck.IsVisible = true;
        }
    }
}