using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static PlayerApp.IPlayer;
using Extension;
using System.IO;
using System.Text.Json;

namespace PlayerApp
{
	class Program 
	{

		static PlayerDelegate listPlayer = new PlayerDelegate(Player.PLayerList);

        public static void Main()
		{
			string filepath = @"C:\Users\yung_\Desktop\Quintrx\PlayerApp\PlayerApp\Info.txt";
			string dem = "the end";
		
			int numbOfPlayers;
			

			Console.WriteLine("How many players?");
			numbOfPlayers = Convert.ToInt32(Console.ReadLine());
			List<String> lines = new List<String>();
			List<String> outinfo = new List<String>();
			List<Player> players = listPlayer(numbOfPlayers);
			lines = File.ReadAllLines(filepath).ToList();
			foreach (String line in lines)
			{

				Player player = new Player();

				int playerToView;
			Console.WriteLine($"Which player do you wish to view? Pick number between 1 and {players.Count}");
			playerToView = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Player.FindPlayer(players, playerToView));
			Console.WriteLine("Press 'A' to view all");
			char view = Char.ToLower((char)Console.Read());
            switch(view)
			{
				case 'a':
					foreach (Player p in players)
					{
						Console.WriteLine(p.Info);
					}
					break;

				default:
					break;

			}
			
			foreach (Player p in players)
            {
                outinfo.Add(p.Info);
				File.AppendAllLines(filepath, outinfo);
			}
			players.Add(player);
			}

			dem.endProgram();
			


		}
	

	}

	

}

