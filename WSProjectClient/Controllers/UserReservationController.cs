using System.ServiceModel;
using System.Threading.Tasks;
using UserReservationServiceReference;

namespace WSProjectClient.Controllers
{
    public class UserReservationController
    {
        private  UserReservationServiceClient _client;
        private userTickets ticket;

        public UserReservationController()
        {
            _client = new UserReservationServiceClient();

        }


        public async void AddReservation(addUserReservationRequest _userReq)
        {
        

            await _client.AddUserReservationAsync(_userReq);

        }

        public async void GetUserReservations()
        {
            //if (_client.State == CommunicationState.Faulted)
            //{
            //    _client.Abort();
            //    _client = new UserReservationServiceClient();
            //}
            //    _client.Open(); // Open the new channel
            await _client.GetUserReservationsAsync();


        }

        public async void GetReservationConfirmation(int confId)
        {
            await _client.GetReservationConfirmationAsync(confId);
        }

        public async Task<GetUserReservationsByUserIdResponse> GetUserReservationByUserId(GetUserReservationsByUserIdRequest userResReq)
        {
            //userResReq.userId = 5;
            //userResReq.flightId = 
            var getUserResreq = new getUserReservationRequest();
            getUserResreq=userResReq.getUserReservationRequest;
            var output =await _client.GetUserReservationsByUserIdAsync(getUserResreq);

            return output;
        }

        public async void GetUserReservationByFlightId(getUserReservationRequest userResReq)
        {
            await _client.GetUserReservationsByFlightIdAsync(userResReq);
            
        }

        



    }
}
