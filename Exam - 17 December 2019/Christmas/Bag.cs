using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count;



        private Bag()
        {
            this.data = new List<Present>();
        }

        public Bag(string color,int capacity):this()
        {
            this.Color = color;
            this.Capacity = capacity;
        }



        public void Add(Present present)
        {
            if (this.data.Count+1<=this.Capacity)
            {
                this.data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present present = data.FirstOrDefault(p => p.Name == name);
            if (present!=null)
            {
                return true;
            }
            else
            {
                return false;
            }  

        }

        public Present GetHeaviestPresent()
        {
            Present present = this.data.OrderByDescending(p => p.Weight).FirstOrDefault();
            return present;
        }

        public Present GetPresent(string name)
        {
            Present present = data.FirstOrDefault(p => p.Name == name);
            return present;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();

        }
    }
}
