using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
   public class Tuple<T1,T2>
    {
        private T1 first;
        private T2 second;

       
        public Tuple(T1 first,T2 second )
        {
            this.first = first;
            this.second = second;
        }

        public string GetInfo()
        {
            return $"{this.first} -> {this.second}";
        }
    }
}
