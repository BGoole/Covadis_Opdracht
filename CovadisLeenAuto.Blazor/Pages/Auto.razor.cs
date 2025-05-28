using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using CovadisLeenAuto.Shared.DTO.LeenAutos;

namespace CovadisLeenAuto.Blazor.Pages
{
    public partial class Auto : ComponentBase
    {

        [Inject]
        private HttpClient HttpClient { get; set; }

        //private IEnumerable<GeefAlleLeenAutos> autos = [];

        //protected override async Task OnInitializedAsync()
        //{
        //    autos = await HttpClient.GetFromJsonAsync<IEnumerable<GeefAlleLeenAutos>>("api/autos");
        //}

        //private void BoekAanmaken()
        //{
        //    NavigationManager.NavigateTo("boeken/aanmaken");
        //}

        //private void BoekBewerken(int id)
        //{
        //    NavigationManager.NavigateTo($"boeken/bewerken/{id}");
        //}
    }
}
