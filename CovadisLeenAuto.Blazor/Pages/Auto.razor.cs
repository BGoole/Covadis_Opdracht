using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using CovadisLeenAuto.Shared.DTO.LeenAutos;
using CovadisLeenAuto.Shared.DTO.Werknemers;
using CovadisLeenAuto.Shared.DTO.Ritten;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CovadisLeenAuto.Blazor.Pages
{
    public partial class Auto : ComponentBase
    {

        [Inject]
        private HttpClient HttpClient { get; set; }

        private StoreRitten rit = new StoreRitten();
        private UpdateLeenAuto auto;

        private IEnumerable<GeefAlleLeenAutos> autos = [];
        private IEnumerable<GeefWerknemers> werknemers = [];

        protected override async Task OnInitializedAsync()
        {
            autos = await HttpClient.GetFromJsonAsync<IEnumerable<GeefAlleLeenAutos>>("api/LeenAuto");
            werknemers = await HttpClient.GetFromJsonAsync<IEnumerable<GeefWerknemers>>("api/Werknemer");
        }
        private async Task Submit()
        {
            var result = await HttpClient.GetFromJsonAsync<IEnumerable<StoreRitten>>("api/Rit",rit);
            auto = await HttpClient.GetFromJsonAsync<IEnumerable<GeefLeenAuto>>($"api/LeenAuto/{rit.leenautoID}");
            if (result.IsSuccessStatusCode)
            {
                // Succesmelding tonen
                auto = new UpdateLeenAuto
                {
                    Gereserveerd = true,
                    GereserveerdVan = result.BeginDatum,
                    GereserveerdTot = result.EindDatum,
                };
            }
            else
            {
                // Foutmelding tonen
            }
        }

        private int checkDatum(DateTime datum1, DateTime datum2)
        {
            string relationship;
            int result = DateTime.Compare(datum1, datum2);
            if (result < 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is the same time as";
            else
                relationship = "is later than";
            return result;
        }
    }
}
