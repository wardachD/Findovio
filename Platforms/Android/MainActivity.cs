using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Findovio;

[Activity(Theme = "@style/Maui.SplashTheme", WindowSoftInputMode = Android.Views.SoftInput.StateAlwaysHidden|Android.Views.SoftInput.AdjustPan,MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}
