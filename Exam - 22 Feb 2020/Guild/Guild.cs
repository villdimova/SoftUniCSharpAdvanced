using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
   public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.roster.Count;

        public void AddPlayer(Player player)
        {
            if (this.roster.Count+1<=this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (roster.Any(p=>p.Name==name))
            {
                this.roster.Remove(this.roster.FirstOrDefault(p => p.Name == name));
                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            if (player.Rank!="Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string clas)
        {
            Player[]kickedPlayers= roster.Where(p => p.Class == clas).ToArray();
            roster.RemoveAll(p => p.Class == clas);

            return kickedPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
