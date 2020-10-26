using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Heroes
{
    class HeroRepository
    {

        //•	Field data – collection that holds added heroes
        //•	Method Add(Hero hero) – adds an entity to the data.
        //•	Method Remove(string name) – removes an entity by given hero name.
        //•	Method GetHeroWithHighestStrength() – returns the Hero which poses the item with the highest stength.
        //•	Method GetHeroWithHighestAbility() – returns the Hero which poses the item with the highest ability.
        //•	Method GetHeroWithHighestIntelligence() – returns the Hero which poses the item with the highest intellgence.
        //•	Getter Count – returns the number of stored heroes.
        //•	Оverride ToString() – Print all the heroes.

        private List<Hero> data = new List<Hero>();

        public int Count => data.Count;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            
            this.data.Remove(this.data.FirstOrDefault(h => h.Name == name));
        }

       public Hero GetHeroWithHighestStrength()
        {

            int maxStrength = data.Max(s => s.Item.Strength);
            Hero heroMaxStrength = data.FirstOrDefault(h => h.Item.Strength == maxStrength);

            return heroMaxStrength;
 
        }

        public Hero GetHeroWithHighestAbility()
        {
            int highestAbility = data.Max(a => a.Item.Ability);
            Hero heroHighestAbility = data.FirstOrDefault(h => h.Item.Ability==highestAbility);
            return heroHighestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int highestIntelligence = data.Max(i => i.Item.Intelligence);
            Hero heroHighestIntelligence = data.FirstOrDefault(h => h.Item.Intelligence == highestIntelligence);
            return heroHighestIntelligence;
        }
        //Hero: Hero Name - 24lvl
        //Item:
        //*Strength: 23
        //    * Ability: 35
        //    * Intelligence: 48
        //Hero: Second Hero Name - 125lvl
        //Item:
        //    * Strength: 100
        //    * Ability: 20
        //    * Intelligence: 13

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var hero in this.data)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
