using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Game()
        {
            AssistantReferees = new List<Referee>();
            Goals = new List<Goal>();
        }

        private void InitKraenResulat()
        {
            if (Team1.CheckTeamsPlayerCount() == false)
            {
                Console.WriteLine("Gresen Broy Players");
                return;
            }
            if (Team2.CheckTeamsPlayerCount() == false)
            {
                Console.WriteLine("Gresen Broy Players");
                return;
            }
            var g1 = Goals.Count(x => x.Player.TeamName == Team1.Players[0].TeamName);
            var g2 = Goals.Count(x => x.Player.TeamName == Team2.Players[0].TeamName);
            if (g1 > g2)
            {
                Winner = Team1;
            }
            else if (g1 < g2)
            {
                Winner = Team2;
            }
            else
            {
                Winner = null;
            }
            Result = String.Format("{0} : {1}{2}{3} - {4}", Team1.Players[0].TeamName,
                Team2.Players[0].TeamName, Environment.NewLine, g1, g2);
        }

        public void PrintResult()
        {
            InitKraenResulat();
            Console.WriteLine("Game result: " + Environment.NewLine + Result);
            if (Winner == null)
            {
                Console.WriteLine("Winner: Raven");
            }
            else
            {
                Console.WriteLine("Winner: " + Winner.Players[0].TeamName);
            }
        }

        private void Print(List<Goal> gm)
        {
            foreach (var g in gm)
            {
                Console.WriteLine("Number: {0}, Minute: {1}, PLayer: {2}, Age: {3}, Postion: {4}, Height: {5}",
                g.Player.Number,
                g.Minute,
                g.Player.Name,
                g.Player.Age,
                g.Player.GetType().Name,
                g.Player.Height);
            }
        }

        public void PrintGMaytori()
        {
            List<Goal> gm1 = Goals.Where(x => x.Player.TeamName == Team1.Players[0].TeamName).ToList();
            List<Goal> gm2 = Goals.Where(x => x.Player.TeamName == Team2.Players[0].TeamName).ToList();
            Console.WriteLine("Golmaystori");

            Console.WriteLine(Team1.Players[0].TeamName + ": ");
            Print(gm1);

            Console.WriteLine(Team2.Players[0].TeamName + ": ");
            Print(gm2);

        }
    }
}
