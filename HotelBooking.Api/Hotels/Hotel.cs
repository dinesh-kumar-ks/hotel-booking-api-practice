using HotelBooking.Api.Rooms;
using HotelBooking.Api.Bookings;

namespace HotelBooking.Api.Hotels
{
    public class Hotel
    {
        public readonly string HotelName;

        public IReadOnlyList<Room> Rooms;

        public IReadOnlyList<IBookingPolicy> BookingPolicies;
        public Hotel(string name, IReadOnlyList<Room> rooms, IReadOnlyList<IBookingPolicy> bookingPolicies)
        {
            HotelName = name;
            Rooms = rooms;
            BookingPolicies = bookingPolicies;
        }
    }
}
