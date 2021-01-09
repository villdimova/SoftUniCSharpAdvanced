using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CarSalesMan
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countEngines; i++)
            {
                var engineInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 2)
                {

                    Engine engine = new Engine(engineModel, enginePower);
                    engines.Add(engine);
                }

                else if (engineInfo.Length == 3)
                {
                    string optionalInfo= engineInfo[2];
                    
                   
                    if (char.IsDigit(optionalInfo[0]))
                    {
                        int engineDisplacement = int.Parse(optionalInfo);
                        Engine engine = new Engine(engineModel, enginePower, engineDisplacement);
                        engines.Add(engine);
                    }

                    else
                    {
                        string engineEfficiency = engineInfo[2];
                        Engine engine = new Engine(engineModel, enginePower, engineEfficiency);
                        engines.Add(engine);

                    }
                     
                   
                    
                }
                else if (engineInfo.Length == 4)
                {
                    int engineDisplacement = int.Parse(engineInfo[2]);
                    string engineEfficiency = engineInfo[3];
                    Engine engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
                    engines.Add(engine);
                }


            }

            int numCars = int.Parse(Console.ReadLine());

            //FordFocus V4-33 1300 Silver
            //FordMustang V8 - 101
            //VolkswagenGolf V4-33 Orange


            for (int i = 0; i < numCars; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var carModel = carInfo[0];
                string engineModel = carInfo[1];
                Engine carEngine = engines.Where(e => e.Model == engineModel).FirstOrDefault();
                if (carInfo.Length == 2)
                {
                    Car car = new Car(carModel, carEngine);
                    cars.Add(car);

                }
                else if (carInfo.Length == 3)
                {
                    string optionalInfo = carInfo[2];
                    
                    
                    if (char.IsDigit(optionalInfo[0]))
                    {
                        int weigth = int.Parse(optionalInfo);
                        Car car = new Car(carModel, carEngine, weigth);
                        cars.Add(car);
                    }
                    else
                    {
                        string colour = optionalInfo;
                        Car car = new Car(carModel, carEngine, colour);
                        cars.Add(car);
                    }
                    

                }
                else if (carInfo.Length == 4)
                {
                    int weigth = int.Parse(carInfo[2]);
                    string colour = carInfo[3];
                    Car car = new Car(carModel, carEngine, weigth,colour);
                    cars.Add(car);

                }


            }



            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement==0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                if (car.Engine.Efficiency==null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                
                
                if (car.Weigth==0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weigth}");
                }
                if (car.Colour==null)
                {
                    Console.WriteLine($"  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {car.Colour}");
                }
                
            }
        }
    }
}
