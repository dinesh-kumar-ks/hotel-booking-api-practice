using HotelBooking.Api.Models;

namespace HotelBooking.Api.Bookings
{
    public class MinimumStayPolicy: IBookingPolicy
    {
        private readonly int minNights;
        public MinimumStayPolicy(int nights)
        {
            minNights = nights;
        }

        public bool IsAllowed(BookingRequest request)
        {
            return request.Nights >= minNights;
        }
    }
}
