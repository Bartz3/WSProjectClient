using WSProjectClient.Data;

namespace WSProjectClient.Models
{
   
        public class UserReservationInfo
        {
            public int Id { get; set; }
            public UserInfo User { get; set; } = default!;
            //public FlightInfo Flight { get; set; } = default!;
            public List<UserTicketInfo> Tickets = [];
        }
    
}
