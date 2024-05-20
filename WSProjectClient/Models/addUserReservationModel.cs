namespace WSProjectClient.Models
{
    public class addUserReservationModel
    {
        
        public UserReservationServiceReference.userTickets ticket { get; set; } = new UserReservationServiceReference.userTickets();
        public int flightId { get; set; }
    }
}
