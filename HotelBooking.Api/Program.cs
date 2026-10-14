using HotelBooking.Api.Bookings;
using HotelBooking.Api.Hotels;
using HotelBooking.Api.Models;
using HotelBooking.Api.Rooms;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



//temp: prove polymorphism
Hotel hotel = new Hotel("Hotel Das");
Room standardRoom = new StandardRoom(250);
Room suiteRoom = new SuiteRoom(400);
List<Room> rooms = new List<Room>();
rooms.Add(standardRoom);
rooms.Add(suiteRoom);
hotel.rooms = rooms;

Console.WriteLine("Name: " + hotel.HotelName);
foreach(var room in hotel.rooms)
{
    Console.WriteLine($"Type: {room.RoomType}, Price: {room.CalculateRoomPrice()}");
}

BookingRequest request = new BookingRequest(6, 2);

List<IBookingPolicy> policies = new List<IBookingPolicy>() { new MaxBookingPolicy(2), new MinGuestPolicy(2) };
hotel.bookingPolicies = policies;

foreach(IBookingPolicy policy in policies)
{
    Console.WriteLine($"Policy: {policy.GetType().Name}, {policy.IsAllowed(request)}");
}
app.Run();