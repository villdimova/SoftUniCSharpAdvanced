using System;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {

        public CustomStack()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements { get; set; }

        public void Push(T item)
        {
            this.Elements.Add(item);
        }
        public T Pop()
        {

            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            var item = this.Elements[this.Elements.Count - 1];
            this.Elements.RemoveAt(this.Elements.Count - 1);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Elements.Count - 1; i >= 0; i--)
            {
                yield return this.Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
