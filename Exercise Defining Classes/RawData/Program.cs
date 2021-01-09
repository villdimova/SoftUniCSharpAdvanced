using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCars; i++)
            {
                var carInfo = Console.ReadLine().Split().ToArray();
                

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);


                Tire[] tires = new Tire[4];
               
                int counter = 0;
                for (int j = 0; j < 7; j+=2)
                {
                    
                    Tire tire = new Tire(double.Parse(carInfo[j + 5]), int.Parse(carInfo[j + 6]));
                    tires[counter] = tire;
                    counter++;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string filterCriteria = Console.ReadLine();

            List<Car> selectedCars = new List<Car>();

            if (filterCriteria== "fragile")
            {
                cars = cars
                    .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(p => p.TirePressure < 1))
                    .ToList();
 
                
            }

            else if (filterCriteria== "flamable")
            {
                cars = cars
                    .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower>250)
                    .ToList();

               
            }


            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }

        }
    }
}
