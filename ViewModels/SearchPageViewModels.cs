using CommunityToolkit.Mvvm.Input;
using Findovio.Models;
using Findovio.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Findovio.ViewModels;

public partial class SearchPageViewModels : BaseViewModel
{
    public ObservableCollection<Salons> Salons { get; } = new();
    SearchService searchService;


    public SearchPageViewModels(SearchService searchService)
    {
        this.searchService = searchService;
    }

    [RelayCommand]
    async Task GetSalonsAsync(string query)
    {
      
        try
        {
            List<Salons> salons = await searchService.GetSalons(query);

            if (Salons.Count != 0)
                Salons.Clear();

            foreach (var salon in salons)
                Salons.Add(salon);

        }
        catch(Exception ex)
        {
            Debug.WriteLine($"B³¹d podczas pobierania salonów: {ex.Message}");
            await Shell.Current.DisplayAlert("B³¹d!", ex.Message, "OK");
        }
    }

}



