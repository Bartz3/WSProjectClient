using System.ServiceModel;
using System.Threading.Tasks;
using AirportServiceReference;
using UserReservationServiceReference;

namespace WSProjectClient.Controllers
{
    public class UserReservationController
    {
        private  UserReservationServiceClient _client;
        private readonly userTickets ticket;





        public UserReservationController()
        {
            _client = new UserReservationServiceClient();

        }


        //public async Task<airport[]> GetAiports()
        //{
        //var response = await _client.GetAirportsAsync();
        //return response.@return;
        //}

        public async void AddReservation(addUserReservationRequest _userReq)
        {
            await _client.AddUserReservationAsync(_userReq);

        }

        public async void GetUserReservations()
        {
            if (_client.State == CommunicationState.Faulted)
            {
                _client.Abort();
                _client = new UserReservationServiceClient();
            }
            await _client.GetUserReservationsAsync();


        }

        public async void GetReservationConfirmation(int confId)
        {
            await _client.GetReservationConfirmationAsync(confId);
        }

        public async void GetUserReservationByUserId(getUserReservationRequest userResReq)
        {
            await _client.GetUserReservationsByUserIdAsync(userResReq);
        }

        public async void GetUserReservationByFlightId(getUserReservationRequest userResReq)
        {
            await _client.GetUserReservationsByFlightIdAsync(userResReq);
            
        }

        



    }
}
