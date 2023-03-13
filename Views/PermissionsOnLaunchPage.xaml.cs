using Findovio.ViewModels;

namespace Findovio.Views
{
    public partial class PermissionsOnLaunchPage : ContentPage
    {
        public PermissionsOnLaunchPage()
        {
            InitializeComponent();
            BindingContext = new PermissionsOnLaunchViewModels(Navigation);
        }
    }
}
