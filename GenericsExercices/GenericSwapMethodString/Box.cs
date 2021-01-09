using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodString
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }

        
        public void Swap(int indexOne, int indexTwo)
        {
            T temp = this.items[indexOne];
            this.items[indexOne] = this.items[indexTwo];
            this.items[indexTwo] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (var item in items)
            {
                sb.AppendLine($"System.String: {item}");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
