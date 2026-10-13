namespace HotelBooking.Api.Booking
{
    public class BookingPolicy: IBookingPolicy
    {
        public bool VerifyBookingPolicy()
        {
            return true;
        }
    }
}
