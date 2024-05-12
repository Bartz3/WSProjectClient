using System.Threading.Tasks;
using AirportServiceReference;

namespace WSProjectClient.Controllers
{
    public class AirportController
    {
        private readonly AirportServiceClient _client;



        public AirportController()
        {
            _client = new AirportServiceClient();
        }



        public async Task<airport[]> GetAiports()
        {
            var response = await _client.GetAirportsAsync();
            return response.@return;
        }

        public async void AddAirport(airport airport)
        {
            await _client.AddAirportAsync(airport);
        }



    }
}
