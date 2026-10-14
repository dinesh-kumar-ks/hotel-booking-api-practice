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
Room standardRoom = new StandardRoom(250);
Room suiteRoom = new SuiteRoom(400);
List<Room> rooms = new List<Room>();
rooms.Add(standardRoom);
rooms.Add(suiteRoom);



BookingRequest request = new BookingRequest(6, 2);

List<IBookingPolicy> policies = new List<IBookingPolicy>() { new MaxBookingPolicy(6), new MinimumStayPolicy(2) };


Hotel hotel = new Hotel("Hotel Das", rooms, policies);

Console.WriteLine("Name: " + hotel.HotelName);
foreach (var room in hotel.Rooms)
{
    Console.WriteLine($"Type: {room.RoomType}, Price: {room.CalculateRoomPrice()}");
}

foreach (IBookingPolicy policy in hotel.BookingPolicies)
{
    Console.WriteLine($"Policy: {policy.GetType().Name}, {policy.IsAllowed(request)}");
}
app.Run();