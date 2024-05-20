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


        public async Task<userTickets[]> GetTickets()
        {
            var response = await _client.GetTicketsAsync();
            return response.@return;
        }



  



    }
}
