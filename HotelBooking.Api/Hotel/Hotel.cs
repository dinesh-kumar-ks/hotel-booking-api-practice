using HotelBooking.Api.Rooms;
using HotelBooking.Api.Booking;

namespace HotelBooking.Api.Hotels
{
    public class Hotel
    {
        public readonly string HotelName;

        public Room room;

        public BookingPolicy bookingPolicy;
        public Hotel(string name)
        {
            HotelName = name;
        }
    }
}
