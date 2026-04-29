using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting_Enum__Exception.Models
{
    public class Hotel
    {
        public string Name { get; set; }

        private Room[] Rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
                throw new NullReferenceException("RoomId cannot be null!");

            Room foundRoom = null;

            foreach (var room in Rooms)
            {
                if (room.Id == roomId)
                {
                    foundRoom = room;
                    break;
                }
            }

            if (foundRoom == null)
            
                throw new Exception("Room not found!");
            

            if (!foundRoom.IsAvailable) 
            
                throw new Exceptions.NotAvailableException("This room is already reserved!");

                foundRoom.IsAvailable = false;

                Console.WriteLine("The reservation was successful!");

        }

        public void ShowAllRooms() 
        {
            foreach (var room in Rooms)
            {
                Console.WriteLine(room);
            }
        }
    }
}
