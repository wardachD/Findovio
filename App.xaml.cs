using Findovio.Views;
using Findovio.Auth0;

namespace Findovio
{
    public partial class App : Application
    {
        const string isFirstLaunchKey = "IsFirstLaunch";

        public App()
        {
            InitializeComponent();
            // Not the first launch, show the AppShell
            MainPage = new AppShell();
        }
        
    }
}