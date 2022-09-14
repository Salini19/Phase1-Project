using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerandTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("        Player and Team Requirements ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string input;
            do
            {


                Console.WriteLine("Enter \n 1:To Add Player \n 2:To Remove Player by Id \n 3.Get Player By Id \n 4.Get Player by Name \n 5.Get All Players:");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Player player = new Player();
                OneDayTeam team = new OneDayTeam();
                switch (option)
                {
                    case 1:
                        
                        team.Add(player);
                        break;
                    case 2:
                        team.Remove(player.PlayerID);
                        break;
                    case 3:
                        team.GetPlayerById(player.PlayerID);
                        break;
                    case 4:
                        team.GetPlayerByName(player.PlayerName);
                        break;
                    case 5:
                        team.GetAllPlayers();
                        break;

                    default:
                        Environment.Exit(1);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to repeat? Yes/No");
                input = Console.ReadLine();

            }
            while (input == "yes");

            Console.WriteLine("Thank You");

            Console.ReadLine();
        }
    }
}
