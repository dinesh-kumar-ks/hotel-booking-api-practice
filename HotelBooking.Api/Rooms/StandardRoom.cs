namespace HotelBooking.Api.Rooms
{
    public class StandardRoom: Room
    {
        private readonly decimal _roomPrice;
        public StandardRoom(decimal price) : base(RoomType.StandardRoom)
        {
            _roomPrice = price;
        }

        public override decimal CalculateRoomPrice()
        {
            return _roomPrice;
        }

        public override bool CheckRoomAvailablity()
        {
            return true;
        }
    }
}
