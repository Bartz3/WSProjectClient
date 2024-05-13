using System.Threading.Tasks;
using AirportServiceReference;
using PlaneServiceReference;

namespace WSProjectClient.Controllers
{
    public class PlaneController
    {
        private readonly PlaneServiceClient _client;



        public PlaneController()
        {
            _client = new PlaneServiceClient();
        }



        public async Task<plane[]> GetPlanes()
        {
            var response = await _client.GetPlanesAsync();
            return response.@return;
        }

        public async void AddPlane(plane plane)
        {
            await _client.AddPlaneAsync(plane);
        }



    }
}
