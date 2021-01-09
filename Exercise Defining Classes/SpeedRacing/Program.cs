using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SpeedRacing
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCars; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                var carModel = carInfo[0];
                var carFuelAmount = double.Parse(carInfo[1]);
                var carFuelConsumptionPerKm = double.Parse(carInfo[2]);
                var travelledDistance = 0;

                Car car = new Car(carModel, carFuelAmount, carFuelConsumptionPerKm,travelledDistance);

                cars.Add(car);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }
                else
                {
                    var driveInfo = input.Split().ToArray();

                    var carModel = driveInfo[1];
                    var travelledKm = double.Parse(driveInfo[2]);

                    foreach (var car in cars)
                    {
                        if (car.Model == carModel)
                        {
                            car.DriveCar(car, travelledKm);
                        }
                    }

                }

                
            }


            foreach (var car  in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
