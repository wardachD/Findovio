using Findovio.Services;
using Findovio.ViewModels;
using Microsoft.Maui.Controls;

namespace Findovio.Views;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
    protected override void OnDisappearing()
    {
        LabelNotFocused.FadeTo(1, 0, Easing.Linear);
        LabelText1NotFocused.FadeTo(1, 0, Easing.Linear);
        LabelText2NotFocused.FadeTo(1, 0, Easing.Linear);
        GridNotFocused.FadeTo(1, 0, Easing.Linear);
        LabelFocused.TranslateTo(0, 0, 0);
        LabelFocused.FadeTo(1, 0, Easing.Linear);
        base.OnDisappearing();
    }

    private async void Animation_SearchBarClicked(object sender, EventArgs eventArgs)
    {
        LabelNotFocused.FadeTo(0, 200, Easing.Linear);
        LabelText1NotFocused.FadeTo(0, 200, Easing.Linear);
        LabelText2NotFocused.FadeTo(0, 200, Easing.Linear);
        GridNotFocused.FadeTo(0, 200, Easing.Linear);
        LabelFocused.TranslateTo(0, -500, 400);
        LabelFocused.FadeTo(0, 300, Easing.Linear);
        await Shell.Current.GoToAsync("SearchPage");
    }

}


