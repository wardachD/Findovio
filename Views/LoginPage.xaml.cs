using Findovio.ViewModels;

namespace Findovio;
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginPageViewModel();
    }


}