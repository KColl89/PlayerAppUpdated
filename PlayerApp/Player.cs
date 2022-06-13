using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlayerApp
{
    /// <summary>
    /// Implements IPlayer
    /// Id is readonly and Name can be changed at any time by the user 
    /// </summary>
    public class Player : IPlayer 
	{
		string filepath = @"C:\Users\yung_\Desktop\Quintrx\PlayerApp\PlayerApp\Info.txt";

		private readonly Guid _id = Guid.NewGuid();
		private string _name = "";
		private string _email ="";
		private int _playerLevel;
		public Guid Id { get { return _id; } }

		public string Name { get { return _name; } set { _name = value; } }

		public string Email { get { return _email; } set { _email = ValidateEmail(value); } }

		public int PlayerLevel { get { return _playerLevel; } set { _playerLevel = value; } }

		public string Info { get { return Name + " " + Email + " " +PlayerLevel; } }

		/// <summary>
		/// Method that takes input and validates that it is indeed an email.
		/// </summary>
		/// <param name="input">String</param>
		/// <returns>Returns error message or input.</returns>
		static string ValidateEmail(string input)

		{
			
			string error = "Enter a proper email address";
			Regex _validEmailPattern = new Regex(
			   @"^[a-zA-Z]\w*@(\w+\.)+\w+$",
			   RegexOptions.Compiled
			   );

			if (!_validEmailPattern.IsMatch(input))
			{
				do
				{
					Console.WriteLine(error);
					input = Console.ReadLine();
				}while (!_validEmailPattern.IsMatch(input));
				
			}
			
				return input;
			
		}
		
		public static List<Player> PLayerList(int size) 
		{
			List<Player> list = new List<Player>();
			for (int i = 0; i < size; i++)
            {
				list.Add(new Player());
                Console.WriteLine("Enter player name:");
                list[i].Name = Console.ReadLine();
				Console.WriteLine("Enter player email:");
				list[i].Email = Console.ReadLine();
				Console.WriteLine("Enter player level:");
				list[i].PlayerLevel = Int32.Parse(Console.ReadLine());
            }
			return list;
		}
		public static string FindPlayer(List<Player> list,int index)
        {
			int pick = list.Count - 1;
            return list[pick].Info;
        }
    }
		

}
