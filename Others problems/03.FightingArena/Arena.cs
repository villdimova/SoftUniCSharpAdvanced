using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.gladiators = new List<Gladiator>();
            this.Name = name;
        }

        public string Name { get; set; }
        public int Count => this.gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            gladiators.Remove(this.gladiators.FirstOrDefault(g => g.Name == name));
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            int maxPower = 0;
            Gladiator mostPowerfulGladiator = null;
            foreach (var gladiator in gladiators)
            {
                int currentPower = gladiator.GetStatPower();
                if (currentPower > maxPower)
                {
                    maxPower = currentPower;
                    mostPowerfulGladiator = gladiator;
                }
            }
            return mostPowerfulGladiator;
        }
        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            int maxPower = 0;
            Gladiator mostPowerfulGladiator = null;
            foreach (var gladiator in gladiators)
            {
                int currentPower = gladiator.GetWeaponPower();
                if (currentPower > maxPower)
                {
                    maxPower = currentPower;
                    mostPowerfulGladiator = gladiator;
                }
            }
            return mostPowerfulGladiator;
        }
        public Gladiator GetGladitorWithHighestTotalPower()
        {
            int maxPower = 0;
            Gladiator mostPowerfulGladiator = null;
            foreach (var gladiator in gladiators)
            {
                int currentPower = gladiator.GetTotalPower();
                if (currentPower > maxPower)
                {
                    maxPower = currentPower;
                    mostPowerfulGladiator = gladiator;
                }
            }
            return mostPowerfulGladiator;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}

