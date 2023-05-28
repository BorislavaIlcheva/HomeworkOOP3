using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tName1 = "Besiktas";
            string tName2 = "Fenerbah4e";

            var player1_01 = new Goalkeeper { Name = "Ersin", Number = 1, Age = 26, Height = 189, TeamName = tName1 };
            var player1_02 = new Defender { Name = "Kerem", Number = 2, Age = 22, Height = 190, TeamName = tName1 };
            var player1_03 = new Defender { Name = "Utku", Number = 3, Age = 22, Height = 190, TeamName = tName1 };
            var player1_04 = new Defender { Name = "Salih", Number = 4, Age = 22, Height = 190, TeamName = tName1 };
            var player1_05 = new Defender { Name = "Atiba", Number = 5, Age = 22, Height = 190, TeamName = tName1 };
            var player1_06 = new Midfield { Name = "Rozie", Number = 6, Age = 28, Height = 179, TeamName = tName1 };
            var player1_07 = new Midfield { Name = "Nkudu", Number = 7, Age = 28, Height = 179, TeamName = tName1 };
            var player1_08 = new Midfield { Name = "Jetson", Number = 8, Age = 28, Height = 179, TeamName = tName1 };
            var player1_09 = new Midfield { Name = "Gezal", Number = 9, Age = 28, Height = 179, TeamName = tName1 };
            var player1_10 = new Striker { Name = "Djenk", Number = 10, Age = 25, Height = 184, TeamName = tName1 };
            var player1_11 = new Striker { Name = "Abubakar", Number = 11, Age = 25, Height = 184, TeamName = tName1 };

            var player2_01 = new Goalkeeper { Name = "Chetin", Number = 1, Age = 26, Height = 189, TeamName = tName2 };
            var player2_02 = new Defender { Name = "Gustavo", Number = 2, Age = 22, Height = 190, TeamName = tName2 };
            var player2_03 = new Defender { Name = "Peres", Number = 3, Age = 22, Height = 190, TeamName = tName2 };
            var player2_04 = new Defender { Name = "King", Number = 4, Age = 22, Height = 190, TeamName = tName2 };
            var player2_05 = new Defender { Name = "Zai4", Number = 5, Age = 22, Height = 190, TeamName = tName2 };
            var player2_06 = new Midfield { Name = "Rozie", Number = 6, Age = 28, Height = 179, TeamName = tName2 };
            var player2_07 = new Midfield { Name = "Pedro", Number = 7, Age = 28, Height = 179, TeamName = tName2 };
            var player2_08 = new Midfield { Name = "Emre Mor", Number = 8, Age = 28, Height = 179, TeamName = tName2 };
            var player2_09 = new Midfield { Name = "Arda", Number = 9, Age = 28, Height = 179, TeamName = tName2 };
            var player2_10 = new Striker { Name = "Batsuai", Number = 10, Age = 25, Height = 18, TeamName = tName2 };
            var player2_11 = new Striker { Name = "Valensia", Number = 11, Age = 25, Height = 184, TeamName = tName2 };

            var coach1 = new Coach { Name = "Senola Gunes", Age = 65 };
            var coach2 = new Coach { Name = "Jetson", Age = 75 };

            var team1 = new Team { Coach = coach1, 
                Players = new List<FootballPlayer> 
                { player1_01, player1_02, player1_03, 
                  player1_04, player1_05, player1_06, 
                  player1_07, player1_08, player1_09, 
                  player1_10, player1_11} };

            var team2 = new Team  {  Coach = coach2,
                Players = new List<FootballPlayer> 
                { player2_01, player2_02, player2_03, 
                  player2_04, player2_05, player2_06, 
                  player2_07, player2_08, player2_09, 
                  player2_10, player2_11 }
            };
            
            
            double averageAge1 = team1.AverageAge();
            double averageAge2 = team2.AverageAge();


            var referee = new Referee { Name = "Mark", Age = 40 };
            var assistantReferee1 = new Referee { Name = "Nikolay", Age = 33 };
            var assistantReferee2 = new Referee { Name = "Pavel", Age = 30 };
            var assistantReferees = new List<Referee> { assistantReferee1, assistantReferee2 };


            var g1 = new Goal { Minute = 23, Player = player1_11 };
            var g2 = new Goal { Minute = 33, Player = player2_10 };
            var g3 = new Goal { Minute = 73, Player = player1_09 };
            var g4 = new Goal { Minute = 93, Player = player1_09 };

            var game = new Game
            {
                Team1 = team1,
                Team2 = team2,
                Referee = referee,
                AssistantReferees = assistantReferees,
                Goals = { g1, g2, g3,g4 }
            };

            game.PrintResult();
            game.PrintGMaytori();

            Console.ReadKey();
        }
        
    }
}
