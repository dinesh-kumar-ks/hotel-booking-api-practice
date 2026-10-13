namespace HotelBooking.Api.Rooms
{
    public class StandardRoom: Room
    {
        private const double roomPrice = 250.0;
        public StandardRoom() : base(RoomType.StandardRoom)
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
