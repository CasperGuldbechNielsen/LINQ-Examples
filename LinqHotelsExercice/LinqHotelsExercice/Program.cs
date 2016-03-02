using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqHotelsExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotels = new Hotel[]
            {
                new Hotel() {HotelNo = 1, Name = "The Pope", Address = "Vaticanstreet 1  1111 Bishopcity"},
                new Hotel() {HotelNo = 2, Name = "Lucky Star", Address = "Lucky Road 12  2222 Hometown"},
                new Hotel() {HotelNo = 3, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 4, Name = "deLuxeCapital", Address = "Luxury Road 99  4444 Luxus"},
                new Hotel() {HotelNo = 5, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 6, Name = "Prindsen", Address = "Algade 5, 4000 Roskilde"},
                new Hotel() {HotelNo = 7, Name = "Scandic", Address = "Algade 5, 4000 Roskilde"},
            };

            var rooms = new Room[]
            {
                new Room() {RoomNo = 1, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 1, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 2, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 3, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 4, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 11, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 12, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 21, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 1, Hotel=hotels[2], Types = 'D', Price = 175},
                new Room() {RoomNo = 2, Hotel=hotels[2], Types = 'D', Price = 180},
                new Room() {RoomNo = 11, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 21, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 31, Hotel=hotels[2], Types = 'F', Price = 200},
                new Room() {RoomNo = 32, Hotel=hotels[2], Types = 'F', Price = 230},
                new Room() {RoomNo = 1, Hotel=hotels[3], Types = 'D', Price = 500},
                new Room() {RoomNo = 2, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 3, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 11, Hotel=hotels[3], Types = 'S', Price = 350},
                new Room() {RoomNo = 12, Hotel=hotels[3], Types = 'S', Price = 360},
                new Room() {RoomNo = 1, Hotel=hotels[4], Types = 'D', Price = 250},
                new Room() {RoomNo = 2, Hotel=hotels[4], Types = 'D', Price = 170},
                new Room() {RoomNo = 11, Hotel=hotels[4], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[4], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[4], Types = 'F', Price = 310},
                new Room() {RoomNo = 23, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 24, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 1, Hotel=hotels[5], Types = 'D', Price = 290},
                new Room() {RoomNo = 11, Hotel=hotels[5], Types = 'S', Price = 185},
                new Room() {RoomNo = 21, Hotel=hotels[5], Types = 'F', Price = 360},
                new Room() {RoomNo = 22, Hotel=hotels[5], Types = 'F', Price = 370},
                new Room() {RoomNo = 23, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 24, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 1, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 14, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 24, Hotel=hotels[6], Types = 'F', Price = 220}
            };

            //Exercise, use LINQ to retrive the following information about Hotels and Rooms:

            // 1) List full details of all Hotels:
            Console.WriteLine("All hotels:");
            var allHotels =
                from hotel in hotels
                select hotel;

            foreach (var hotel in allHotels)
            {
                Console.WriteLine(hotel.ToString());
            }
            
            // 2) List full details of all hotels in Roskilde:
            Console.WriteLine("\nHotels in Roskilde:");
            var hotelsInRoskilde =
                from hotel in hotels
                where hotel.Address.Contains("Roskilde")
                select hotel;

            foreach (var hotel in hotelsInRoskilde)
            {
                Console.WriteLine(hotel.ToString());
            }
               
            // 3) List the names of all hotels in Roskilde:
            Console.WriteLine("\nNames of the hotels in Roskilde:");

            foreach (var hotel in hotelsInRoskilde)
            {
                Console.WriteLine(hotel.Name);
            }

            // 4) List all double rooms with a price below 400 pr night:
            Console.WriteLine("\nAll double rooms with price below 400:");

            var doubleRooms =
                from room in rooms
                where room.Types == 'D' && room.Price < 400
                select room;

            foreach (var doubleRoom in doubleRooms)
            {
                Console.WriteLine(doubleRoom.ToString());
            }
            
            // 5) List all double or family rooms with a price below 400 pr night in ascending order of price:
            Console.WriteLine("\nList of all double or family rooms with price below 400 in ascending order:");

            var doubleAndFamilyRooms =
                from room in rooms
                where room.Types == 'D' || room.Types == 'F' && room.Price < 400
                orderby room.Price ascending
                select room;

            foreach (var doubleAndFamilyRoom in doubleAndFamilyRooms)
            {
                Console.WriteLine(doubleAndFamilyRoom.ToString());
            }

            // 6) List all hotels that starts with 'P':
            Console.WriteLine("\nListing all the hotels that starts with a P:");

            var hotelsWithP =
                from hotel in hotels
                // where hotel.Name[0] == "P"
                where hotel.Name.StartsWith("P")
                select hotel;

            foreach (var hotel in hotelsWithP)
            {
                Console.WriteLine(hotel.ToString());
            }
            
            // 7) List the number of hotels:
            Console.WriteLine("\nListing the number of hotels:");

            int numOfHotels = allHotels.Count();

            Console.WriteLine("Number of hotels: {0}", numOfHotels);

            // 8) List the number of hotels in Roskilde:
            Console.WriteLine("\nListing the number of hotels in Roskilde:");

            int numOfHotelsInRoskilde = hotelsInRoskilde.Count();

            Console.WriteLine("Number of hotels in Roskilde: {0}", numOfHotelsInRoskilde);

            // 9) what is the avarage price of a room:
            Console.WriteLine("\nListing the average price of rooms:");

            var allRooms =
                from room in rooms
                select room.Price;

            double averagePrice = allRooms.Average();

            Console.WriteLine(averagePrice);

            //10) what is the avarage price of a room at Hotel Scandic:
            Console.WriteLine("\nListing the average price of a room in Hotel Scandic:");

            var allScandicRooms =
                from room in rooms
                where room.Hotel.Name == "Scandic"
                select room.Price;

            double averageRoomPrice = allScandicRooms.Average();

            Console.WriteLine(averageRoomPrice);

            //11) what is the total reveneue per night from all double rooms:
            Console.WriteLine("\nListing the revenue pr night from all double rooms:");

            var doubleRoomRevenue =
                from room in rooms
                where room.Types == 'D'
                select room.Price;

            double revenue = 0;

            foreach (var i in doubleRoomRevenue)
            {
                revenue += i;
            }

            Console.WriteLine("Revenue is: {0}", revenue);

            //12) List price and type of all rooms at Hotel Prindsen:
            Console.WriteLine("\nListing price and type of the rooms at Hotel Prindsen:");

            var prindsenRooms =
                from room in rooms
                where room.Hotel.Name == "Prindsen"
                select room;

            foreach (var prindsenRoom in prindsenRooms)
            {
                Console.WriteLine("Price: {0} -> Type: {1}", prindsenRoom.Price, prindsenRoom.Types);
            }

            //13) List distinct price and type of all rooms at Hotel Prindsen:
            Console.WriteLine("\nListing distinct price and type of all rooms at Hotel Prindsen:");

            var prindsenRoomsDistinct =
                (from room in rooms
                where room.Hotel.Name == "Prindsen" 
                select new { price = room.Price, type = room.Types }).Distinct();

            prindsenRoomsDistinct = prindsenRoomsDistinct.Distinct();

            foreach (var prindsenRoom in prindsenRoomsDistinct)
            {
                Console.WriteLine("Price: {0} -> Type: {1}", prindsenRoom.price, prindsenRoom.type);
            }

            Console.ReadKey();
        }
    }
}
