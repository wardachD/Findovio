#if ANDROID
using CommunityToolkit.Maui;
#endif
using Findovio.Services;
using Findovio.ViewModels;
using Findovio.Views;

namespace Findovio;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
#if ANDROID
			.UseMauiCommunityToolkit()
#endif
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<PermissionsOnLaunchPage>();
        builder.Services.AddSingleton<PermissionsOnLaunchViewModels>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<SearchService>();

        builder.Services.AddSingleton<MainPageAfterLaunch>();
        builder.Services.AddSingleton<MainPageAfterLaunchViewModel>();

        return builder.Build();
    }
}
