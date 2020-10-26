using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
   public class Cage
    {
        private List<Rabbit> data;

        public int Count => this.data.Count;

        private Cage()
        {
            this.data = new List<Rabbit>();
        }
        public Cage(string name, int capacity):this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Rabbit rabbit)
        {
            if (this.Count < this.Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            
              return  this.data.Remove(this.data.FirstOrDefault(r => r.Name == name));
            
        }

        public void RemoveSpecies(string species)
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Species == species)
                {
                    data.Remove(rabbit);
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                rabbit.Available = false;
            }


            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> selledRabbits = new List<Rabbit>();
            foreach (var rabbit in data)
            {
                if (rabbit.Species == species)
                {
                    rabbit.Available = false;
                    selledRabbits.Add(rabbit);
                }
            }


            return selledRabbits.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in data.Where(r => r.Available == true))
            {
                sb.AppendLine(rabbit.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
