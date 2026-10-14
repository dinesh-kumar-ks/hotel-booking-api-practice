using HotelBooking.Api.Models;

namespace HotelBooking.Api.Bookings
{
    public interface IBookingPolicy
    {
        public bool IsAllowed(BookingRequest request);
    }
}
