using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T>
        where T:IComparable<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            this.boxCollection.Add(item);
        }

        

        public int  Compare(T item)
        {
            
            foreach (var element in this.boxCollection)
            {

                if (element.CompareTo(item)>0)
                {
                        this.Count++;
                }
            }

            return Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in boxCollection)
            {
                sb.AppendLine($"System.String: {item}");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
