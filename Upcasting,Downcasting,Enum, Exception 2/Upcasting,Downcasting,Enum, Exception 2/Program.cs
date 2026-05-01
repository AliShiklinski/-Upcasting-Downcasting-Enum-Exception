using Upcasting_Downcasting_Enum__Exception_2.Models;
using Upcasting_Downcasting_Enum__Exception_2.Services;

public class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("BMW", "F90", CarType.Sedan);
        Car car2 = new Car("Mercedes", "E300", CarType.Sedan);


        Car[] cars = { car1, car2 };


        CarService service = new CarService();


        service.ShowAllCars(cars);

    }

}