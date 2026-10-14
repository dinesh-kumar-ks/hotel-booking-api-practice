using HotelBooking.Api.Rooms;
using HotelBooking.Api.Bookings;

namespace HotelBooking.Api.Hotels
{
    public class Hotel
    {
        public readonly string HotelName;

        public IReadOnlyList<Room> rooms;

        public IReadOnlyList<IBookingPolicy> bookingPolicies;
        public Hotel(string name)
        {
            HotelName = name;
        }
    }
}
