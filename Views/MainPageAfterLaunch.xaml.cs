using Findovio.Auth0;
using Findovio.ViewModels;
using System.ComponentModel;

namespace Findovio.Views;

public partial class MainPageAfterLaunch : INotifyPropertyChanged
{

    Auth0Client auth0Client = new Auth0Client(new Auth0ClientOptions
    {
        Domain = "findovio-client.eu.auth0.com",
        ClientId = "n137DGVJtSiOEw5fKnoeHh4BX9Ati2VW",
        Scope = "openid",
        RedirectUri = "myapp://callback"
    });

    public MainPageAfterLaunch()
    {
        InitializeComponent();
        BindingContext = new MainPageAfterLaunchViewModel();

    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var loginResult = await auth0Client.LoginAsync();
        if (!loginResult.IsError)
        {
            // LoginView.IsVisible = false;
            // HomeView.IsVisible = true;
        }
        else
        {
            await DisplayAlert("B³¹d", loginResult.ErrorDescription, "OK");
        }
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        var logoutResult = await auth0Client.LogoutAsync();

        if (!logoutResult.IsError)
        {
            // HomeView.IsVisible = false;
            // LoginView.IsVisible = true;
        }
        else
        {
            await DisplayAlert("B³¹d", logoutResult.ErrorDescription, "OK");
        }
    }
}