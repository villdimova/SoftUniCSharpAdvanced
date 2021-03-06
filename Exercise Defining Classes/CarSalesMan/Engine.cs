﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CarSalesMan
{
    class Engine
    {
        //V8-101 220 50

        

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int displacement) 
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power,int displacement, string efficiency) 
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }


        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }


    }
}
