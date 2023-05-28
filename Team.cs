using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        

        public double AverageAge()
        {
            int totalAge = Players.Sum(player => player.Age);
            return (double)totalAge / Players.Count;
        }

        public bool CheckTeamsPlayerCount()
        {
            if (Players.Count != 11)
            {
                return false;
            }
            return true;
        }
    }
}
