using System.Threading.Tasks;
using AirportServiceReference;
using UserReservationServiceReference;

namespace WSProjectClient.Controllers
{
    public class UserReservationController
    {
        private readonly UserReservationServiceClient _client;



        public UserReservationController()
        {
            _client = new UserReservationServiceClient();
        }



        //public async Task<airport[]> GetAiports()
        //{
        //    var response = await _client.GetAirportsAsync();
        //    return response.@return;
        //}

        //public async void AddAirport(airport airport)
        //{
        //    await _client.AddAirportAsync(airport);
        //}



    }
}
