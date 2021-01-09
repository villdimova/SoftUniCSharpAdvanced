using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
   public class Threeuple<Item1,Item2,Item3>
    {
       
        public Threeuple(Item1 itemOne, Item2 itemTwo,Item3 itemThree)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
            this.ItemThree = itemThree;

        }

        public Item1 ItemOne { get; set; }
        public Item2 ItemTwo { get; set; }
        public Item3 ItemThree { get; set; }


        public string GetInfo()
        {
            return $"{this.ItemOne} -> {this.ItemTwo} -> {this.ItemThree}";
        }



    }
}
