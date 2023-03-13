using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Findovio.Models;

namespace Findovio.Services
{
    public class SearchService
    {
        HttpClient httpClient;
        IGeolocation geolocation;
        public string Query { get; set; }
        public SearchService(IGeolocation geolocation)
        {
            this.httpClient = new HttpClient();
            this.geolocation = geolocation;
        }

        List<Salons> salonsList = new();
        public async Task<List<Salons>> GetSalons(string Query)
        {
            var location = await geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromMinutes(10)
                });
            }
            string SearchApiUrl = "http://46.41.150.66:8000/search/?query=";
            var response = await httpClient.GetAsync(SearchApiUrl + Query);

            if (response.IsSuccessStatusCode)
            {
                salonsList = await response.Content.ReadFromJsonAsync<List<Salons>>();
            }
            return salonsList;
        }
    }
}
