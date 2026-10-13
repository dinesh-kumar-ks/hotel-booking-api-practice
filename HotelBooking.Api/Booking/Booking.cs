using HotelBooking.Api.Hotels;
using HotelBooking.Api.Models;
namespace HotelBooking.Api.Booking
{
    public class Booking
    {
        private bool PricePaid { get; set; }
        private Hotel  _hotel;
        public Booking(Hotel hotel)
        {
            _hotel = hotel;   
        }


        public BookingResponse checkBooking()
        {
            BookingResponse response = new BookingResponse();

            if(PricePaid)
            {
                response.IsBooked = false;
                response.ErrorMessage = "Payment UnSuccessful";
                return response;
            }

            if (_hotel.bookingPolicy.VerifyBookingPolicy())
            {
                response.IsBooked = false;
                response.ErrorMessage = "Booking Policy Failed";
                return response;
            }

            if (_hotel.room.checkRoomAvailablity())
            {
                response.IsBooked = false;
                response.ErrorMessage = "requested Room isn't available";
                return response;
            }

            response.IsBooked = true;
            return response;
        }
    }
}
