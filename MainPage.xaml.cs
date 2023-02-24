using Microsoft.Maui.Controls;
using Findovio.ViewModels;

namespace Findovio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}
