namespace Findovio.ViewModels;

public class MessagesPageViewModels : ContentPage
{
    public MessagesPageViewModels()
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