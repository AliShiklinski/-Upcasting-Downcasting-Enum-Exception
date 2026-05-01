using System;
using System.Collections.Generic;
using System.Text;
using Upcasting_Downcasting_Enum__Exception_2.Models;

namespace Upcasting_Downcasting_Enum__Exception_2.Services
{
    public class CarService
    {
        public void ShowCar(Car car)
        {
            Console.WriteLine(car);
        }

        public void ShowAllCars(Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
