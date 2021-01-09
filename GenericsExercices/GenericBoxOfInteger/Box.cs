using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public void Add(T item)
        {
            this.boxCollection.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in boxCollection)
            {
                sb.AppendLine($"System.Int32: {item}");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
