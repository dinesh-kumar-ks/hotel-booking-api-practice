namespace HotelBooking.Api.Rooms
{
    public class SuiteRoom: Room 
    {
        private readonly decimal _roomPrice;
        public SuiteRoom(decimal price): base(RoomType.SuiteRoom)
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
