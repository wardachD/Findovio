namespace Findovio.ViewModels;

public class FavoritePageViewModels : ContentPage
{
    public FavoritePageViewModels()
    {
        Content = new VerticalStackLayout
        {
            Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
                }
            }
        };
    }
}