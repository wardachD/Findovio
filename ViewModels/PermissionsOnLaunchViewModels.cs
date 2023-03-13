using CommunityToolkit.Mvvm.ComponentModel;
using Findovio.Views;
using System.Collections.Specialized;
using System.Windows.Input;
using Findovio.Auth0;

namespace Findovio.ViewModels
{
    public class PermissionsOnLaunchViewModels : ObservableObject
    {
        private ICommand trygoToNextScreenCommand;
        private readonly INavigation navigation;

        public PermissionsOnLaunchViewModels(INavigation navigation)
        {
            this.navigation = navigation;
        }


        public ICommand tryGoToNextScreenCommand =>
            trygoToNextScreenCommand ??= new Command(TryOnGoToNextScreen);

        private async void TryOnGoToNextScreen()
        {
            // Set the new navigation stack as the root of the application
            Shell.Current.GoToAsync("///MainPage");
        }


        private bool _isLocationEnabled;
        private bool _isLocationAccessAllowed;

        private bool _isCameraEnabled;
        private bool _isCameraAccessAllowed;


        public bool IsLocationEnabled
        {
            get => _isLocationEnabled;
            set => SetProperty(ref _isLocationEnabled, value);
        }

        public bool IsLocationAccessAllowed
        {
            get => _isLocationAccessAllowed;
            set => SetProperty(ref _isLocationAccessAllowed, value);
        }

        public bool IsCameraEnabled
        {
            get => _isCameraEnabled;
            set => SetProperty(ref _isCameraEnabled, value);
        }

        public bool IsCameraAccessAllowed
        {
            get => _isCameraAccessAllowed;
            set => SetProperty(ref _isCameraAccessAllowed, value);
        }

        public ICommand ToggleLocationAccessCommand => new Command(() =>
        {
            IsLocationAccessAllowed = !IsLocationAccessAllowed;

            if (!IsLocationAccessAllowed)
            {
                IsLocationEnabled = false;
            }
            else if (IsLocationAccessAllowed)
            {
                // Je�li u�ytkownik wcze�niej udzieli� zgody na dost�p do lokalizacji i w��czy� Switch,
                // ustaw odpowiednie warto�ci.
                IsLocationEnabled = true;
            }
            else
            {
                // U�ytkownik w��czy� Switch, ale jeszcze nie udzieli� zgody na dost�p do lokalizacji.
                // Popro� o zgod� i ustaw odpowiednie warto�ci w przypadku uzyskania pozytywnej odpowiedzi.
                AskForLocationAccess();
            }
        });

        private async void AskForLocationAccess()
        {
            PermissionStatus result = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            if (result == PermissionStatus.Granted)
            {
                IsLocationAccessAllowed = true;
                IsLocationEnabled = true;
            }
            else
            {
                IsLocationAccessAllowed = false;
                IsLocationEnabled = false;
            }
        }

        public ICommand ToggleCameraAccessCommand => new Command(() =>
        {
            IsCameraAccessAllowed = !IsCameraAccessAllowed;

            if (!IsCameraAccessAllowed)
            {
                IsCameraEnabled = false;
            }
            else if (IsCameraAccessAllowed)
            {
                // Je�li u�ytkownik wcze�niej udzieli� zgody na dost�p do lokalizacji i w��czy� Switch,
                // ustaw odpowiednie warto�ci.
                IsCameraEnabled = true;
            }
            else
            {
                // U�ytkownik w��czy� Switch, ale jeszcze nie udzieli� zgody na dost�p do lokalizacji.
                // Popro� o zgod� i ustaw odpowiednie warto�ci w przypadku uzyskania pozytywnej odpowiedzi.
                AskForCameraAccess();
            }
        });

        private async void AskForCameraAccess()
        {
            PermissionStatus result = await Permissions.RequestAsync<Permissions.Camera>();

            if (result == PermissionStatus.Granted)
            {
                IsCameraAccessAllowed = true;
                IsCameraEnabled = true;
            }
            else
            {
                IsCameraAccessAllowed = false;
                IsCameraEnabled = false;
            }
        }


    }
}
