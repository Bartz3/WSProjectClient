using System.Threading.Tasks;
using AirportServiceReference;
using UserTicketServiceReference;

namespace WSProjectClient.Controllers
{
    public class UserTicketController
    {
        private readonly UserTicketServiceClient _client;



        public UserTicketController()
        {
            _client = new UserTicketServiceClient();
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
