namespace HotelBooking.Api.Rooms
{
    public abstract class Room
    {
        public RoomType RoomType { get; set; }

        protected Room(RoomType type)
        {
            RoomType = type;
        }

        public abstract decimal CalculateRoomPrice();
        public abstract bool CheckRoomAvailablity();
    }
}
