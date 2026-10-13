namespace HotelBooking.Api.Rooms
{
    public abstract class Room
    {
        public RoomType RoomType { get; set; }

        protected Room(RoomType type)
        {
            RoomType = type;
        }

        public abstract double calculateRoomPrice();
        public abstract bool checkRoomAvailablity();
    }
}
