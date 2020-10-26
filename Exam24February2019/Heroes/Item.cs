using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        //Properties
        //•	Strength: int
        //•	Ability: int
        //•	Intelligence: int

        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Strength: {Strength}");
            sb.AppendLine($"Ability: {Ability}");
            sb.AppendLine($"Intel: {Intelligence}");
            return sb.ToString().Trim();
        }
    }
}
