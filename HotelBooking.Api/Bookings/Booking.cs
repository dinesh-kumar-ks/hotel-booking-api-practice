using HotelBooking.Api.Hotels;
using HotelBooking.Api.Models;
using HotelBooking.Api.Rooms;
namespace HotelBooking.Api.Bookings;

public class Booking
{
    private bool _pricePaid { get; set; }
    private Hotel  _hotel;
    public Booking(Hotel hotel, bool pricePaid)
    {
        _hotel = hotel; 
        _pricePaid = pricePaid;
    }


    public BookingResponse CheckBooking(BookingRequest request)
    {
        BookingResponse response = new BookingResponse();

        if(!_pricePaid)
        {
            response.IsBooked = false;
            response.ErrorMessage = "Payment UnSuccessful";
            return response;
        }

        foreach(IBookingPolicy policy in _hotel.bookingPolicies)
        {
            if(!policy.IsAllowed(request))
            {
                response.IsBooked = false;
                response.ErrorMessage = "Booking Policy Failed";
                return response;
            }
        }


        foreach (Room room in _hotel.rooms)
        {
            if(!room.CheckRoomAvailablity())
            {
                response.IsBooked = false;
                response.ErrorMessage = "Requested Room isn't available";
                return response;
            }
        }

        response.IsBooked = true;
        return response;
    }
}
