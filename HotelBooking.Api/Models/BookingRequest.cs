namespace HotelBooking.Api.Models
{
    public class BookingRequest
    {
        public int Guests { get; set; }
        public int Nights { get; set; }
        public BookingRequest(int guests, int nights)
        {
            Guests = guests;
            Nights = nights;
        }
    }
}
