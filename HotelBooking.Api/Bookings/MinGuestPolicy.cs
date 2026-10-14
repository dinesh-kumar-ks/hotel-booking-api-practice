using HotelBooking.Api.Models;

namespace HotelBooking.Api.Bookings
{
    public class MinGuestPolicy: IBookingPolicy
    {
        private readonly int minGuests;
        public MinGuestPolicy(int guests)
        {
            minGuests = guests;
        }

        public bool IsAllowed(BookingRequest request)
        {
            return request.Guests > minGuests;
        }
    }
}
