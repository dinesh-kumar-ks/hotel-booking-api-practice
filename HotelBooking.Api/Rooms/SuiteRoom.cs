namespace HotelBooking.Api.Rooms
{
    public class SuiteRoom: Room 
    {
        private const double roomPrice = 400.0;
        public SuiteRoom(): base(RoomType.SuiteRoom)
        {
            
        }

        public override double calculateRoomPrice()
        {
            return roomPrice;
        }

        public override bool checkRoomAvailablity()
        {
            return true;
        }
    }
}
