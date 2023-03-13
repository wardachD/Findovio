namespace Findovio.ViewModels;

public class ReservationPageViewModels : ContentPage
{
    public ReservationPageViewModels()
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