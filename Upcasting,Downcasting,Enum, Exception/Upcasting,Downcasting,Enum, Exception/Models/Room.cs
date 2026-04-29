using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting_Enum__Exception.Models
{
    public class Room
    {
        private static int _idCounter = 0;

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room(string name, double price, int personCapacity) 
        {
         _idCounter++;
         Id = _idCounter++;

         Name = name;
         Price = price;
         PersonCapacity = personCapacity;
        
        }

        public string ShowInfo() 
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Capacity: {PersonCapacity}, Available: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo() ;
        }
    }
}
