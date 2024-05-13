using System.Threading.Tasks;
using AirportServiceReference;
using FlightServiceReference;
using UserTicketServiceReference;

namespace WSProjectClient.Controllers
{
    public class FlightController
    {
        private readonly FlightServiceClient _client;

       
        
        public FlightController()
        {
            _client = new FlightServiceClient();
        }



        public async Task<FlightServiceReference.flight[]> GetFlights()
        {
            var response = await _client.AllFlightsAsync();
            return response.@return;
        }

        public async void AddFlight(FlightServiceReference.addFlightRequest flight)
        {
            await _client.AddFlightAsync(flight);

          
        }



    }
}
