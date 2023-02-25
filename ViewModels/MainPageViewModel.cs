using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Findovio.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private ICommand goToNextScreenCommand;

        public ICommand GoToNextScreenCommand =>
            goToNextScreenCommand ??= new Command(OnGoToNextScreen);

        private async void OnGoToNextScreen()
        {
            await Shell.Current.GoToAsync("NextScreen");
        }
    }
}
