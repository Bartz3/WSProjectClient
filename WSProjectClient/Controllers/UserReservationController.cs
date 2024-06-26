using System.ServiceModel;
using System.Threading.Tasks;
using UserReservationServiceReference;

namespace WSProjectClient.Controllers
{
    public class UserReservationController
    {
        private  UserReservationServiceClient _client;
        private UserReservationService urs;
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

        public async Task<byte[]> GetReservationConfirmation(GetReservationConfirmationRequest request)
        {
            //urs = new UserReservationService();
            var result = await urs.GetReservationConfirmationAsync(request);

            return result.confirmationResponse;
        }
        public async Task<byte[]> Test(int id)
        {
            var result = _client.GetReservationConfirmationAsync(id);
            return result.Result.confirmationResponse;
        }
        //public async void test(GetReservationConfirmationRequest request)
        //{
        //    await _client.

        //}

        //public async Task<byte[]> GetReservationConfirmation(GetReservationConfirmationRequest request)
        //{
        //    try
        //    {
        //        var client = new UserReservationClient();
        //        var result = await client.GetReservationConfirmationAsync(request);

        //        return result.confirmationResponse;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

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
