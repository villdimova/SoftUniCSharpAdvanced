using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
   public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptionRerKilometer, double travelledDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionRerKilometer;
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }


        public void DriveCar(Car car, double travelledDistance)
        {
            double usedFuel = 0;

            usedFuel = car.FuelConsumptionPerKilometer * travelledDistance;

            if (FuelAmount - usedFuel < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.FuelAmount -= usedFuel;
                car.TravelledDistance += travelledDistance;

            }

        }
    }


}
