namespace WSProjectClient.Models
{
   
   public class UserTicketInfo
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int SeatNumber { get; set; }
        //public TravelClass TravelClass { get; set; }
        public string PassengerFirstName { get; set; } = string.Empty;
        public string PassengerLastName { get; set; } = string.Empty;
    }
}
