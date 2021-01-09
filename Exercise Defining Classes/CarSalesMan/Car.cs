using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesMan
{
    class Car
    {

        
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine,int weigth) 
        {
            this.Model = model;
            this.Engine = engine;
            this.Weigth = weigth;
        }
        public Car(string model, Engine engine, string colour) 
        {
            this.Model = model;
            this.Engine = engine;
            this.Colour = colour;
        }
        public Car(string model, Engine engine, int weigth,string colour) 
        {
            this.Model = model;
            this.Engine = engine;
            this.Weigth = weigth;
            this.Colour = colour;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weigth { get; set; }

        public string Colour { get; set; }
    }
}
