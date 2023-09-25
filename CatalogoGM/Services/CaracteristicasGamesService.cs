using CatalogoGM.Models;
using System.Text.Json;

namespace CatalogoGM.Services
{
    public class CaracteristicasGamesService : ICaracteristicasGameService
    {

        //Inyeccion de CaracteristicasGame HttpClient

        private readonly HttpClient _httpClient;
        public CaracteristicasGamesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<CaracteristicasGames>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"CaracteristicasGame");
            return JsonSerializer.Deserialize<IEnumerable<CaracteristicasGames>>(resp, options);
        }
    }
}
