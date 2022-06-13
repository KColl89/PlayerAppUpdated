using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
	/// <summary>
	/// Every player must have an ID and a name.
	/// The ID is auto genaterated and readonly.
	/// The name can be empty or changed at any time.
	/// </summary>
	public interface IPlayer 
	{
		Guid Id { get; }
		string Name { get; set; }
		string Email { get; set; }
		int PlayerLevel { get; set; }

		public delegate List<Player> PlayerDelegate(int x);
	}
}
