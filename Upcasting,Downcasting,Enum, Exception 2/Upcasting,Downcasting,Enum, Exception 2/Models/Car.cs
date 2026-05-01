using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_Downcasting_Enum__Exception_2.Models
{
    public class Car
    {
        private static int _idCounter = 0;

        public int Id { get; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public CarType Type { get; set; }

        public Car(string model, string brand, CarType type)
        {
            _idCounter++;
            Id = _idCounter;

            Model = model;
            Brand = brand;
            Type = type;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Model: {Model}, Brand: {Brand} Type: {Type}";
        }
    }
}
