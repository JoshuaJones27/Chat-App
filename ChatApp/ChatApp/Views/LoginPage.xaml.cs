namespace ChatApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        Application.Current.Quit();
        return true;
    }

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        string username = Username.Text;
        string password = Password.Text;

        if (string.IsNullOrWhiteSpace(username))
        {
            DisplayAlert("Error", "Please enter a username", "OK");
            return;
        }

        if(string.IsNullOrWhiteSpace(password))
        {            
            DisplayAlert("Error", "Please enter a password", "OK");
            return;
        }
    }

    //bool IsCredentialCorrect(string username, string password)
    //{
    //    return Username.Text == "admin" && Password.Text == "1234";
    //}
}