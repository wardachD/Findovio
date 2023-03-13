using static Findovio.Models.Salons;
using Newtonsoft.Json;
using Findovio.Models;
using Findovio.ViewModels;
using Findovio.Services;

namespace Findovio.Views
{
    public partial class SearchPage : ContentPage
    {
        SearchService searchService;
        IGeolocation geolocation;
        public SearchPage()
        {
            InitializeComponent();
            searchService = new SearchService(geolocation);
            BindingContext = new SearchPageViewModels(searchService);
        }

    }
}