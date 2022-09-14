using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayerandTeam
{
    internal class OneDayTeam : ITeam
    {
        public int Capacity { get; set; }
    

        public static List<Player> onedayteam = new List<Player>();
       
        public OneDayTeam()
        {
            onedayteam.Capacity = 11;   
        }
        public void Add(Player player)
        {
            
            if (onedayteam.Count < onedayteam.Capacity)
            {
                Console.WriteLine("Enter details of Player to add");                
                Console.WriteLine("Enter Player ID ");
                player.PlayerID = int.Parse(Console.ReadLine());
                Player check = onedayteam.Find(x => x.PlayerID == player.PlayerID);
                if (check == null)
                {
                   
                    Console.WriteLine("Enter Player Name");
                    player.PlayerName = Console.ReadLine();
                    Console.WriteLine("Enter Player Age");
                    player.Age = int.Parse(Console.ReadLine());

                    onedayteam.Add(player);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player is Added Successfully");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PlayerID already exists");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("team is full");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            
        }
        public void Remove(int Id)
        {
            if (onedayteam.Count < onedayteam.Capacity)
            {

                Console.WriteLine("Enter Player Id to Remove ");
                Id = int.Parse(Console.ReadLine());

                Player removeplayer = onedayteam.Find(x => x.PlayerID == Id);
                if (removeplayer != null)
                {
                    onedayteam.Remove(removeplayer);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player is Removed Successfully");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("Player ID is not found in the list");
                }              

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player list is Empty");
                Console.ForegroundColor = ConsoleColor.White;
            }



        }

        public Player GetPlayerById(int playerId)
        {


            Console.WriteLine("Enter Player ID");
            playerId = int.Parse(Console.ReadLine());
            Console.WriteLine();


            Player searchplayer = onedayteam.Find(x => x.PlayerID == playerId);
            if (searchplayer != null)
            {
                Console.WriteLine("Player Details");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Player ID   : " + searchplayer.PlayerID);
                Console.WriteLine("Player Name : " + searchplayer.PlayerName);
                Console.WriteLine("Player Age  : " + searchplayer.Age);
                Console.ForegroundColor = ConsoleColor.White;


            }
            else
            {
                Console.WriteLine("Player ID is not found in the list");
            }

            return searchplayer;

        }
        public Player GetPlayerByName(string pname)
        {
            Console.WriteLine("Enter Player Name");
            pname = Console.ReadLine();
            Console.WriteLine();

           
            Player searchplayer = onedayteam.Find(x => x.PlayerName == pname);
            if (searchplayer != null)
            {
                Console.WriteLine("Player Details");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player ID   : " + searchplayer.PlayerID);
                Console.WriteLine("Player Name : " + searchplayer.PlayerName);
                Console.WriteLine("Player Age  : " + searchplayer.Age);
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.WriteLine("Player Name is not found in the list");
            }

            return searchplayer;
        }
        public List<Player> GetAllPlayers()
        {           
            Console.WriteLine("Team Players");
            Console.WriteLine();
            foreach (var item in onedayteam)
            {
                Console.WriteLine("Player ID   : " + item.PlayerID);
                Console.WriteLine("Player Name : " + item.PlayerName);
                Console.WriteLine("Player Age  : " + item.Age);
                Console.WriteLine();

            }
            return onedayteam;
        }
    }
}
