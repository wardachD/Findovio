using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace Findovio.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        public ICommand ButtonClickedCommand { get; }

        public MainPageViewModel()
        {
            ButtonClickedCommand = new Command(() =>
            {
                // Tutaj możesz dodać kod wykonywany po kliknięciu przycisku
            });
        }
    }
}
