namespace EbisApp;

using EbisApp.Page;
using EbisApp.Page.Authorized;


public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void moveToHome(object sender, EventArgs e) 
	{
		Navigation.PushAsync(new HomePage());
	}
}