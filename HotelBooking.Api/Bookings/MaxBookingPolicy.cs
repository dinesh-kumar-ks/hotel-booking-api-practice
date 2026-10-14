using HotelBooking.Api.Models;

namespace HotelBooking.Api.Bookings
{
    public class MaxBookingPolicy: IBookingPolicy
    {
        private readonly int _maxGuestCount;
        public MaxBookingPolicy(int maxGuest)
        {
            _maxGuestCount = maxGuest;
        }

        public bool IsAllowed(BookingRequest request)
        {
            return request.Guests <= _maxGuestCount;
        }
    }
}
