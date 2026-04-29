using Upcasting_Downcasting_Enum__Exception.Models;
using Upcasting_Downcasting_Enum__Exception.Services;

public class Program
{
    static void Main(string[] args)
    {
        Room room1 = new Room("Deluxe", 150, 2);
        Room room2 = new Room("Suite", 300, 4);


        Hotel hotel = new Hotel("My Hotel");

        hotel.AddRoom(room1);
        hotel.AddRoom(room2);

        hotel.ShowAllRooms();

        HotelService service = new HotelService();

        service.ReserveRoom(hotel, 1);
        service.ReserveRoom(hotel, 1);
        service.ReserveRoom(hotel, null);

    }
}